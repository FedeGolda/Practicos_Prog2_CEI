using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminHogar
{
    internal class Hijo : Hogar
    {
        public Hijo(string nombreHijo) : base(nombreHijo)
        {
            // Constructor de la clase Hijo
        }

        // Nuevo método específico para la clase Hijo.
        public void Hablar(string habla)
        {
            Console.WriteLine("Soy un hijo y digo: " + habla);
        }

        // Sobrescribir el método Presentarse de la clase base (polimorfismo).
        public override void Presentarse()
        {
            Console.WriteLine("Soy un hijo y me presento");
        }
    }
}
