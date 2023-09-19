using System;

namespace Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            // Crear instancias de las partes de la casa fuera del bucle
            Casa casa1 = new Casa(8, 10, 2.4, "blanco");
            Baño miBaño = new Baño();
            Dormitorio miDormitorio = new Dormitorio(2.9, 3.9, 2, "blanco", "King");
            Comedor miComedor = new Comedor(4, 6, 2.4, "rojo", "si");

            do
            {
                Console.Clear(); // Limpia la consola

                // Mostrar el encabezado del menú
                Console.WriteLine("\t         ADMINISTRACION CASAS        ");
                Console.WriteLine("\n\t*************************************");
                Console.WriteLine("\t*             MENU                  *");
                Console.WriteLine("\t*************************************");
                Console.WriteLine("\t* 1.        VER CASA                *");
                Console.WriteLine("\t* 2.        SALIR                   *");
                Console.WriteLine("\t*************************************");
                Console.Write("\tSeleccione una opción: ");

                opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                    case '1':
                        Console.Clear();
                        // Mostrar la información detallada de la casa
                        Console.WriteLine("\n******************************************");
                        Console.WriteLine("* CASA".PadRight(41) + "*");
                        Console.WriteLine("* Ancho: " + casa1.getAncho() + " m".PadRight(31) + "*");
                        Console.WriteLine("* Largo: " + casa1.getLargo() + " m".PadRight(30) + "*");
                        Console.WriteLine("* Alto: " + casa1.getAlto() + " m".PadRight(30) + "*");
                        Console.WriteLine("* Color: " + casa1.getColor().PadRight(32) + "*");
                        Console.WriteLine("*".PadRight(41) + "*");
                        Console.WriteLine("* BAÑO".PadRight(41) + "*");
                        Console.WriteLine("* Color: " + miBaño.getColor().PadRight(32) + "*");
                        Console.WriteLine("* Detalles:".PadRight(41) + "*");
                        miBaño.infoPintura();
                        miBaño.metrosPintura();
                        Console.WriteLine("*".PadRight(41) + "*");
                        Console.WriteLine("* DORMITORIO".PadRight(41) + "*");
                        Console.WriteLine("* Color: " + miDormitorio.getColor().PadRight(32) + "*");
                        Console.WriteLine("* Tipo Cama: " + miDormitorio.getCama().PadRight(28) + "*");
                        Console.WriteLine("* Techo: " + miDormitorio.metrosCuadradosTecho() + " m2".PadRight(27) + "*");
                        Console.WriteLine("* Pared: " + miDormitorio.metrosCuadradosPared() + " m2".PadRight(28) + "*");
                        Console.WriteLine("*".PadRight(41) + "*");
                        Console.WriteLine("* COMEDOR".PadRight(41) + "*");
                        Console.WriteLine("* Techo: " + miComedor.metrosCuadradosTecho() + " m2".PadRight(30) + "*");
                        Console.WriteLine("* Pared: " + miComedor.metrosCuadradosPared() + " m2".PadRight(30) + "*");
                        Console.WriteLine("* ¿Horno?: " + miComedor.getHorno().PadRight(30) + "*");
                        Console.WriteLine("* Color: " + miComedor.getColor().PadRight(32) + "*");
                        Console.WriteLine("******************************************");
                        break;

                    case '2':
                        // Mostrar un mensaje de despedida y salir del bucle
                        Console.WriteLine("\n\nGRACIAS POR USAR EL PROGRAMA! :D");
                        break;

                    default:
                        // Mostrar un mensaje de error si la opción no es válida
                        Console.WriteLine("\n\nOpción no válida. Introduce una opción válida entre 1 - 2.");
                        break;
                }

                Console.WriteLine("\nPulsa cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != '2');
        }
    }
}
