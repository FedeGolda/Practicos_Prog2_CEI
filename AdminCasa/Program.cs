using System;
using System.Collections.Generic;
using System.Linq;

namespace AdminCasa
{
    internal class Program
    {
        static void ClearConsole()
        {
            Console.Clear();

            if (Console.BufferHeight < Console.WindowHeight)
            {
                Console.BufferHeight = Console.WindowHeight;
            }
        }

        static void Main(string[] args)
        {
            char opcion;
            List<Casa> casas = new List<Casa>();

            do
            {
                Console.Clear();
                Console.WriteLine("\t         ADMINISTRACION CASAS        ");
                Console.WriteLine("\n\t*************************************");
                Console.WriteLine("\t*             MENU                  *");
                Console.WriteLine("\t*************************************");
                Console.WriteLine("\t* 1. AGREGAR BAÑO                   *");
                Console.WriteLine("\t* 2. AGREGAR DORMITORIO             *");
                Console.WriteLine("\t* 3. AGREGAR COCINA                 *");
                Console.WriteLine("\t* 4. VER DATOS GUARDADOS            *");
                Console.WriteLine("\t* 5. SALIR                          *");
                Console.WriteLine("\t*************************************");
                Console.Write("\tSeleccione una opción: ");

                // Leer la tecla del usuario
                opcion = Console.ReadKey().KeyChar;

                int numero;
                int metros;

                switch (opcion)
                {
                    case '1':
                        Console.WriteLine("\n\nIngrese cantidad de Baños: ");
                        if (!int.TryParse(Console.ReadLine(), out numero) || numero < 1)
                        {
                            Console.WriteLine("Debe ingresar un número válido mayor que cero.");
                            break;
                        }

                        Console.WriteLine("Introduce los metros cuadrados del baño:");
                        if (!int.TryParse(Console.ReadLine(), out metros) || metros < 1)
                        {
                            Console.WriteLine("Debe ingresar un número válido mayor que cero.");
                            break;
                        }

                        Console.WriteLine("¿Tiene ducha? (Sí/No):");
                        string tieneDucha = Console.ReadLine();

                        // Crear una nueva instancia de Casa
                        Casa nuevaCasa1 = new Casa(0, 0); // Puedes inicializar con valores predeterminados

                        // Agregar el baño a la casa
                        nuevaCasa1.AgregarBanio(tieneDucha, numero, metros);

                        // Agregar la casa a la lista de casas
                        casas.Add(nuevaCasa1);

                        Console.WriteLine("Baño agregado con éxito.");
                        break;

                    case '2':
                        Console.WriteLine("\n\nIntroduce el número de habitaciones del dormitorio:");
                        string cantidadHabitacionesInput = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(cantidadHabitacionesInput) || !int.TryParse(cantidadHabitacionesInput, out numero) || numero < 1)
                        {
                            Console.WriteLine("Debe ingresar un número válido mayor que cero para las habitaciones del dormitorio.");
                            break;
                        }

                        Console.WriteLine("Introduce los metros cuadrados del dormitorio:");
                        string metrosDormitorioInput = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(metrosDormitorioInput) || !int.TryParse(metrosDormitorioInput, out metros) || metros < 1)
                        {
                            Console.WriteLine("Debe ingresar un número válido mayor que cero para los metros cuadrados del dormitorio.");
                            break;
                        }

                        Console.WriteLine("Introduce el número de camas en el dormitorio:");
                        if (!int.TryParse(Console.ReadLine(), out int numeroCamas) || numeroCamas < 0)
                        {
                            Console.WriteLine("Debe ingresar un número válido no negativo para el número de camas en el dormitorio.");
                            break;
                        }

                        // Crear una nueva instancia de Casa
                        Casa nuevaCasa2 = new Casa(numero, metros);

                        // Agregar el dormitorio a la casa
                        nuevaCasa2.AgregarDormitorio(numeroCamas, numero, metros);

                        // Agregar la casa a la lista de casas
                        casas.Add(nuevaCasa2);

                        Console.WriteLine("Dormitorio agregado con éxito.");
                        break;

                    case '3':
                        Console.WriteLine("\n\nIntroduce el número de habitaciones de la cocina:");
                        if (!int.TryParse(Console.ReadLine(), out numero) || numero < 1)
                        {
                            Console.WriteLine("Debe ingresar un número válido mayor que cero.");
                            break;
                        }

                        Console.WriteLine("Introduce los metros cuadrados de la cocina:");
                        if (!int.TryParse(Console.ReadLine(), out metros) || metros < 1)
                        {
                            Console.WriteLine("Debe ingresar un número válido mayor que cero.");
                            break;
                        }

                        Console.WriteLine("¿Tiene horno? (Sí/No):");
                        string tieneHorno = Console.ReadLine();

                        // Crear una nueva instancia de Casa
                        Casa nuevaCasa3 = new Casa(0, 0); // Puedes inicializar con valores predeterminados

                        // Agregar la cocina a la casa
                        nuevaCasa3.AgregarCocina(tieneHorno, numero, metros);

                        // Agregar la casa a la lista de casas
                        casas.Add(nuevaCasa3);

                        Console.WriteLine("Cocina agregada con éxito.");
                        break;

                    case '4':
                        Console.WriteLine("\n\nDatos Guardados:");
                        Console.WriteLine("**********************************************");

                        if (casas.Count == 0)
                        {
                            Console.WriteLine("*          No hay datos guardados.           *");
                        }
                        else
                        {
                            foreach (var casa in casas)
                            {
                                casa.Descripcion();
                            }
                        }

                        Console.WriteLine("\n**********************************************");
                        break;

                    case '5':
                        Console.WriteLine("\n\nGRACIAS POR USAR EL PROGRAMA! :D");
                        break;

                    default:
                        Console.WriteLine("\n\nOpción no válida. Introduce una opción válida entre 1 - 5.");
                        break;
                }
                Console.WriteLine("\nPulsa cualquier tecla para continuar...\n");
                Console.ReadKey();
            } while (opcion != '5');
        }
    }
}
