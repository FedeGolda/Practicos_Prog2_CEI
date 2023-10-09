using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Perro : Mamifero, Imprimir // Primero la herencia y luego las interfaces
    {
        public Perro(string nombre) : base(nombre) 
        {
            
        }

        public void correr()
        {
            Console.WriteLine("Puedo correr");
        }

        // Debo implementar los metodos de la Interface
        public void imprimirAnimal()
        {
            Console.WriteLine("Yo soy un perro");
        }
        
        public void imprimirFigura()
        {
            Console.WriteLine("\n   ,---,\n   | 6 6 | \n ");
        }

    }
}
