using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej8
{
    internal class Gato
    {
        // Campos de clases o variables
        private string nombreIntegrante;

        // Constructores
        public Gato()
        {
            this.nombreIntegrante = "nada";
        }
        public Gato(String nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        // Getters y Setters
        public string getInfo()
        {
            return(nombreIntegrante);
        }
        public void setInfo(string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        // Metodo de la clase
        public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }
        public void comer()
        {
            Console.WriteLine("Puedo comer");
        }
        public void maullar ()
        {
            Console.WriteLine("Miau");
        }
    }
}
