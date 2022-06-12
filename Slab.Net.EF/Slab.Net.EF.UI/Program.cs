using Slab.Net.EF.Commons.Exceptions;
using Slab.Net.EF.Entities;
using Slab.Net.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Slab.Net.EF.UI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Menu();
            //customersLogic.GetCustomerAndOrdersQuantityQS();
            Console.ReadLine();
        }


        static void Menu()
        {
            CustomersUI customersUI = new CustomersUI();
            ProductsUI productsUI = new ProductsUI();
            string option = "";
            while (option != "s")
            {
                Console.Clear();
                Console.WriteLine("Ingrese la opcion que desea ejecutar o 's' para salir del programa \n" +
                    "1. Query para devolver objeto customer \n" +
                    "2. Query para devolver todos los productos sin stock \n" +
                    "3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad \n" +
                    "4. Query para devolver todos los customers de la Región WA \n" +
                    "5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789 \n" +
                    "6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula. \n" +
                    "7. Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1 / 1 / 1997. \n" +
                    "8. Query para devolver los primeros 3 Customers de la  Región WA \n" +
                    "9. Query para devolver lista de productos ordenados por nombre \n" +
                    "10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor. \n" +
                    "11. Query para devolver las distintas categorías asociadas a los productos \n" +
                    "12. Query para devolver el primer elemento de una lista de productos \n" +
                    "13. Query para devolver los customer con la cantidad de ordenes asociadas");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        customersUI.CustomerObject();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        productsUI.ListProductsNonStock();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        productsUI.ListProductsWithStockAndPricePerUnitGreather(3);
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        customersUI.ListCustomersByRegion("WA");
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        productsUI.FirstProductsById(789);
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Clear();
                        customersUI.ListLowerAndUpperCustomersName();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.Clear();
                        DateTime date = new DateTime(1997, 1, 1);
                        customersUI.ListCustomersAndOrdersByRegionAndDateGreather("WA", date);
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "8":
                        Console.Clear();
                        customersUI.FirstNCustomersByRegion(3,"WA");
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "9":
                        Console.Clear();
                        productsUI.ListProductsOrderByName();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "10":
                        Console.Clear();
                        productsUI.ListProductsOrderByUnitInStockDesc();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "11":
                        Console.Clear();
                        productsUI.ListProductsCategories();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "12":
                        Console.Clear();
                        productsUI.FirstProduct();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "13":
                        Console.Clear();
                        customersUI.ListCustomersAndOrdersQuantity();
                        Console.WriteLine("---- Oprima ENTER para volver al menú ----");
                        Console.ReadLine();
                        break;
                    case "s":
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
