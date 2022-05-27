using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLab.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = ' ';
            while (c != 's'){
                Console.WriteLine("Ingrese 'y' para ejecutar el ejercicio del TP1 o 's' para terminar el programa");
                c = Console.ReadKey().KeyChar;
                Console.Clear();
                if (c == 'y')
                   ejTP1();
            }
        }

        public static void ejTP1()
        {
            List<TransportePublico> transportes = new List<TransportePublico>();
            string aux;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(String.Format("Ingrese la cantidad de pasajeros para el omnibus numero {0}", i));
                aux = Console.ReadLine();
                try
                {
                    transportes.Add(new Omnibus(Int32.Parse(aux), i));
                }
                catch (FormatException e)
                {
                    i--;
                    Console.WriteLine(e.Message);
                }
            }
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(String.Format("Ingrese la cantidad de pasajeros para el taxi numero {0}", i));
                aux = Console.ReadLine();
                try
                {
                    transportes.Add(new Taxi(Int32.Parse(aux), i));
                }
                catch (FormatException e)
                {
                    i--;
                    Console.WriteLine(e.Message);
                }
            }
            Console.Clear();
            foreach (TransportePublico transporte in transportes)
            {
                Console.WriteLine(transporte.ToString());
            }        
        }
    }
}
