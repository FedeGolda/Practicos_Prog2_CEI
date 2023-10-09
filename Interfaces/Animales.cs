using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Animales
    {
        private string nombre;

        public Animales(string nombre)
        {
            this.nombre = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public string getNombre()
        { 
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
