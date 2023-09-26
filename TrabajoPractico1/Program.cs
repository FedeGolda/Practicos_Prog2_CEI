﻿using System;

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
                Console.WriteLine("\t* 2.        VOTOS                   *");
                Console.WriteLine("\t* 3.    PROPUESTAS LEGISLATIVA      *");
                Console.WriteLine("\t* 4.    AGREGAR LEGISLADOR          *"); 
                Console.WriteLine("\t* 5.    BORRAR LEGISLADOR           *"); 
                Console.WriteLine("\t* 6.    LISTAR CAMARA               *");
                Console.WriteLine("\t* º.        SALIR                   *");
                Console.WriteLine("\t*************************************");
                Console.Write("\tSeleccione una opción: ");

                opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                    case '1':
                        Console.Clear();
                        miParlamento.ContarLegisladoresPorTipo();
                        break;

                    case '2':
                        Console.Clear();
                        // Implementa la lógica para registrar votos aquí
                        break;

                    case '3':
                        Console.Clear();
                        // Implementa la lógica para presentar propuestas legislativas aquí
                        break;

                    case '4':
                        Console.Clear();
                        Console.WriteLine("Agregar un legislador:");

                        // Solicita el tipo de legislador al usuario
                        Console.WriteLine("Elija el tipo de legislador:");
                        Console.WriteLine("1. Diputado");
                        Console.WriteLine("2. Senador");
                        Console.Write("Seleccione una opción (1 o 2): ");

                        char opcionAgregar = Console.ReadKey().KeyChar;
                        Console.WriteLine(); // Salto de línea para separar

                        switch (opcionAgregar)
                        {
                            case '1':
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
                                        Diputado nuevoDiputado = new Diputado(partidoDiputado, departamentoDiputado, numDespachoDiputado, nombreDiputado, apellidoDiputado, edadDiputado, casadoDiputado);

                                        // Registra el nuevo Diputado en el parlamento
                                        miParlamento.RegistrarLegislador(nuevoDiputado);

                                        Console.WriteLine("Diputado registrado con éxito.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Edad ingresada no válida.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Número de Despacho ingresado no válido.");
                                }
                                break;

                            case '2':
                                // Agregar un Senador
                                Console.WriteLine("Agregando un nuevo Senador:");

                                // Solicita la información al usuario
                                Console.Write("Partido Político: ");
                                string partidoSenador = Console.ReadLine();

                                Console.Write("Departamento que Representa: ");
                                string departamentoSenador = Console.ReadLine();

                                Console.Write("Número de Despacho: ");
                                if (int.TryParse(Console.ReadLine(), out int numDespachoSenador))
                                {
                                    Console.Write("Nombre: ");
                                    string nombreSenador = Console.ReadLine();

                                    Console.Write("Apellido: ");
                                    string apellidoSenador = Console.ReadLine();

                                    Console.Write("Edad: ");
                                    if (int.TryParse(Console.ReadLine(), out int edadSenador))
                                    {
                                        Console.Write("Casado (Sí o No): ");
                                        bool casadoSenador = Console.ReadLine().Trim().Equals("Sí", StringComparison.OrdinalIgnoreCase);

                                        // Crea un nuevo Senador con la información proporcionada
                                        Senador nuevoSenador = new Senador(partidoSenador, departamentoSenador, numDespachoSenador, nombreSenador, apellidoSenador, edadSenador, casadoSenador);

                                        // Registra el nuevo Senador en el parlamento
                                        miParlamento.RegistrarLegislador(nuevoSenador);

                                        Console.WriteLine("Senador registrado con éxito.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Edad ingresada no válida.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Número de Despacho ingresado no válido.");
                                }
                                break;

                            default:
                                Console.WriteLine("Opción no válida. Introduce 1 para Diputado o 2 para Senador.");
                                break;
                        }
                        break;



                    case '5':
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

                    case '6':
                        Console.Clear();
                        miParlamento.ListarCamaras();
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
