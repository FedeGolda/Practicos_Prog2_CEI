using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PortalFormacion
{
    internal class SupervisorUsuario : Usuario
    {
        protected int nroUsuario;
        protected int departa;

        public SupervisorUsuario(int id, string nombre, string apellido, DateTime fechaAlta) : base(id, nombre, apellido, fechaAlta)
        {
            this.fechaAlta = fechaAlta;
            this.nroUsuario = nroUsuario;
            this.departa = departa;
        }



        public int getNroUsuario()
        {
            return nroUsuario;
        }

        public int getDeparta()
        {
            return departa;
        }


        public void setNroUsuario(int nroUsuario)
        {
            this.nroUsuario = nroUsuario;
        }
        public void setDeparta(int departa)
        {
            this.departa = departa;
        }

        // Función para dar de alta a un alumno
        public void Alta(AlumnoUsuario alumno)
        {
            // Verificar si el alumno ya existe
            if (listaAlumnos.Exists(a => a.Nombre == alumno.Nombre))
            {
                Console.WriteLine($"El alumno {alumno.Nombre} ya está registrado.");
            }
            else
            {
                // Agregar el nuevo alumno a la lista
                listaAlumnos.Add(alumno);
                Console.WriteLine($"Alumno {alumno.Nombre} registrado con éxito.");
            }
        }

        // Función para dar de baja a un alumno
        public void Baja(AlumnoUsuario alumno)
        {
            // Buscar al alumno en la lista
            var alumnoEnLista = listaAlumnos.Find(a => a.Nombre == alumno.Nombre);

            if (alumnoEnLista != null)
            {
                // Dar de baja al alumno (desactivar)
                listaAlumnos.Remove(alumnoEnLista);
                Console.WriteLine($"Alumno {alumnoEnLista.Nombre} dado de baja.");
            }
            else
            {
                Console.WriteLine($"El alumno {alumno.Nombre} no está registrado.");
            }
        }

        // Función para mostrar la lista de alumnos
        public static void MostrarAlumnos()
        {
            Console.WriteLine("Lista de Alumnos:");
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine($"Nombre: {alumno.Nombre}, Edad: {alumno.Edad}, Activo: {alumno.Activo}");
            }
            Console.WriteLine();
        }
    }


}

