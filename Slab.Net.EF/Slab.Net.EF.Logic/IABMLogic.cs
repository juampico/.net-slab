using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Logic
{
    interface IABMLogic<T, I>
    {

        List<T> GetAll();

        T Get(I id);
        
        I Add(T newItem);

        void Remove(I toDeleteId);

        void Update(T toUpdate);

    }
}
