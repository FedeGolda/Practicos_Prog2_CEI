using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialEj1Simulacro
{
    internal class Tortuga : Personaje
    {
        public Tortuga(string nombreGorila) : base(nombreGorila) { }
        public void mensaje()
        {
            Console.WriteLine("El mundo de fantasia muere porque las personas ya no creen en sus sueños\n");
        }
        public override void pensar()
        {
            Console.WriteLine("Ya no mates inocentes");
        }

    }
}