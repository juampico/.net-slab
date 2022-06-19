using Slab.Net.EF.Entities.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Entities.Model.Mapper
{
    public class CustomersMapper
    {

        public CustomerDTO Map(Customers c)
        {
            return new CustomerDTO
            {
                CustomerID = c.CustomerID,
                CompanyName = c.CompanyName,
                ContactName = c.ContactName,
                ContactTitle = c.ContactTitle,
                Address = c.Address,
                City = c.City,
                Region = c.Region,
                PostalCode = c.PostalCode,
                Country = c.Country,
                Phone = c.Phone,
                Fax = c.Fax
            };
        }

        public Customers Map(CustomerDTO c)
        {
            return new Customers
            {
                CustomerID = c.CustomerID,
                CompanyName = c.CompanyName,
                ContactName = c.ContactName,
                ContactTitle = c.ContactTitle,
                Address = c.Address,
                City = c.City,
                Region = c.Region,
                PostalCode = c.PostalCode,
                Country = c.Country,
                Phone = c.Phone,
                Fax = c.Fax
            };
        }

        public List<CustomerDTO> Map(List<Customers> c)
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            foreach (var customer in c)
            {
                list.Add(Map(customer));
            }
            return list;
        }


    }
}
