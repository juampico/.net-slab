using Slab.Net.EF.Commons.Exceptions;
using Slab.Net.EF.Entities;
using Slab.Net.EF.Logic;
using System;
using System.Collections.Generic;

namespace Slab.Net.EF.UI
{
    internal class Program
    {
        readonly static ShippersLogic shippersLogic = new ShippersLogic();
        readonly static CustomersLogic customersLogic = new CustomersLogic();
        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }

        static void Menu()
        {
            CustomersUI customersUI = new CustomersUI();
            ShippersUI shippersUI = new ShippersUI();
            char option = ' ';
            string id;
            bool flag = false;
            while (option != 's')
            {
                Console.Clear();
                Console.WriteLine("Ingrese la opcion que desea ejecutar o 's' para salir del programa \n" +
                    "1. Listar todos los clientes \n" +
                    "2. Listar todos los transportistas \n" +
                    "3. Buscar cliente por ID \n" +
                    "4. Buscar transportista por ID \n" +
                    "5. Agregar transportista \n" +
                    "6. Eliminar transportista por ID \n" +
                    "7. Agregar cliente \n" +
                    "8. Eliminar cliente por ID \n" +
                    "9. Actualizar transportista por ID");
                option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case '1':
                        Console.Clear();
                        customersUI.ListShippers();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case '2':
                        Console.Clear();
                        shippersUI.ListShippers();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case '3':
                        while (!flag)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el ID del cliente que desea buscar");
                            try
                            {
                                id = Console.ReadLine();
                                flag = true;
                                customersUI.PrintCustomer(id);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        flag = false;
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case '4':
                        while (!flag)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el ID del transportista que desea buscar");
                            try
                            {
                                id = Console.ReadLine();
                                shippersUI.PrintShipper(Int32.Parse(id));
                                flag = true;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        flag = false;
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case '5':
                        Console.Clear();
                        shippersUI.AddShipper();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case '6':
                        while (!flag)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el ID del transportista que desea eliminar");
                            try
                            {

                                id = Console.ReadLine();
                                flag = true;
                                shippersUI.RemoveShipper(Int32.Parse(id));
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("El ID debe ser de tipo entero");
                            }
                        }
                        flag = false;
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case '7':
                        Console.Clear();
                        customersUI.AddCustomer();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case '8':
                        Console.Clear();
                        Console.WriteLine("Ingrese el ID del cliente que desea eliminar");
                        id = Console.ReadLine();
                        customersUI.RemoveCustomer(id);
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case '9':
                        while (!flag)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el ID del transportista que desea actualizar");
                            try
                            {

                                id = Console.ReadLine();
                                flag = true;
                                shippersUI.UpdateShipper(Int32.Parse(id));
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("El ID debe ser de tipo entero");
                            }
                        }
                        flag = false;
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case 's':
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion incorrecta");
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                }

            }
        }        
    }
}
