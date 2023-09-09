using System;


namespace Practico_ej1
{
    namespace Condicional_switch
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int dia = 0;
                int mes = 0;
                int anio = 0;

                // Solicitar al usuario ingresar los valores de la fecha

                Console.WriteLine("Ingrese Dia: ");
                dia = Int32.Parse(Console.ReadLine()); // Convertir la entrada del usuario a un valor numérico

                Console.WriteLine("\nIngrese Mes: ");
                mes = Int32.Parse(Console.ReadLine()); // Convertir la entrada del usuario a un valor numérico

                Console.WriteLine("\nIngrese Año: ");
                anio = Int32.Parse(Console.ReadLine()); // Convertir la entrada del usuario a un valor numérico

                Console.Clear(); // Limpia la pantalla en la consola

                if ((dia >= 1 && dia <= 31) && (mes >= 1 && mes <= 12) && anio > 0) // Verificar si la fecha ingresada es válida
                {
                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine($"{dia} de Enero de {anio}");
                            break;

                        case 2:
                            Console.WriteLine($"{dia} de Febrero de {anio}");
                            break;

                        case 3:
                            Console.WriteLine($"{dia} de Marzo de {anio}");
                            break;

                        case 4:
                            Console.WriteLine($"{dia} de Abril de {anio}");
                            break;

                        case 5:
                            Console.WriteLine($"{dia} de Mayo de {anio}");
                            break;

                        case 6:
                            Console.WriteLine($"{dia} de Junio de {anio}");
                            break;

                        case 7:
                            Console.WriteLine($"{dia} de Julio de {anio}");
                            break;

                        case 8:
                            Console.WriteLine($"{dia} de Agosto de {anio}");
                            break;

                        case 9:
                            Console.WriteLine($"{dia} de Setiembre de {anio}");
                            break;

                        case 10:
                            Console.WriteLine($"{dia} de Octubre de {anio}");
                            break;

                        case 11:
                            Console.WriteLine($"{dia} de Noviembre de {anio}");
                            break;

                        case 12:
                            Console.WriteLine($"{dia} de Diciembre de {anio}");
                            break;

                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("ERROR: LA FECHA ESTA MAL...\t");
                }
            }
        }
    }
}
          