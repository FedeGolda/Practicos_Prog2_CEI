using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej9
{
    internal class Familia
    {
        // Campos de clases o variables
        protected string nombreIntegrante;

        // Constructores
        public Familia()
        {
            this.nombreIntegrante = "nada";
        }
        public Familia(string nombreIntegrante)
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
    }
}
