using Slab.Net.EF.Commons.Exceptions;
using Slab.Net.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Logic
{
    public class ShippersLogic : BaseLogic<Shippers, int>
    {

        public override List<Shippers> GetAll() => _context.Shippers.ToList();
        public override Shippers Get(int id)
        {
            Shippers item = _context.Shippers.Find(id);
            if (item == null)
                throw new NullReferenceException();
            return item;
        }


        public override int Add(Shippers newItem)
        {
            if (newItem.CompanyName.Length > 40)
                throw new MaxLengthExceededException("CompanyName", 40);
            if (newItem.Phone != null && newItem.Phone.Length > 24)
                throw new MaxLengthExceededException("Phone", 24);
            _context.Shippers.Add(newItem);
            _context.SaveChanges();
            return newItem.ShipperID;
        }

        public override void Remove(int toRemoveId)
        {
            Shippers toRemove = _context.Shippers.Find(toRemoveId);
            if (toRemove != null)
            {
                _context.Shippers.Remove(toRemove);
                _context.SaveChanges();
            }
            else
                throw new NullReferenceException();
        }

        public override void Update(Shippers toUpdate)
        {
            Shippers shipperToUpdate = _context.Shippers.Find(toUpdate.ShipperID);
            if (shipperToUpdate == null)
                throw new NullReferenceException();
            if (toUpdate.CompanyName.Length > 40)
                throw new MaxLengthExceededException("CompanyName", 40);
            if (toUpdate.Phone != null && toUpdate.Phone.Length > 24)
                throw new MaxLengthExceededException("Phone", 24);
            shipperToUpdate.Orders = toUpdate.Orders;
            shipperToUpdate.Phone = toUpdate.Phone;
            shipperToUpdate.CompanyName = toUpdate.CompanyName;
            _context.SaveChanges();
        }

    }
}
