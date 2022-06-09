using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Commons.Exceptions
{
    public class MaxLengthExceededException : Exception
    {

        public MaxLengthExceededException(string field, int maxLength) : base($"Largo maximo del campo {field} excedido({maxLength})") 
        {
        }
    }
}
