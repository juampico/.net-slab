using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLab.Net
{
    internal class Taxi : TransportePublico
    {
        public Taxi(int pasajeros, int id) : base(pasajeros)
        {
            this.id = id;
        }

        internal int id { get; set; }

        public override string ToString()
        {
            return String.Format("Taxi {0}: {1} pasajeros", this.id, pasajeros);
        }


    }
}
