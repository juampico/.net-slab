using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLab.Net
{
    internal abstract class TransportePublico
    {
        protected int pasajeros { get; set; }

        public TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public string avanzar()
        {
            return string.Format("Avanzando con {0} pasajeros", this.pasajeros);
        }
    }
}
