using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Gato : Mamifero,Imprimir
    {
        public Gato(string nombre) : base(nombre)
        {

        }

        public void correr()
        {
            Console.WriteLine("Puedo correr");
        }

        // Debe implementar los metodos de la interface
        public void imprimirAnimal()
        {
            Console.WriteLine("Yo soy un gato");
        }

        public void imprimirFigura()
        {
            Console.WriteLine("\n aksjdas \n ()()() \n");
        }

    }
}
