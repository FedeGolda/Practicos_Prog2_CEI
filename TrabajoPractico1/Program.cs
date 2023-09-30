using System;
using System.Collections.Generic;

namespace TrabajoPractico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion;

            // Crear una instancia de Parlamento
            Parlamento miParlamento = new Parlamento();

            // Crear un legislador en "modo hardcore"
            Legislador legislador1 = new Legislador("Colorados", "Defensa", 1, "Guido Manini", "Rios", 65, true);
            Legislador legislador2 = new Legislador("Blancos", "Vicepresidente", 2, "Beatriz Argimón", "Cedeira", 62, true);

            // Agregar el legislador a la lista de legisladores del Parlamento
            miParlamento.RegistrarLegislador(legislador1);
            miParlamento.RegistrarLegislador(legislador2);
            legislador1.RegistrarVoto("Si a la baja", "Aprobado");
            legislador1.PresentarPropuestaLegislativa("Si a la baja");
            legislador2.RegistrarVoto("Si a la baja", "Aprobado");
            legislador2.PresentarPropuestaLegislativa("Aumento salario");

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
                Console.WriteLine("\t* 8.    LISTAR PROPUESTAS           *");
                Console.WriteLine("\t* 9.    PARTICIPAR DEBATE           *");
                Console.WriteLine("\t* 0.        SALIR                   *");
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
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            Console.WriteLine($"{contador}. {legislador.getNombre()} {legislador.getApellido()}");
                            contador++;
                        }

                        // Mostrar cantidad de senadores y diputados
                        miParlamento.ContarLegisladoresPorTipo();

                        Console.ReadKey();
                        break;


                    case '2':
                        Console.Clear();
                        miParlamento.ListarCamaras();
                        break;

                    case '3':
                        Console.Clear();
                        // Mostrar lista de legisladores para que el usuario seleccione uno
                        Console.WriteLine("Lista de Legisladores:");
                        int contadorPropuesta = 1;
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            Console.WriteLine($"{contadorPropuesta}. {legislador.getNombre()} {legislador.getApellido()}");
                            contadorPropuesta++;
                        }

                        Console.Write("Seleccione el número del legislador al que desea presentar la propuesta: ");
                        if (int.TryParse(Console.ReadLine(), out int seleccionPropuesta))
                        {
                            if (seleccionPropuesta >= 1 && seleccionPropuesta <= miParlamento.GetLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorSeleccionado = miParlamento.GetLegisladores()[seleccionPropuesta - 1];

                                Console.Write("Propuesta: ");
                                string propuesta = Console.ReadLine();

                                // Registro de voto
                                Console.Write("Voto (Aprobado/Rechazado/Abstencion): ");
                                string voto = Console.ReadLine();
                                legisladorSeleccionado.RegistrarVoto(voto);

                                // Llama al método PresentarPropuestaLegislativa en el legislador seleccionado
                                legisladorSeleccionado.PresentarPropuestaLegislativa(propuesta);

                                Console.WriteLine($"Propuesta presentada y voto registrado con éxito por {legisladorSeleccionado.getNombre()} {legisladorSeleccionado.getApellido()}.");
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


                    case '4':
                        Console.Clear();
                        // Contadores para contar votos
                        int aprobados = 0;
                        int rechazados = 0;
                        int abstencion = 0;

                        // Calcular el total de votos de Aprobados, Rechazados y Abstención
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            foreach (var votoRegistrado in legislador.ObtenerVotos())
                            {
                                string[] partesVoto = votoRegistrado.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                                if (partesVoto.Length == 2)
                                {
                                    string propuesta = partesVoto[0].Trim();
                                    string voto = partesVoto[1].Trim();

                                    if (voto == "Aprobado")
                                    {
                                        aprobados++;
                                    }
                                    else if (voto == "Rechazado")
                                    {
                                        rechazados++;
                                    }
                                    else if (voto == "Abstencion")
                                    {
                                        abstencion++;
                                    }

                                    // Mostrar propuesta y voto
                                    Console.WriteLine($"Legislador: {legislador.getNombre()} {legislador.getApellido()}");
                                    Console.WriteLine($"Propuesta: {propuesta}");
                                    Console.WriteLine($"Voto: {voto}\n");
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



                    case '5':
                        Console.Clear();
                        // Mostrar lista de legisladores para que el usuario seleccione uno
                        Console.WriteLine("Lista de Legisladores:");
                        int contPropuesta = 1;
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            Console.WriteLine($"{contPropuesta}. {legislador.getNombre()} {legislador.getApellido()} ({legislador.getCamara()})");
                            contPropuesta++;
                        }

                        Console.Write("Seleccione el número del legislador al que desea presentar la propuesta: ");
                        if (int.TryParse(Console.ReadLine(), out int selecPropuesta))
                        {
                            if (selecPropuesta >= 1 && selecPropuesta <= miParlamento.GetLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorSeleccionado = miParlamento.GetLegisladores()[selecPropuesta - 1];

                                Console.Write("Propuesta: ");
                                string propuesta = Console.ReadLine();

                                // Llama al método PresentarPropuestaLegislativa en el legislador seleccionado
                                legisladorSeleccionado.PresentarPropuestaLegislativa(propuesta);

                                Console.WriteLine($"Propuesta presentada por {legisladorSeleccionado.getNombre()} {legisladorSeleccionado.getApellido()} en la cámara de {legisladorSeleccionado.getCamara()}.");
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


                    case '6':
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
                            if (!miParlamento.ExisteLegisladorPorNumeroDespacho(numDespachoDiputado))
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
                            else
                            {
                                Console.WriteLine($"Ya existe un legislador con el número de despacho {numDespachoDiputado}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número de despacho no válido.");
                        }
                        break;


                    case '7':
                        Console.Clear();
                        Console.WriteLine("Borrando un legislador:");

                        // Solicita información para identificar al legislador a borrar
                        Console.Write("Número del legislador a borrar: ");
                        int numBorrar;

                        // Intenta convertir la entrada del usuario a un número entero
                        if (int.TryParse(Console.ReadLine(), out numBorrar))
                        {
                            // Llama a un método en la clase Parlamento para borrar un legislador por número
                            if (miParlamento.BorrarLegisladorPorNumero(numBorrar))
                            {
                                Console.WriteLine($"Legislador con número '{numBorrar}' borrado con éxito.");
                            }
                            else
                            {
                                Console.WriteLine($"No se encontró ningún legislador con el número '{numBorrar}'.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Por favor, ingresa un número válido.");
                        }
                        break;


                    case '8':
                        Console.Clear();
                        // Mostrar lista de legisladores para que el usuario seleccione uno
                        Console.WriteLine("Lista de Legisladores:");
                        int contadorPropuestas = 1;
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            Console.WriteLine($"{contadorPropuestas}. {legislador.getNombre()} {legislador.getApellido()}");
                            contadorPropuestas++;
                        }

                        Console.Write("Seleccione el número del legislador del que desea listar las propuestas: ");
                        if (int.TryParse(Console.ReadLine(), out int seleccionLegislador))
                        {
                            if (seleccionLegislador >= 1 && seleccionLegislador <= miParlamento.GetLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorSeleccionado = miParlamento.GetLegisladores()[seleccionLegislador - 1];

                                Console.WriteLine($"Propuestas legislativas de {legisladorSeleccionado.getNombre()} {legisladorSeleccionado.getApellido()}:");

                                // Mostrar las propuestas legislativas del legislador seleccionado
                                foreach (var propuesta in legisladorSeleccionado.PropuestasLegislativas)
                                {
                                    Console.WriteLine(propuesta);
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


                    case '9':
                        Console.Clear();
                        // Mostrar lista de legisladores para que el usuario seleccione uno
                        Console.WriteLine("Lista de Legisladores:");
                        int contadorDebate = 1;
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            Console.WriteLine($"{contadorDebate}. {legislador.getNombre()} {legislador.getApellido()}");
                            contadorDebate++;
                        }

                        Console.Write("Seleccione el número del legislador que desea participar en el debate: ");
                        if (int.TryParse(Console.ReadLine(), out int seleccionDebate))
                        {
                            if (seleccionDebate >= 1 && seleccionDebate <= miParlamento.GetLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorSeleccionado = miParlamento.GetLegisladores()[seleccionDebate - 1];

                                Console.Write("Tema del debate: ");
                                string temaDebate = Console.ReadLine();

                                // Llama al método ParticiparDebate en el legislador seleccionado
                                legisladorSeleccionado.ParticiparDebate(temaDebate);

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




                    case '0':
                        Console.WriteLine("\nGRACIAS POR USAR EL PROGRAMA! :D");
                        break;

                    default:
                        Console.WriteLine("\nOpcion incorrecta!");
                        break;
                }
                Console.WriteLine("\nPresione Enter para volver al menu principal...");
                Console.ReadKey();
            } while (opcion != '0');
        }
    }
}