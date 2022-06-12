﻿using Slab.Net.EF.Commons.Exceptions;
using Slab.Net.EF.Entities;
using Slab.Net.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.UI
{
    internal class CustomersUI
    {
        static CustomersLogic customersLogic = new CustomersLogic();

        public CustomersUI() {}

        internal void CustomerObject()
        {
            var queryMS = customersLogic.GetCustomerMS();
            var queryQS = customersLogic.GetCustomerQS();
            Console.WriteLine($"Objeto Customer obtenido usando Method Sintax: \n {queryMS}");
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine($"Objeto Customer obtenido usando Query Sintax: \n {queryQS}");
        }

        internal void ListCustomersByRegion(string region)
        {
            var queryMS = customersLogic.ListFromRegionMS(region);
            var queryQS = customersLogic.ListFromRegionQS(region);
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

        internal void ListLowerAndUpperCustomersName()
        {
            var queryMS = customersLogic.ListLowerAndUpperCaseNamesMS();
            var queryQS = customersLogic.ListLowerAndUpperCaseNamesQS();
            Console.WriteLine("Resultados obtenidos usando Method Sintax:");
            foreach (var item in queryMS)
            {
                Console.WriteLine($"\t Minuscula: {item.Lower} \t Mayuscula: {item.Upper}");
            }
            Console.WriteLine("-------------------------------------- \n");
            Console.WriteLine("Resultados obtenidos usando Query Sintax:");
            foreach (var item in queryQS)
            {
                Console.WriteLine($"\t Minuscula: {item.Lower} \t Mayuscula: {item.Upper}");
            }
        }

        internal void ListCustomersAndOrdersByRegionAndDateGreather(string region, DateTime date)
        {
            var queryMS = customersLogic.ListCustomerOrdersByRegionAndDateGreatherMS(region, date);
            var queryQS = customersLogic.ListCustomerOrdersByRegionAndDateGreatherQS(region, date);
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

        internal void FirstNCustomersByRegion(int n, string region)
        {
            var queryMS = customersLogic.GetTopNFromRegionMS(n, region);
            var queryQS = customersLogic.GetTopNFromRegionQS(n, region);
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


        internal void ListCustomersAndOrdersQuantity()
        {
            var queryMS = customersLogic.ListCustomerAndOrdersQuantityMS();
            var queryQS = customersLogic.ListCustomerAndOrdersQuantityMS();
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
