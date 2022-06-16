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
    internal class ShippersUI
    {
        static ShippersLogic shippersLogic = new ShippersLogic();
        public ShippersUI() { }
        public void ListShippers()
        {
            foreach (Shippers shipper in shippersLogic.GetAll())
            {
                Console.WriteLine($"Transportista {shipper.ShipperID} | Nombre: {shipper.CompanyName} | Telefono: {shipper.Phone}");
            }

        }

        public void PrintShipper(int id)
        {
            Shippers shipper = null;
            try
            {
                shipper = shippersLogic.Get(id);
                Console.WriteLine($"Transportista {shipper.ShipperID} | Nombre: {shipper.CompanyName} | Telefono: {shipper.Phone}");
            }
            catch (NullReferenceException)
            {
                Console.Write($"No existe un transportista con ID: {id}");
            }

        }

        public void AddShipper()
        {
            Console.WriteLine("Ingrese el nombre del transportista (Max. 40 caracteres) a agregar");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del transportista (Max. 24 caracteres) a agregar");
            string phone = Console.ReadLine();
            try
            {
                shippersLogic.Add(new Shippers
                {
                    CompanyName = name,
                    Phone = phone
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
        public void RemoveShipper(int id)
        {
            try
            {
                shippersLogic.Remove(id);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"No existe un transportista con ID: {id}");
            }
        }

        public void UpdateShipper(int id)
        {
            Console.WriteLine("Ingrese el nuevo nombre del transportista (Max. 40 caracteres)");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo telefono del transportista (Max. 24 caracteres)");
            string phone = Console.ReadLine();
            Shippers toUpdate = new Shippers
            {
                ShipperID = id,
                CompanyName = name,
                Phone = phone
            };
            shippersLogic.Update(toUpdate);
        }
    }
}
