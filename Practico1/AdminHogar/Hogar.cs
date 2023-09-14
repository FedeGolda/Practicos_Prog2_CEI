using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminHogar
{
    internal class Hogar
    {
        protected string nombreIntegrante;

        public Hogar(string nombre)
        {
            nombreIntegrante = nombre;
        }

        public void GetNombre()
        {
            Console.WriteLine("El nombre del integrante: " + nombreIntegrante);
        }

        // Método virtual que puede ser sobrescrito por clases derivadas (polimorfismo).
        public virtual void Presentarse()
        {
            Console.WriteLine("Soy un miembro del hogar");
        }
    }
}
