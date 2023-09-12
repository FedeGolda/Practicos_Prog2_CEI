using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej10
{
    internal class Humano : Personaje
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {
            // NO HAY CODIGO
        }
        public void pensar(string idea) // SOBRECARGA
        {
            Console.WriteLine("Puedo pensar sobre la idea: " + idea);
        }
        public override string pensar() 
        {
            /*
              override ---> es una modificacion del metodo public virtual void pensar()
               Este metodo ya existe en la clase Mamiferos (Padre). Recibe los mismos parametros
               y devuelve lo mismo
               Una instancia de la clase Humano, al llamar al metodo pensar(), usara el que esta
               declarado dentro de su propia clase y no en la clase padre
             */

            Console.WriteLine("Pienso luego existo");
        }
    }
}
