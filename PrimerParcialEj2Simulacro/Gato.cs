using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialEj2Simulacro
{
    internal class Gato : Animal
    {
        public Gato(string nombre, string color) : base(nombre, color) { }

        public override void VozAnimal()
        {
            Console.WriteLine("Meow!");
        }

        public void Correr()
        {
            Console.WriteLine("El gato está corriendo.");
        }
    }
}
