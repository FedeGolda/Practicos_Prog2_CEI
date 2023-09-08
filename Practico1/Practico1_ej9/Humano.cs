using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej9
{
    internal class Humano : Familia
    {
        // Constructor
        public Humano(string nombreHumano):base(nombreHumano) // base busca el segundo contructor de la clase Padre
        {
            // NO HAY CODIGO       
        }

        // Metodos de la clase
        public void hablar()
        {
            Console.WriteLine("Soy una persona");
        }
    }
}
