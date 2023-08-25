using System;

namespace Practico_ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            // Validamos n
            do
            {

                Console.Write("Escribe un valor para n: ");

                // Intenta leer la entrada del usuario y analizarla como un entero.
                // Si el análisis es exitoso y el valor es un entero, se almacena en "n".
                // Si no es exitoso o "n" no es un número entero, el bucle continúa solicitando entrada.

            } while (!Int32.TryParse(Console.ReadLine(), out n) || n < 1);

            int resultado = 0;

            for (int i = 1; i <= n; i++)
            {
                // Calculamos el resultado
                resultado = i * i;

                // Mostramos el resultado
                Console.WriteLine($"\nEl valor al cuadrado de {i} es {resultado}");
            }
        }
    }
}