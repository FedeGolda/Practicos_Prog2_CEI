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
            Legislador legislador1 = new Legislador("Colorados", "Defensa", 2, "Guido Manini", "Rios", 65, true);
            Legislador legislador2 = new Legislador("Blancos", "Vicepresidente", 1, "Beatriz Argimón", "Cedeira", 62, true);

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
                        miParlamento.ContarLegisladoresPorTipo();
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

                    case '4':
                        Console.Clear();
                        // Contadores para contar votos
                        int aprobados = 0;
                        int rechazados = 0;
                        int abstencion = 0;

                        // Calcular el total de votos de Aprobados, Rechazados y Abstención
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            foreach (var votoRegistrado in legislador.Votos)
                            {
                                if (votoRegistrado == "Aprobado") // Cambiar Voto.Aprobado a "Aprobado"
                                {
                                    aprobados++;
                                }
                                else if (votoRegistrado == "Rechazado") // Cambiar Voto.Rechazado a "Rechazado"
                                {
                                    rechazados++;
                                }
                                else if (votoRegistrado == "Abstencion") // Cambiar Voto.Abstencion a "Abstencion"
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
                        Console.Write("Nombre del legislador a borrar: ");
                        string nombreABorrar = Console.ReadLine();

                        // Llama a un método en la clase Parlamento para borrar un legislador por nombre
                        if (miParlamento.BorrarLegislador(nombreABorrar))
                        {
                            Console.WriteLine($"Legislador '{nombreABorrar}' borrado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró ningún legislador con el nombre '{nombreABorrar}'.");
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
