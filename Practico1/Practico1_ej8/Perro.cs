using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej8
{
    internal class Perro
    {
        // Campos de clases o variables
        private string nombreIntegrante;

        public Perro()
        {
            this.nombreIntegrante = "nada";
        }
        public Perro(string nombreIntegrante)
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
        public void setApodoPerro(string apodo)
        {
            this.apodo = apodo;
        }
        public string getApodoPerro()
        {
            return (this.apodo);
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
        public void ladrar()
        {
            Console.WriteLine("Gua");
        }
    }
}
