using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialEj2Simulacro
{
    internal class Perro : Animal
    {
        public Perro(string nombre, string color) : base(nombre, color) { }

        public override void VozAnimal()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public void Correr()
        {
            Console.WriteLine("El perro está corriendo.");
        }
    }
}
