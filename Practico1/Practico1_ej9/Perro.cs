using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej9
{
    internal class Perro : Familia
    {
        // Campos de clases o variables
        private string apodo;

        // Constructor
        public Perro(string nombrePerro, string apodo) : base(nombrePerro) // base busca el segundo constructor de la clase padre
        {
            this.apodo = apodo;
        }

        // Getters y Setters
        public void setApodoPerro(string apodo)
        {
            this.apodo = apodo;
        }
        public string getApodoPerro()
        {
            return (this.apodo);
        }

        // Metodos de la clase
        public void ladrar()
        {
            Console.WriteLine("Gua");
        }

        public void infoPrueba()
        {
            Console.WriteLine("mi nombre es: " + nombreIntegrante);
            Console.WriteLine("mi nombre es: " + getInfo());
        }
    }
}
