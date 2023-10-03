using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialEj2Simulacro
{
    internal class Vibora : Animal
    {
        public Vibora(string nombre, string color) : base(nombre, color) { }

        public override void VozAnimal()
        {
            Console.WriteLine("Sssss!");
        }

        public void Reptar()
        {
            Console.WriteLine("La víbora está reptando.");
        }
    }
}
