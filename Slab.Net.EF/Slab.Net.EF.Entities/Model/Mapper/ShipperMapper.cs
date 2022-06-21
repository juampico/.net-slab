using Slab.Net.EF.Entities.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Entities.Model.Mapper
{
    public class ShipperMapper
    {
        public ShipperDTO Map(Shippers c)
        {
            return new ShipperDTO
            {
                ShipperID = c.ShipperID,
                CompanyName = c.CompanyName,
                Phone = c.Phone
            };
        }

        public Shippers Map(ShipperDTO c)
        {
            return new Shippers
            {
                ShipperID = c.ShipperID,
                CompanyName = c.CompanyName,
                Phone = c.Phone
            };
        }
        public Shippers Map(ShipperRequestDTO c, int id)
        {
            return new Shippers
            {
                ShipperID = id,
                CompanyName = c.CompanyName,
                Phone = c.Phone
            };
        }

        public List<ShipperDTO> Map(List<Shippers> c)
        {
            List<ShipperDTO> list = new List<ShipperDTO>();
            foreach (var shipper in c)
            {
                list.Add(Map(shipper));
            }
            return list;
        }

    }
}
