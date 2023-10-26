using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    internal class Usuario
    {
        private string nombre;
        private string cedula;
        private List<string> permisos;
        
        public Usuario(string nombre, string cedula, List<string> permisos)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.permisos = permisos;
        }

        public string getNombre() => this.nombre;
        public void setNombre(string nombre) => this.nombre = nombre;
        public string getCedula() => this.cedula;
        public void setCedula(string cedula) => this.cedula = cedula;
        public List<string> getPermisos() => this.permisos;
        public void setPermisos(List<string> permisos) => this.permisos = permisos;

    }
}
