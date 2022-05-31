using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLab.Net.Exceptions
{
    public class NotChuckNorrisException : Exception
    {
        public NotChuckNorrisException() : base ("Si fueras Chuck Norris no tiraria esta excepcion")
        {

        }

    }
}
