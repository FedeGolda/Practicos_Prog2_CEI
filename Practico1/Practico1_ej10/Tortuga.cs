using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej10
{
    internal class Tortuga : Personaje
    {
        public Tortuga(string nombreTortuga) : base(nombreTortuga)
        {
            // NO HAY CODIGO
        }
        public void dormir()
        {
            Console.WriteLine("Puedo dormir mucho tiempo");
        }
        public override void pensar() // POLIMORFISMO
        {
            // override ---> es una modificacion del metodo public virtual void pensar()
            Console.WriteLine("Puedo pensar mas que los humanos");
        }
    }
}
