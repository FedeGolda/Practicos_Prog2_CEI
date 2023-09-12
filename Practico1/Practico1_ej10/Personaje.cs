using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej10
{
    internal class Personaje
    {
        // atributo
        protected string nombrePersonaje;

        public Personaje(string nombre)
        {
            nombrePersonaje = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void getNombre()
        {
            Console.WriteLine("El nombre es: " + nombrePersonaje);
        }
        public virtual void pensar() // POLIMORFISMO
        {
            Console.WriteLine("Puedo pensar instintivamente");
        }
    }
}
