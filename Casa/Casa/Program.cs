using System;

namespace Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;

            do
            {
                Console.Clear();
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
                        Baño miBaño = new Baño();
                        Casa casa1 = new Casa(2, 2, 2, "blanco", 1000.0); // Ejemplo de crear una casa con un alquiler de $1000
                        Dormitorio miDormitorio = new Dormitorio(2, 2, 2, "blanco", 500, "King");

                        Comedor miComedor = new Comedor(3, 3, 3, "rojo", 200 ,10);

                        Console.WriteLine("\nCasa");
                        Console.WriteLine("Ancho: " + casa1.getAncho());
                        Console.WriteLine("Largo: " + casa1.getLargo());
                        Console.WriteLine("Alto: " + casa1.getAlto());
                        Console.WriteLine("Color: " + casa1.getColor());
                        Console.WriteLine("\nBaño");
                        Console.WriteLine("Color Baño: " + miBaño.getColor() + "");
                        miBaño.infoPintura();
                        miBaño.metrosPintura();
                        Console.WriteLine("\nDormitorio");
                        Console.WriteLine("Color Dormitorio: " + miDormitorio.getColor());
                        Console.WriteLine("Tipo Cama: " + miDormitorio.getCama());
                        Console.WriteLine("Techo: " + miDormitorio.metrosCuadradosTecho() + " m2");
                        Console.WriteLine("Pared: " + miDormitorio.metrosCuadradosPared() + " m2");
                        Console.WriteLine("\nComedor");
                        Console.WriteLine("Cantidad: " + miComedor.getCapacidad());
                        break;

                    case '2':
                        Console.WriteLine("\n\nGRACIAS POR USAR EL PROGRAMA! :D");
                        break;

                    default:
                        Console.WriteLine("\n\nOpción no válida. Introduce una opción válida entre 1 - 2.");
                        break;
                }

                Console.WriteLine("\nPulsa cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != '2');
        }
    }
}
