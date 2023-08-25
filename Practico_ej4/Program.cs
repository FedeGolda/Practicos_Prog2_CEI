using System;

namespace Practico_ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Solicitar el nombre del alumno (o salir si se ingresa una cadena vacía)
                Console.Write("Ingrese el nombre del alumno (o presione Enter para salir): ");
                string nombre = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    break; // Salir del bucle si se ingresa una cadena vacía
                }

                double notaPractica, notaProblemas, notaTeorica;

                // Solicitar y validar la nota práctica
                Console.Write("Ingrese la nota práctica: ");
                if (!double.TryParse(Console.ReadLine(), out notaPractica) || notaPractica < 0 || notaPractica > 10)
                {
                    Console.WriteLine("Nota inválida. Ingrese una nota entre 0 y 10.\n");
                    continue; // Volver a pedir datos del alumno
                }

                // Solicitar y validar la nota de problemas
                Console.Write("Ingrese la nota de problemas: ");
                if (!double.TryParse(Console.ReadLine(), out notaProblemas) || notaProblemas < 0 || notaProblemas > 10)
                {
                    Console.WriteLine("Nota inválida. Ingrese una nota entre 0 y 10.\n");
                    continue; // Volver a pedir datos del alumno
                }

                // Solicitar y validar la nota teórica
                Console.Write("Ingrese la nota teórica: ");
                if (!double.TryParse(Console.ReadLine(), out notaTeorica) || notaTeorica < 0 || notaTeorica > 10)
                {
                    Console.WriteLine("Nota inválida. Ingrese una nota entre 0 y 10.\n");
                    continue; // Volver a pedir datos del alumno
                }

                // Calcular la nota final según los porcentajes dados
                double notaFinal = (notaPractica * 0.1) + (notaProblemas * 0.5) + (notaTeorica * 0.4);

                // Mostrar la nota final del alumno con dos decimales
                Console.WriteLine($"El alumno {nombre} tiene una nota final de {notaFinal:F2}\n");
            }

            Console.WriteLine("¡Hasta luego!");
        }
    }
}