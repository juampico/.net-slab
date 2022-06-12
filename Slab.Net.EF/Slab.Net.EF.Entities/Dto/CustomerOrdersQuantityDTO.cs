using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Entities.Dto
{
    public class CustomerOrdersQuantityDTO
    {
        public Customers Customer { get; set; }

        public int OrdersQuantity { get; set; }

        public override string ToString()
        {
            return $"{Customer} \t Cantidad de Ordenes: {OrdersQuantity}";
        }
    }
}
