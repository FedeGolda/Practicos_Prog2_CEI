using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalFormacion
{
    internal class Usuario
    {
        // Definir una lista de AlumnoUsuario
        private List<AlumnoUsuario> listaAlumnos = new List<AlumnoUsuario>();

        protected int id;
        protected string nombre;
        protected string apellido;

        public Usuario(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int getId() 
        {
            return id;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellido()
        {
            return apellido;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }


        public void Login(string nombre, string apellido)
        {
            
        }

        public void Logout(string nombre, string apellido)
        {

        }

    }
}
