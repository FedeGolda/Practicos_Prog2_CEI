using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej8
{
    internal class Humano
    {
        // Campos de clases o variables
        private string nombreIntegrante;

        public Humano()
        {
            this.nombreIntegrante = "nada";
        }
        public Humano(string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        // Getters y Setters
        public string getInfo()
        {
            return (nombreIntegrante);
        }
        public void setInfo(string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        // Metodos de la clase
        public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public void comer()
        {
            Console.WriteLine("Puedo comer");
        }
        public void hablar()
        {
            Console.WriteLine("Soy una persona");
        }
    }
}
