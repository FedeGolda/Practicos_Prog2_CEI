using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialEj1Simulacro
{
    internal class Perro : Personaje
    {
        public Perro(string nombrePerro) : base(nombrePerro) { }
        public override void pensar()
        {
            Console.WriteLine("Puedo pensar mas que los humanos");
        }
        public void mensaje()
        {
            Console.WriteLine("Siempre es bueno un poco de suerte\n");
        }
    }
}
