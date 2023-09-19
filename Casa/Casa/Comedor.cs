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
        private int capacidad;

        // Constructor
        public Comedor(double ancho, double largo, double alto, string color, double alquiler, int capacidad) : base(ancho, largo, alto, color, alquiler)
        {
            this.capacidad = capacidad;
        }

        // Método para obtener la capacidad del comedor
        public int getCapacidad()
        {
            return this.capacidad;
        }
    }
}
