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

                        // Crear una nueva instancia de Casa
                        Casa nuevaCasa1 = new Casa(0, 0); // Puedes inicializar con valores predeterminados
                        nuevaCasa1.AgregarBanio(tieneDucha, numero, metros);

                        // Agregar la casa a la lista de casas
                        casas.Add(nuevaCasa1);

                        Console.WriteLine("Baño agregado con éxito.");
                        break;


                    case '2':
                        Console.WriteLine("\nIntroduce el número de habitaciones del dormitorio:");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce los metros cuadrados del dormitorio:");
                        metros = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce el número de camas en el dormitorio:");
                        int numeroCamas = int.Parse(Console.ReadLine());

                        // Crear una nueva instancia de Casa
                        Casa nuevaCasa = new Casa(numero, metros);

                        // Agregar el dormitorio a la casa
                        nuevaCasa.AgregarDormitorio(numeroCamas, numero, metros);

                        // Agregar la casa a la lista de casas
                        casas.Add(nuevaCasa);

                        Console.WriteLine("Dormitorio agregado con éxito.");
                        break;


                    case '3':
                        Console.WriteLine("\nIntroduce el número de habitaciones de la cocina:");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduce los metros cuadrados de la cocina:");
                        metros = int.Parse(Console.ReadLine());

                        Console.WriteLine("¿Tiene horno? (Sí/No):");
                        bool tieneHorno = Console.ReadLine().ToLower() == "sí";

                        // Crear una nueva instancia de Casa
                        Casa nuevaCasa3 = new Casa(0, 0); // Puedes inicializar con valores predeterminados
                        nuevaCasa3.AgregarCocina(tieneHorno, numero, metros);

                        // Agregar la casa a la lista de casas
                        casas.Add(nuevaCasa3);

                        Console.WriteLine("Cocina agregada con éxito.");
                        break;


                    case '4':
                        Console.WriteLine("\nDatos Guardados:");
                        Console.WriteLine("\n**********************************************");
                        if (casas.Count == 0)
                        {
                            Console.WriteLine("*          No hay datos guardados.           *");
                        }
                        else
                        {
                            foreach (var casa in casas)
                            {
                                casa.Descripcion();
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine("**********************************************");
                        break;

                    case '5':
                        Console.WriteLine("\nCERRANDO PROGRAMA.....\n");
                        Console.WriteLine("\nGRACIAS POR USAR EL PROGRAMA :D");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Introduce una opción válida entre 1 - 5.");
                        break;
                }
                Console.WriteLine("\nPulsa cualquier tecla para continuar...\n");
                Console.ReadKey();

            } while (opcion != '5');
        }
    }
}