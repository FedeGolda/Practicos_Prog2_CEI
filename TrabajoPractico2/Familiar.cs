using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Familiar : Vehiculo
    {
        private int capacidadMaletero;

        public Familiar(int capacidadMaletero) : base()
        {
            this.capacidadMaletero = capacidadMaletero;
        }
    }
}
