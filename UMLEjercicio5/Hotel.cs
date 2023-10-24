using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEjercicio5
{
    internal class Hotel
    {
        private string nombre;
        private string direccion;

        public Hotel()
        {

        }

        public Hotel(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public string getNombre() => this.nombre;
        public void setNombre(string nombre) => this.nombre = nombre;
        public string getDireccion() => this.direccion;
        public void setDireccion(string direccion) => this.direccion = direccion;

    }
}
