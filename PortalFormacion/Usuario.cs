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
        protected DateTime fechaAlta;

        public Usuario(int id, string nombre, string apellido, DateTime fechaAlta)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaAlta = fechaAlta;
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

        public DateTime getFechaAlta()
        {
            return fechaAlta;
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

        public void setFechaAlta(DateTime fechaAlta)
        {
            this.fechaAlta = fechaAlta;
        }

        public void Login(string nombre, string apellido)
        {
            
        }

        public void Logout(string nombre, string apellido)
        {

        }

    }
}
