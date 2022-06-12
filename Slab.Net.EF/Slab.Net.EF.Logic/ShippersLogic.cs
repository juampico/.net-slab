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

        public override List<Shippers> GetAll() => db.Shippers.ToList();
        public override Shippers Get(int id)
        {
            Shippers item = db.Shippers.Find(id);
            if (item == null)
                throw new NullReferenceException();
            return item;
        }


        public override int Add(Shippers newItem)
        {
            if (newItem.CompanyName.Length > 40)
                throw new MaxLengthExceededException("CompanyName", 40);
            if (newItem.Phone.Length > 24)
                throw new MaxLengthExceededException("Phone", 24);
            db.Shippers.Add(newItem);
            db.SaveChanges();
            return newItem.ShipperID;
        }

        public override void Remove(int toRemoveId)
        {
            Shippers toRemove = db.Shippers.Find(toRemoveId);
            if (toRemove != null)
            {
                db.Shippers.Remove(toRemove);
                db.SaveChanges();
            }
            else
                throw new NullReferenceException();
        }

        public override void Update(Shippers toUpdate)
        {
            Shippers shipperToUpdate = db.Shippers.Find(toUpdate.ShipperID);
            if (shipperToUpdate == null)
                throw new NullReferenceException();
            if (toUpdate.CompanyName.Length > 40)
                throw new MaxLengthExceededException("CompanyName", 40);
            if (toUpdate.Phone.Length > 24)
                throw new MaxLengthExceededException("Phone", 24);
            shipperToUpdate.Orders = toUpdate.Orders;
            shipperToUpdate.Phone = toUpdate.Phone;
            shipperToUpdate.CompanyName = toUpdate.CompanyName;
            db.SaveChanges();
        }

    }
}
