using Slab.Net.EF.Commons.Exceptions;
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

        public void ListShippers()
        {
            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"Cliente {customer.CustomerID} | Nombre: {customer.ContactName} | Pais: {customer.Country}");
            }
        }


        public void PrintCustomer(string id)
        {
            Customers customer = null;
            try
            {
                customer = customersLogic.Get(id);
            }
            catch (NullReferenceException)
            {
                Console.Write($"No existe un cliente con ID: {id}");
            }
            Console.WriteLine($"Cliente {customer.CustomerID} | Nombre: {customer.ContactName} | Pais: {customer.Country}");
        }

        public void AddCustomer()
        {
            Console.WriteLine("Ingrese el id del cliente (Max. 5 caracteres) a agregar");
            string id = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del cliente (Max. 40 caracteres) a agregar");
            string name = Console.ReadLine();
            try
            {
                customersLogic.Add(new Customers
                {
                    CustomerID = id,
                    CompanyName = name

                });
            }
            catch (MaxLengthExceededException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (AlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveCustomer(string id)
        {
            try
            {
                customersLogic.Remove(id);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"No existe un cliente con ID: {id}");
            }
        }
    }
}
