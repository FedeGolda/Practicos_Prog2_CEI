using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    internal class Cliente
    {
        private string nombre;
        private string cedula;

        public Cliente(string nombre, string cedula)
        {
            this.nombre = nombre;
            this.cedula = cedula;
        }

        public string getNombre() => this.nombre;
        public string getCedula() => this.cedula;
        public void setNombre(string nombre) => this.nombre = nombre;
        public void setCedula(string cedula) => this.cedula = cedula;
    }
}
