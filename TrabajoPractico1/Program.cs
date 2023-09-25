namespace TrabajoPractico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion;

            // Crear una instancia de Parlamento
            Parlamento miParlamento = new Parlamento();

            // Agregar legisladores a miParlamento (puedes usar el método RegistrarLegislador)



            Senador senador = new Senador("Cabildo Abierto", "Defensa Nacional", 1, "Guido Manini", "Rìos", 65, true, 101);
            Diputado diputado = new Diputado("Partido B", "Departamento Y", 2, "Maria", "Gomez", 28, false, 201);

            senador.ParticiparDebate("Reforma de Pensiones");
            diputado.ParticiparDebate("Presupuesto Nacional");

            do
            {
                Console.Clear(); // Limpia la consola

                // Mostrar el encabezado del menú
                Console.WriteLine("\t         ADMINISTRACION          ");
                Console.WriteLine("\n\t*************************************");
                Console.WriteLine("\t*             MENU                  *");
                Console.WriteLine("\t*************************************");
                Console.WriteLine("\t* 1.    TOTAL LEGISLADORES          *");
                Console.WriteLine("\t* 2.        VOTOS                   *");
                Console.WriteLine("\t* 3.    PROPUESTAS LEGISLATIVA      *");
                Console.WriteLine("\t* 4.        CAMARA                  *");
                Console.WriteLine("\t* º.        SALIR                   *");
                Console.WriteLine("\t*************************************");
                Console.Write("\tSeleccione una opción: ");

                opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                    case '1':
                        Console.Clear();
                        // Luego, contar y mostrar la cantidad de senadores y diputados
                        miParlamento.ContarLegisladoresPorTipo();
                   
                        break;

                    case '2':
                        Console.Clear();
                        senador.Votar("Ley de Educación", Voto.Aprobado);
                        diputado.Votar("Reforma Fiscal", Voto.Rechazado);

                        break;

                    case '3':
                        Console.Clear();
                        senador.PresentarPropuestaLegislativa("Ley de Educación");
                        diputado.PresentarPropuestaLegislativa("Reforma Fiscal");
                        break;

                    case '4':
                        Console.Clear();
                        senador.getCamara();
                        diputado.getCamara();
                        break;

                    case 'º':
                        Console.WriteLine("\n\nGRACIAS POR USAR EL PROGRAMA! :D");
                        break;

                    default:
                        // Mostrar un mensaje de error si la opción no es válida
                        Console.WriteLine("\n\nOpción no válida. Introduce una opción válida entre 1 - 2.");
                        break;
                }

                Console.WriteLine("\nPulsa cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 'º');





        }
    }
}