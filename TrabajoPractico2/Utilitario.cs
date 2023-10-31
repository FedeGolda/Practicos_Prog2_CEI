using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Utilitario : Vehiculo
    {
        private int capacidadCarga;

        public Utilitario(int capacidadCarga) : base()
        {
            this.capacidadCarga = capacidadCarga;
        }
    }
}
