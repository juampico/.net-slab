using Slab.Net.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.UI
{
    internal class ProductsUI
    {
        static ProductsLogic productsLogic = new ProductsLogic();

        internal void ListProductsNonStock()
        {
            var queryMS = productsLogic.ListNonStockMS();
            var queryQS = productsLogic.ListNonStockQS();
            Console.WriteLine("Resultados obtenidos usando Method Sintax:");
            foreach (var item in queryMS)
            {
                Console.WriteLine($"\t {item}");
            }
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Resultados obtenidos usando Query Sintax:");
            foreach (var item in queryQS)
            {
                Console.WriteLine($"\t {item}");
            }
        }

        internal void ListProductsWithStockAndPricePerUnitGreather(int price)
        {
            var queryMS = productsLogic.ListWithStockAndUnitPriceGreatherMS(price);
            var queryQS = productsLogic.ListWithStockAndUnitPriceGreatherQS(price);
            Console.WriteLine("Resultados obtenidos usando Method Sintax:");
            foreach (var item in queryMS)
            {
                Console.WriteLine($"\t {item}");
            }
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Resultados obtenidos usando Query Sintax:");
            foreach (var item in queryQS)
            {
                Console.WriteLine($"\t {item}");
            }
        }

        internal void FirstProductsById(int id)
        {
            var queryMS = productsLogic.GetFirstProductByIdMS(id);
            var queryQS = productsLogic.GetFirstProductByIdQS(id);
            Console.WriteLine("Resultados obtenidos usando Method Sintax:");
            Console.WriteLine($"\t {queryMS}");
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Resultados obtenidos usando Query Sintax:");
            Console.WriteLine($"\t {queryQS}");
            
        }

        internal void ListProductsOrderByName()
        {
            var queryMS = productsLogic.ListOrderByNameMS();
            var queryQS = productsLogic.ListOrderByNameQS();
            Console.WriteLine("Resultados obtenidos usando Method Sintax:");
            foreach (var item in queryMS)
            {
                Console.WriteLine($"\t {item}");
            }
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Resultados obtenidos usando Query Sintax:");
            foreach (var item in queryQS)
            {
                Console.WriteLine($"\t {item}");
            }
        }

        internal void ListProductsOrderByUnitInStockDesc()
        {
            var queryMS = productsLogic.ListOrderByInStockMS();
            var queryQS = productsLogic.ListOrderByInStockQS();
            Console.WriteLine("Resultados obtenidos usando Method Sintax:");
            foreach (var item in queryMS)
            {
                Console.WriteLine($"\t {item}");
            }
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Resultados obtenidos usando Query Sintax:");
            foreach (var item in queryQS)
            {
                Console.WriteLine($"\t {item}");
            }
        }

        internal void FirstProduct()
        {
            var queryMS = productsLogic.GetFirstMS();
            var queryQS = productsLogic.GetFirstQS();
            Console.WriteLine("Resultados obtenidos usando Method Sintax:");
            Console.WriteLine($"\t {queryMS}");
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Resultados obtenidos usando Query Sintax:");
            Console.WriteLine($"\t {queryQS}");
        }

        internal void ListProductsCategories()
        {
            var queryMS = productsLogic.ListDistinctCategoriesMS();
            var queryQS = productsLogic.ListDistinctCategoriesQS();
            Console.WriteLine("Resultados obtenidos usando Method Sintax:");
            foreach (var item in queryMS)
            {
                Console.WriteLine($"\t {item}");
            }
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Resultados obtenidos usando Query Sintax:");
            foreach (var item in queryQS)
            {
                Console.WriteLine($"\t {item}");
            }
        }
    }
}
