using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLab.Net
{
    internal class Logic
    {

        public string ej1()
        {
            Console.WriteLine("Ingrese un valor como divisor de 10");
            string input = Console.ReadLine();
            int value = 10;
            double result = 0;
            try
            {
                result = value / Int32.Parse(input);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return "La division no pudo ser completada";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "La division no pudo ser completada";
            }
            return $"El resultado de la division es {result}";
        }


        public string ej2()
        {
            Console.WriteLine("Ingrese un valor como dividendo");
            string input1 = Console.ReadLine();
            Console.WriteLine("Ingrese un valor como divisor");
            string input2 = Console.ReadLine();
            double result = 0;
            try
            {
                result = Int32.Parse(input1) / Int32.Parse(input2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return "Solo Chuck Norris divide por cero! ";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return "Seguro Ingreso una letra o no ingreso nada!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "La division no pudo ser completada";
            }
            return $"El resultado de la division es {result}";
        }


        public string ej3()
        {
            int[] array = new int[1];
            return $"Ejercicio 4  {array[1]}";
        }


        public string ej4()
        {
            Console.WriteLine("Ingrese su nombre");
            string name = Console.ReadLine();
            if (name != "Chuck Norris")
                throw new Exceptions.NotChuckNorrisException();
            return "Hola Chuck";
        }

    }
}
