using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej10
{
    internal class Caballo : Personaje
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo) 
        {
            // NO HAY CODIGO
        }
        public void galopar()
        {
            Console.WriteLine("Puedo galopar");
        }
    }
}
