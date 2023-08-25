using System;

namespace Practico_ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitamos al usuario que ingrese un año
            Console.Write("Introduce un año: ");
            int anio = Int32.Parse(Console.ReadLine());

            // Comprobamos si el año es bisiesto utilizando una única expresión booleana
            bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);

            // Mostramos el resultado basado en el valor de esBisiesto
            if (esBisiesto)
            {
                Console.WriteLine($"\nEl año {anio} es bisiesto\n");
            }
            else
            {
                Console.WriteLine($"\nEl año {anio} no es bisiesto\n");
            }
        }
    }
}
