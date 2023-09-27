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
            legislador1.RegistrarVotoYPropuesta("Si a la baja", "Aprobado");
            legislador2.RegistrarVotoYPropuesta("Si a la baja", "Aprobado");
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
                            Console.WriteLine($"{contador}. {legislador.GetNombre()} {legislador.GetApellido()}");
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
                        int contadorVotos = 1;
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            Console.WriteLine($"{contadorVotos}. {legislador.GetNombre()} {legislador.GetApellido()}");
                            contadorVotos++;
                        }

                        Console.Write("Seleccione el número del legislador al que desea registrar el voto: ");
                        if (int.TryParse(Console.ReadLine(), out int seleccionVoto))
                        {
                            if (seleccionVoto >= 1 && seleccionVoto <= miParlamento.GetLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorSeleccionado = miParlamento.GetLegisladores()[seleccionVoto - 1];

                                Console.Write("Proyecto de Ley: ");
                                string proyectoDeLey = Console.ReadLine();

                                Console.Write("Voto (Aprobado/Rechazado/Abstencion): ");
                                string voto = Console.ReadLine();

                                // Llama al método RegistrarVotoYPropuesta en el legislador seleccionado
                                legisladorSeleccionado.RegistrarVotoYPropuesta(proyectoDeLey, voto);

                                Console.WriteLine($"Voto registrado por {legisladorSeleccionado.GetNombre()} {legisladorSeleccionado.GetApellido()}.");
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

                        // Crear un diccionario para rastrear el total de votos por propuesta
                        Dictionary<string, int> votosPorPropuesta = new Dictionary<string, int>();

                        // Calcular el total de votos por propuesta
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            var votosPorPropuestaLegislador = legislador.ObtenerVotosPorPropuesta();

                            foreach (var propuestaVotos in votosPorPropuestaLegislador)
                            {
                                var proyectoDeLey = propuestaVotos.Key;
                                var votos = propuestaVotos.Value;

                                if (!votosPorPropuesta.ContainsKey(proyectoDeLey))
                                {
                                    votosPorPropuesta[proyectoDeLey] = 0;
                                }

                                foreach (var voto in votos)
                                {
                                    // Puedes manejar otras opciones de voto si es necesario
                                    if (voto == "Aprobado")
                                    {
                                        votosPorPropuesta[proyectoDeLey]++;
                                    }
                                    else if (voto == "Rechazado")
                                    {
                                        votosPorPropuesta[proyectoDeLey]--;
                                    }
                                }
                            }
                        }

                        // Mostrar el total de votos por propuesta
                        Console.WriteLine("Total de Votos por Propuesta:");
                        foreach (var kvp in votosPorPropuesta)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        miParlamento.ContarLegisladoresPorTipo();
                        break;

                    case '5':
                        Console.Clear();
                        // Mostrar lista de legisladores para que el usuario seleccione uno
                        Console.WriteLine("Lista de Legisladores:");
                        int contPropuesta = 1;
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            Console.WriteLine($"{contPropuesta}. {legislador.GetNombre()} {legislador.GetApellido()} ({legislador.GetCamara()})");
                            contPropuesta++;
                        }

                        Console.Write("Seleccione el número del legislador al que desea presentar la propuesta: ");
                        if (int.TryParse(Console.ReadLine(), out int selecPropuesta))
                        {
                            if (selecPropuesta >= 1 && selecPropuesta <= miParlamento.GetLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorPropuesta = miParlamento.GetLegisladores()[selecPropuesta - 1];

                                Console.Write("Propuesta Legislativa: ");
                                string propuesta = Console.ReadLine();

                                // Llama al método PresentarPropuestaLegislativa en el legislador seleccionado
                                legisladorPropuesta.PresentarPropuestaLegislativa(propuesta);

                                Console.WriteLine($"Propuesta registrada por {legisladorPropuesta.GetNombre()} {legisladorPropuesta.GetApellido()}.");
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
                        Console.Write("Nombre del legislador: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Apellido del legislador: ");
                        string apellido = Console.ReadLine();

                        Console.Write("Edad del legislador: ");
                        if (int.TryParse(Console.ReadLine(), out int edad))
                        {
                            Console.Write("Es presidente (S/N): ");
                            bool esPresidente = (Console.ReadLine().ToLower() == "s");

                            Console.Write("Partido político: ");
                            string partido = Console.ReadLine();

                            Console.Write("Camara (Diputado/Senador): ");
                            string camara = Console.ReadLine();

                            if (camara.ToLower() == "diputado")
                            {
                                Diputado diputado = new Diputado(partido, "Diputados", 1, nombre, apellido, edad, esPresidente);
                                miParlamento.RegistrarLegislador(diputado);
                                Console.WriteLine("Diputado registrado exitosamente.");
                            }
                            else if (camara.ToLower() == "senador")
                            {
                                Senador senador = new Senador(partido, "Senadores", 2, nombre, apellido, edad, esPresidente);
                                miParlamento.RegistrarLegislador(senador);
                                Console.WriteLine("Senador registrado exitosamente.");
                            }
                            else
                            {
                                Console.WriteLine("Cámara no válida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Edad no válida.");
                        }
                        break;

                    case '7':
                        Console.Clear();
                        // Mostrar lista de legisladores para que el usuario seleccione uno
                        Console.WriteLine("Lista de Legisladores:");
                        int contadorBorrar = 1;
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            Console.WriteLine($"{contadorBorrar}. {legislador.GetNombre()} {legislador.GetApellido()} ({legislador.GetCamara()})");
                            contadorBorrar++;
                        }

                        Console.Write("Seleccione el número del legislador que desea borrar: ");
                        if (int.TryParse(Console.ReadLine(), out int selecBorrar))
                        {
                            if (selecBorrar >= 1 && selecBorrar <= miParlamento.GetLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorBorrar = miParlamento.GetLegisladores()[selecBorrar - 1];

                                // Llama al método BorrarLegislador en el Parlamento
                                miParlamento.BorrarLegislador(legisladorBorrar);

                                Console.WriteLine($"Legislador {legisladorBorrar.GetNombre()} {legisladorBorrar.GetApellido()} borrado.");
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

                    case '8':
                        Console.Clear();
                        // Mostrar lista de legisladores para que el usuario seleccione uno
                        Console.WriteLine("Lista de Legisladores:");
                        int contadorListarPropuestas = 1;
                        foreach (var legislador in miParlamento.GetLegisladores())
                        {
                            Console.WriteLine($"{contadorListarPropuestas}. {legislador.GetNombre()} {legislador.GetApellido()} ({legislador.GetCamara()})");
                            contadorListarPropuestas++;
                        }

                        Console.Write("Seleccione el número del legislador para listar sus propuestas: ");
                        if (int.TryParse(Console.ReadLine(), out int selecListarPropuestas))
                        {
                            if (selecListarPropuestas >= 1 && selecListarPropuestas <= miParlamento.GetLegisladores().Count)
                            {
                                // El usuario seleccionó un legislador válido
                                var legisladorListarPropuestas = miParlamento.GetLegisladores()[selecListarPropuestas - 1];

                                Console.WriteLine($"Propuestas de {legisladorListarPropuestas.GetNombre()} {legisladorListarPropuestas.GetApellido()}:");

                                foreach (var propuesta in legisladorListarPropuestas.ListarPropuestasLegislativas())
                                {
                                    Console.WriteLine($"- {propuesta}");
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
                }

                Console.WriteLine("\nPresione Enter para volver al menú principal...");
                Console.ReadKey();
            } while (opcion != '0');
        }
    }
}
