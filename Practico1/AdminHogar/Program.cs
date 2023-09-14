using System;

namespace AdminHogar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Hijo.
            Hijo hijo = new Hijo("Juan");

            // Llamar al método Presentarse de Hijo (polimorfismo).
            hijo.Presentarse();

            // Llamar al método Hablar específico de Hijo.
            hijo.Hablar("¡Hola, soy el hijo!");

            // Crear una instancia de la clase Hogar.
            Hogar hogar = new Hogar("Familia");

            // Llamar al método Presentarse de Hogar (polimorfismo).
            hogar.Presentarse();

            // Llamar al método GetNombre de Hogar.
            hogar.GetNombre();

            // Evitar que la consola se cierre inmediatamente.
            Console.ReadLine();
        }
    }
}
