using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa
{
    internal class Comedor : Casa
    {
        // Atributo adicional para el comedor
        private string horno;

        // Constructor
        public Comedor(double ancho, double largo, double alto, string color, string horno) : base(ancho, largo, alto, color)
        {
            this.horno = horno;
        }

        // Método para obtener la capacidad del comedor
        public string getHorno()
        {
            return this.horno;
        }
    }
}
