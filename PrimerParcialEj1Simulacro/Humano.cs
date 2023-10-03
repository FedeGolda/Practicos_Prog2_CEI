using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialEj1Simulacro
{
    internal class Humano : Personaje
    {
        public Humano(string nombreHumano) : base(nombreHumano) { }
        public void pensar(string deseo)
        {
            Console.WriteLine($"Puedo pensar un deseo: {deseo}\n");
        }
        public override void pensar()
        {
            Console.WriteLine("Pienso luego existo");
        }
    }
}