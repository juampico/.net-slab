using Slab.Net.EF.Commons.Exceptions;
using Slab.Net.EF.Entities;
using Slab.Net.EF.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
       
        public override List<Customers> GetAll() => db.Customers.ToList();
        public override Customers Get(string id) => db.Customers.Find(id);

       
        public override string Add(Customers newItem)
        {
            if (newItem.CustomerID.Length > 5)
                throw new MaxLengthExceededException("CustomerID",5);
            if (newItem.CompanyName.Length > 40)
                throw new MaxLengthExceededException("CompanyName", 40);
            if (db.Customers.Find(newItem.CustomerID) != null)
                throw new AlreadyExistsException("Cliente");
            db.Customers.Add(newItem);
            db.SaveChanges();
            return newItem.CustomerID;
        }

        public override void Remove(string toRemoveId)
        {
            Customers toRemove = db.Customers.Find(toRemoveId);
            if (toRemove == null)
                throw new NullReferenceException();
            db.Customers.Remove(toRemove);
            db.SaveChanges();
        }

        public override void Update(Customers toUpdate)
        {
            Customers customer = db.Customers.Find(toUpdate.CustomerID);
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
            db.SaveChanges();
        }

        //1. Query para devolver objeto customer
        public Customers GetCustomerMS()
        {
           return db.Customers.FirstOrDefault();
        }

        public Customers GetCustomerQS()
        {
            return (from customer in db.Customers
                    select customer).FirstOrDefault();
        }

        //4. Query para devolver todos los customers de la Región WA(Parametrizado para que sea de cualquier region)
        public IQueryable<Customers> ListFromRegionMS(string region)
        {
            return db.Customers.Where(c => c.Region == region);
        }

        public IQueryable<Customers> ListFromRegionQS(string region)
        {
            return from customer in db.Customers
                   where customer.Region == region
                   select customer;
        }

        //6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.
        public IQueryable<LowerUpperCaseDTO> ListLowerAndUpperCaseNamesMS()
        {
            return db.Customers.Select(c => new LowerUpperCaseDTO
            {
                Lower = c.CompanyName.ToLower(),
                Upper = c.CompanyName.ToUpper()
            });

        }

        public IQueryable<LowerUpperCaseDTO> ListLowerAndUpperCaseNamesQS()
        {
            return from customer in db.Customers
                   select new LowerUpperCaseDTO()
                   {
                        Lower = customer.CompanyName.ToLower(),
                        Upper = customer.CompanyName.ToUpper()
                   };
            
        }

        //7. Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997. (Parametrizado)
        public IQueryable<CustomerOrderDTO> ListCustomerOrdersByRegionAndDateGreatherMS(string region, DateTime date)
        {
            return db.Customers.Where(c => c.Region == region).Join(db.Orders.Where(o => o.OrderDate > date),
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new CustomerOrderDTO
                {
                    Customer = c,
                    Order = o
                });
        }
        public IQueryable<CustomerOrderDTO> ListCustomerOrdersByRegionAndDateGreatherQS(string region, DateTime date)
        {
            return from customer in db.Customers
                   join order in db.Orders
                   on customer.CustomerID equals order.CustomerID
                   where order.OrderDate > date
                   where customer.Region == region
                   select new CustomerOrderDTO
                   {
                       Customer = customer,
                       Order = order
                   };
        }

        //8. Query para devolver los primeros 3 Customers de la  Región WA(Parametrizado)
        public IQueryable<Customers> GetTopNFromRegionMS(int n, string region)
        {
            return db.Customers.Where(c => c.Region == region).Take(n);
        }

        public IQueryable<Customers> GetTopNFromRegionQS(int n, string region)
        {
            return (from customer in db.Customers
                   where customer.Region == region
                   select customer).Take(n);

        }

        //13. Query para devolver los customer con la cantidad de ordenes asociadas
        public IQueryable<CustomerOrdersQuantityDTO> ListCustomerAndOrdersQuantityMS()
        {
            return db.Customers.Join(db.Orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new CustomerOrderDTO
                {
                    Customer = c,
                    Order = o
                })
                .GroupBy(c => c.Customer.CustomerID)
                .Select( group => new CustomerOrdersQuantityDTO
                {
                       Customer = group.Select( g => g.Customer).FirstOrDefault(),
                       OrdersQuantity = group.Count()
                }
                );
        }

        public IQueryable<CustomerOrdersQuantityDTO> ListCustomerAndOrdersQuantityQS()
        {
            return (from customer in db.Customers
                         join order in db.Orders
                         on customer.CustomerID equals order.CustomerID
                         group customer by customer.CustomerID into c
                         select new CustomerOrdersQuantityDTO
                         {
                             Customer = c.FirstOrDefault(),
                             OrdersQuantity = c.Count()
                         });
        }
    }
}
