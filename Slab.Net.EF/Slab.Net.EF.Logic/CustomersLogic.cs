using Slab.Net.EF.Commons.Exceptions;
using Slab.Net.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Logic
{
    public class CustomersLogic : BaseLogic<Customers, string>
    {


        public override List<Customers> GetAll() => _context.Customers.ToList();
        public override Customers Get(string id) => _context.Customers.Find(id);

       
        public override string Add(Customers newItem)
        {
            if (newItem.CustomerID.Length > 5)
                throw new MaxLengthExceededException("CustomerID",5);
            if (newItem.CompanyName.Length > 40)
                throw new MaxLengthExceededException("CompanyName", 40);
            if (_context.Customers.Find(newItem.CustomerID) != null)
                throw new AlreadyExistsException("Cliente");
            _context.Customers.Add(newItem);
            _context.SaveChanges();
            return newItem.CustomerID;
        }

        public override void Remove(string toRemoveId)
        {
            Customers toRemove = _context.Customers.Find(toRemoveId);
            if (toRemove == null)
                throw new NullReferenceException();
            _context.Customers.Remove(toRemove);
            _context.SaveChanges();
        }

        public override void Update(Customers toUpdate)
        {
            Customers customer = _context.Customers.Find(toUpdate.CustomerID);
            if (customer == null)
                throw new NullReferenceException();
            //Deberia verificar todos los campos y sus restricciones pero no sera utilizado en el practico
            customer.CompanyName = toUpdate.CompanyName;
            customer.ContactName = toUpdate.ContactName;
            customer.ContactTitle = toUpdate.ContactTitle;
            customer.Address = toUpdate.Address;
            customer.City = toUpdate.City;
            customer.Region = toUpdate.Region;
            customer.PostalCode = toUpdate.PostalCode;
            customer.Country = toUpdate.Country;
            customer.Phone = toUpdate.Phone;
            customer.Fax = toUpdate.Fax;
            customer.Orders = toUpdate.Orders;
            customer.CustomerDemographics = toUpdate.CustomerDemographics;
            _context.SaveChanges();
        }


    }
}
