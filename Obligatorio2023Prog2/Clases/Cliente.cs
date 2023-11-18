using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }

        public Cliente(int id, string nombre, string apellido, string cedula)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
        }

        public int getId() { return id; }
        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public string getCedula() { return cedula; }
        public void setId(int id) { this.id = id; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setApellido(string apellido) { this.apellido = apellido; }
        public void setCedula(string cedula) { this.cedula = cedula; }
    }
}