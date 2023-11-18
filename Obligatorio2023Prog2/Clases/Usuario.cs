using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }

        public Usuario(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }
        public string getNombre() { return nombre; }
        public string getContraseña() { return contraseña; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setContraseña(string contraseña) { this.contraseña = contraseña; }
    }
}