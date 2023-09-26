using System;

namespace TrabajoPractico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion;

            // Crear una instancia de Parlamento
            Parlamento miParlamento = new Parlamento();

            do
            {
                Console.Clear(); // Limpia la consola

                // Mostrar el encabezado del menú
                Console.WriteLine("\t         ADMINISTRACION          ");
                Console.WriteLine("\n\t*************************************");
                Console.WriteLine("\t*             MENU                  *");
                Console.WriteLine("\t*************************************");
                Console.WriteLine("\t* 1.    TOTAL LEGISLADORES          *");
                Console.WriteLine("\t* 2.    LISTAR CAMARA               *");
                Console.WriteLine("\t* 3.     AGREGAR VOTOS              *");
                Console.WriteLine("\t* 4.     TOTAL VOTOS                *");
                Console.WriteLine("\t* 5.    PROPUESTAS LEGISLATIVA      *");
                Console.WriteLine("\t* 6.    AGREGAR LEGISLADOR          *");
                Console.WriteLine("\t* 7.    BORRAR LEGISLADOR           *");
                Console.WriteLine("\t* º.        SALIR                   *");
                Console.WriteLine("\t*************************************");
                Console.Write("\tSeleccione una opción: ");

                opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                    case '1':
                        Console.Clear();
                        // Mostrar lista de legisladores para que el usuario seleccione uno
                        Console.WriteLine("Lista de Legisladores:");
                        int contador = 1;
                        foreach (var legislador in miParlamento.getLegisladores())
                        {
                            Console.WriteLine($"{contador}. {legislador.getNombre()} {legislador.getApellido()}");
                            contador++;
                        }
                        miParlamento.ContarLegisladoresPorTipo();
                        break;


                    case '2':
                        Console.Clear();
                        miParlamento.ListarCamaras();
                        break;


                    case '3':
                        Console.Clear();
                        // Contadores para contar votos
                        int aprobados = 0;
                        int rechazados = 0;
                        int abstencion = 0;

                        // Calcular el total de votos de Aprobados, Rechazados y Abstención
                        foreach (var legislador in miParlamento.getLegisladores())
                        {
                            foreach (var votoRegistrado in legislador.Votos)
                            {
                                if (votoRegistrado.Contains("Aprobado"))
                                {
                                    aprobados++;
                                }
                                else if (votoRegistrado.Contains("Rechazado"))
                                {
                                    rechazados++;
                                }
                                else if (votoRegistrado.Contains("Abstención"))
                                {
                                    abstencion++;
                                }
                            }
                        }

                        // Mostrar el total de votos
                        Console.WriteLine($"Total de Votos:");
                        Console.WriteLine($"Aprobados: {aprobados}");
                        Console.WriteLine($"Rechazados: {rechazados}");
                        Console.WriteLine($"Abstención: {abstencion}");
                        miParlamento.ContarLegisladoresPorTipo();
                        break;


                    case '4':
                        Console.Clear();
                        // Mostrar lista de legisladores para que el usuario seleccione uno
                        Console.WriteLine("Lista de Legisladores:");
                        int contadorPropuesta = 1;
                        foreach (var legislador in miParlamento.getLegisladores())
                        {
                            Console.WriteLine($"{contadorPropuesta}. {legislador.getNombre()} {legislador.getApellido()}");
                            contadorPropuesta++;
                        }

                        Console.Write("Seleccione el número del legislador al que desea presentar la propuesta: ");
                        if (int.TryParse(Console.ReadLine(), out int seleccionPropuesta))
                        {
                            if (seleccionPropuesta >= 1 && seleccionPropuesta <= miParlamento.getLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorSeleccionado = miParlamento.getLegisladores()[seleccionPropuesta - 1];

                                Console.Write("Propuesta: ");
                                string propuesta = Console.ReadLine();

                                // Llama al método PresentarPropuestaLegislativa en el legislador seleccionado
                                legisladorSeleccionado.PresentarPropuestaLegislativa(propuesta);
                            }
                            else
                            {
                                Console.WriteLine("Número de legislador no válido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número de legislador no válido.");
                        }
                        break;


                    case '5':
                        Console.Clear();
                        Console.WriteLine("Agregar un legislador:");
                        // Agregar un Diputado

                        Console.WriteLine("Agregando un nuevo Diputado:");

                        // Solicita la información al usuario
                        Console.Write("Partido Político: ");
                        string partidoDiputado = Console.ReadLine();

                        Console.Write("Departamento que Representa: ");
                        string departamentoDiputado = Console.ReadLine();

                        Console.Write("Número de Despacho: ");
                        if (int.TryParse(Console.ReadLine(), out int numDespachoDiputado))
                        {
                            Console.Write("Nombre: ");
                            string nombreDiputado = Console.ReadLine();

                            Console.Write("Apellido: ");
                            string apellidoDiputado = Console.ReadLine();

                            Console.Write("Edad: ");
                            if (int.TryParse(Console.ReadLine(), out int edadDiputado))
                            {
                                Console.Write("Casado (Sí o No): ");
                                bool casadoDiputado = Console.ReadLine().Trim().Equals("Sí", StringComparison.OrdinalIgnoreCase);

                                // Crea un nuevo Diputado con la información proporcionada
                                Diputado nuevoDiputado = new Diputado(partidoDiputado, departamentoDiputado, numDespachoDiputado, nombreDiputado, apellidoDiputado, edadDiputado, casadoDiputado, numDespachoDiputado);

                                // Registra el nuevo Diputado en el parlamento
                                miParlamento.RegistrarLegislador(nuevoDiputado);

                                Console.WriteLine("Diputado registrado con éxito.");
                            }
                            else
                            {
                                Console.WriteLine("Edad ingresada no válida.");
                            }
                        }
                        break;


                    case '6':
                        Console.Clear();

                        Console.Write("Seleccione el número del legislador para registrar el voto: ");
                        if (int.TryParse(Console.ReadLine(), out int seleccion))
                        {
                            if (seleccion >= 1 && seleccion <= miParlamento.getLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorSeleccionado = miParlamento.getLegisladores()[seleccion - 1];

                                Console.Write("Ingrese el proyecto de ley: ");
                                string proyectoDeLey = Console.ReadLine();

                                Console.WriteLine("Seleccione el voto:");
                                Console.WriteLine("1. Aprobado");
                                Console.WriteLine("2. Rechazado");
                                Console.WriteLine("3. Abstención");

                                if (int.TryParse(Console.ReadLine(), out int votoSeleccionado) && votoSeleccionado >= 1 && votoSeleccionado <= 3)
                                {
                                    // Registra el voto del legislador seleccionado
                                    Voto voto = (Voto)(votoSeleccionado - 1);
                                    legisladorSeleccionado.Votar(proyectoDeLey, voto);
                                }
                                else
                                {
                                    Console.WriteLine("Opción de voto no válida.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Número de legislador no válido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número de legislador no válido.");
                        }
                        break;


                    case '7':
                        Console.Clear();
                        Console.WriteLine("Borrando un legislador:");

                        // Solicita información para identificar al legislador a borrar
                        Console.Write("Nombre del legislador a borrar: ");
                        string nombreABorrar = Console.ReadLine();

                        // Recorre la lista de legisladores para buscar y borrar al legislador
                        bool legisladorEncontrado = false;
                        for (int i = 0; i < miParlamento.getLegisladores().Count; i++)
                        {
                            Legislador legislador = miParlamento.getLegisladores()[i];
                            if (legislador.getNombre().Equals(nombreABorrar, StringComparison.OrdinalIgnoreCase))
                            {
                                // Se encontró el legislador, borrarlo de la lista
                                miParlamento.getLegisladores().RemoveAt(i);
                                Console.WriteLine($"Legislador '{nombreABorrar}' borrado con éxito.");
                                legisladorEncontrado = true;
                                break; // Termina el bucle una vez que se borra el legislador
                            }
                        }

                        // Si no se encontró el legislador, mostrar un mensaje
                        if (!legisladorEncontrado)
                        {
                            Console.WriteLine($"No se encontró ningún legislador con el nombre '{nombreABorrar}'.");
                        }
                        break;


                    case 'º':
                        Console.WriteLine("\n\nGRACIAS POR USAR EL PROGRAMA! :D");
                        break;

                    default:
                        // Mostrar un mensaje de error si la opción no es válida
                        Console.WriteLine("\n\nOpción no válida. Introduce una opción válida.");
                        break;
                }

                Console.WriteLine("\nPulsa cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 'º');
        }
    }
}
