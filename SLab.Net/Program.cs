using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLab.Net
{
    internal class Program
    {


        static Logic logic = new Logic();
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            char c = ' ';
            while (c != 's')
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese el numero del ejercicio(1-5) que desea ejecutar o 's' para salir del programa");
                c = Console.ReadKey().KeyChar;
                switch (c)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine(logic.ej1());
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine(logic.ej2());
                        break;
                    case '3':
                        Console.Clear();
                        try
                        {
                            Console.WriteLine(logic.ej3());
                        }
                        catch(IndexOutOfRangeException ex)
                        {
                            Console.WriteLine($"Mensaje de la excepcion: {ex.Message}");
                            Console.WriteLine($"Tipo de la excepcion: {ex.GetType()}");
                        }
                        break;
                    case '4':
                        Console.Clear();
                        try
                        {
                            Console.WriteLine(logic.ej4());
                        }
                        catch (Exceptions.NotChuckNorrisException ex)
                        {
                            Console.WriteLine($"Mensaje de la excepcion: {ex.Message}");
                            Console.WriteLine($"Tipo de la excepcion: {ex.GetType()}");
                        }
                        break;
                    case 's':
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

            }
        }

    }
}
