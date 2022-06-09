using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Commons.Exceptions
{
    public class AlreadyExistsException : Exception
    {

        public AlreadyExistsException(string table) : base($"Ya existe un {table} con ese ID")
        {

        }
    }
}
