using System;
using System.Collections.Generic;

namespace AdminCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            List<Casa> casas = new List<Casa>();

            do
            {
                Console.Clear();
                Console.WriteLine("         ADMINISTRACION CASAS        ");
                Console.WriteLine("\n*************************************");
                Console.WriteLine("*             MENU                  *");
                Console.WriteLine("*************************************");
                Console.WriteLine("* 1. AGREGAR BAÑO                   *");
                Console.WriteLine("* 2. AGREGAR DORMITORIO             *");
                Console.WriteLine("* 3. AGREGAR COCINA                 *");
                Console.WriteLine("* 4. VER DATOS GUARDADOS            *");
                Console.WriteLine("* 5. SALIR                          *");
                Console.WriteLine("*************************************");
                Console.Write("Seleccione una opción: ");

                // Leer la tecla del usuario
                opcion = Console.ReadKey().KeyChar;

                int numero;
                int metros;

                switch (opcion)
                {
                    case '1':
                        Console.WriteLine("\nIngrese cantidad de Baños: ");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce los metros cuadrados del baño:");
                        metros = int.Parse(Console.ReadLine());

                        Console.WriteLine("¿Tiene ducha? (Sí/No):");
                        bool tieneDucha = Console.ReadLine().ToLower() == "sí";

                        Banio banio = new Banio(tieneDucha, numero, metros);
                        casas.Add(banio);
                        Console.WriteLine("Baño agregado con éxito.");
                        break;

                    case '2':
                        Console.WriteLine("\nIntroduce el número de habitaciones del dormitorio:");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce los metros cuadrados del dormitorio:");
                        metros = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce el número de camas en el dormitorio:");
                        int numeroCamas = int.Parse(Console.ReadLine());

                        Dormitorio dormitorio = new Dormitorio(numeroCamas, numero, metros);
                        casas.Add(dormitorio);
                        Console.WriteLine("Dormitorio agregado con éxito.");
                        break;

                    case '3':
                        Console.WriteLine("\nIntroduce el número de habitaciones de la cocina:");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce los metros cuadrados de la cocina:");
                        metros = int.Parse(Console.ReadLine());

                        Console.WriteLine("¿Tiene horno? (Sí/No):");
                        bool tieneHorno = Console.ReadLine().ToLower() == "sí";

                        Cocina cocina = new Cocina(tieneHorno, numero, metros);
                        casas.Add(cocina);
                        Console.WriteLine("Cocina agregada con éxito.");
                        break;

                    case '4':
                        Console.WriteLine("\nDatos Guardados:");
                        if (casas.Count == 0)
                        {
                            Console.WriteLine("No hay datos guardados.");
                        }
                        else
                        {
                            foreach (var casa in casas)
                            {
                                casa.Descripcion();
                                Console.WriteLine();
                            }
                        }
                        break;

                    case '5':
                        Console.WriteLine("\nCERRANDO PROGRAMA.....\n");
                        Console.WriteLine("\nGRACIAS POR USAR EL PROGRAMA :D");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Introduce una opción válida entre 1 - 5.");
                        break;
                }

            } while (opcion != '5');
        }
    }
}
