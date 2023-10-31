using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Deportivo : Vehiculo
    {
        private int velocidadMax;

        public Deportivo(int velocidadMax) : base()
        {
            this.velocidadMax = velocidadMax;
        }
    }
}
