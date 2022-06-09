using Slab.Net.EF.Data;
using System.Collections.Generic;

namespace Slab.Net.EF.Logic
{

    
    public abstract class BaseLogic<T, I> : IABMLogic<T, I> 
    {
        protected readonly NorthwindContext _context;

        public BaseLogic()
        {
            _context = new NorthwindContext();
        }

        public abstract I Add(T newItem);


        public abstract T Get(I id);

        public abstract List<T> GetAll();

        public abstract void Remove(I toDeleteId);

        public abstract void Update(T toUpdate);
    }
}