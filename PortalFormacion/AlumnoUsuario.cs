using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalFormacion
{
    internal class AlumnoUsuario : Usuario
    {
        protected string cursos;

        public AlumnoUsuario(int id, string nombre, string apellido) base : (id, nombre, apellido)
        {
            this.cursos = cursos;
        }

        public string getCursos()
        {
            return cursos;
        }

        public void setCursos(string cursos)
        {
            this.cursos = cursos;
        }

        public void Examina()
        {

        }

    }
}
