using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLab.Net
{
    internal class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros, int id) : base(pasajeros)
        {
            this.id = id;
        }

        private int id { get; set; }

        public override string ToString()
        {
            return String.Format("Omnibus {0}: {1} pasajeros", this.id, pasajeros);
        }
    }
}
