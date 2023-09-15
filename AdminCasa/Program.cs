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
                Console.Clear(); // Limpiar la pantalla en cada iteración del bucle
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

                switch (opcion)
                {
                    case '1':
                        AgregarBaño(casas); // Polimorfismo: Llamada al método AgregarBaño con parámetro de tipo List<Casa>
                        break;
                    case '2':
                        AgregarDormitorio(casas); // Polimorfismo: Llamada al método AgregarDormitorio con parámetro de tipo List<Casa>
                        break;
                    case '3':
                        AgregarCocina(casas); // Polimorfismo: Llamada al método AgregarCocina con parámetro de tipo List<Casa>
                        break;
                    case '4':
                        VerDatosGuardados(casas); // Polimorfismo: Llamada al método VerDatosGuardados con parámetro de tipo List<Casa>
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

        static void AgregarBaño(List<Casa> casas)
        {
            Console.WriteLine("\nIntroduce el número de habitaciones del baño:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce los metros cuadrados del baño:");
            int metros = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Tiene ducha? (Sí/No):");
            bool tieneDucha = Console.ReadLine().Equals("Sí", StringComparison.OrdinalIgnoreCase);

            Banio banio = new Banio(tieneDucha, numero, metros);
            casas.Add(banio);
            Console.WriteLine("Baño agregado con éxito.");
        }

        static void AgregarDormitorio(List<Casa> casas)
        {
            Console.WriteLine("\nIntroduce el número de habitaciones del dormitorio:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce los metros cuadrados del dormitorio:");
            int metros = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el número de camas en el dormitorio:");
            int numeroCamas = int.Parse(Console.ReadLine());

            Dormitorio dormitorio = new Dormitorio(numeroCamas, numero, metros);
            casas.Add(dormitorio);
            Console.WriteLine("Dormitorio agregado con éxito.");
        }

        static void AgregarCocina(List<Casa> casas)
        {
            Console.WriteLine("\nIntroduce el número de habitaciones de la cocina:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce los metros cuadrados de la cocina:");
            int metros = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Tiene horno? (Sí/No):");
            bool tieneHorno = Console.ReadLine().Equals("Sí", StringComparison.OrdinalIgnoreCase);

            Cocina cocina = new Cocina(tieneHorno, numero, metros);
            casas.Add(cocina);
            Console.WriteLine("Cocina agregada con éxito.");
        }



        static void VerDatosGuardados(List<Casa> casas)
        {
            if (casas.Count == 0)
            {
                Console.WriteLine("No hay datos guardados.");
                return;
            }

            Console.WriteLine("\nDatos Guardados:");
            foreach (var casa in casas)
            {
                casa.Descripcion(); // Polimorfismo: Llamada al método Descripcion en una instancia de clase derivada (Baño, Dormitorio, Cocina)
                Console.WriteLine();
            }
        }

    }
}
