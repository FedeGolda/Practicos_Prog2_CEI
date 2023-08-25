using System; // Biblioteca básica de C# para entrada/salida y manipulación de datos
using System.Threading; // Biblioteca para gestionar hilos y realizar pausas

namespace Practico_ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas = 0, minutos = 0, segundos = 0;

            while (true)
            {
                // Limpiar la consola para actualizar la visualización del reloj
                Console.Clear();

                // Imprimir el tiempo en formato HH:MM:SS con ceros a la izquierda si es necesario
                Console.WriteLine($"{horas:D2}:{minutos:D2}:{segundos:D2}");

                // Incrementar los segundos
                segundos++;

                // Si llegamos a 60 segundos, incrementar minutos y reiniciar los segundos
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;

                    // Si llegamos a 60 minutos, incrementar horas y reiniciar los minutos
                    if (minutos == 60)
                    {
                        minutos = 0;
                        horas++;

                        // Si llegamos a 24 horas, reiniciar las horas
                        if (horas == 24)
                        {
                            horas = 0;
                        }
                    }
                }

                // Esperar 1 segundo antes de la siguiente actualización
                Thread.Sleep(1000);
            }
        }
    }
}
