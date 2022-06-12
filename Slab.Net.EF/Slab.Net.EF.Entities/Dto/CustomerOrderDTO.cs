using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Entities.Dto
{
    public class CustomerOrderDTO
    {
        public Customers Customer { get; set; }   

        public Orders Order { get; set; }

        public override string ToString()
        {
            return $" {Customer} \t Order: {Order.OrderID} \t Fecha: {Order.OrderDate}";
        }
    }
}
