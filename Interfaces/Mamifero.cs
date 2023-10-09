using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Mamifero : Animales
    {
        public Mamifero(string nombre) : base(nombre) 
        {
            
        }

        public void informacion()
        {
            Console.WriteLine("Los mamiferos poseen glàndulas mamarias productoras de leche con las que alimentan a las crìas");
        }
    }
}
