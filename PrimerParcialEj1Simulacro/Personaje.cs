using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialEj1Simulacro
{
    internal class Personaje    
    {
        private string nombrePersonaje;

        public Personaje(string nombre)
        {
            nombrePersonaje = nombre;
        }
        public void getNombre()
        {
            Console.WriteLine("El nombre es: " + nombrePersonaje);
        }
        public virtual void pensar()
        {
            Console.WriteLine("Pienso y siento");
        }
    }
}