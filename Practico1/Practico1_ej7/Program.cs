namespace Practico1_ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            Factura factura = new Factura(); // Crear una instancia de Factura
            FacturaLuz facturaLuz = new FacturaLuz();
            ReciboSueldo reciboSueldo = new ReciboSueldo();
            Remito remito = new Remito();
            Municipal municipal = new Municipal();

            do
            {
                Console.Clear(); // Limpiar la pantalla en cada iteración del bucle
                Console.WriteLine("Menú Repetitivo");
                Console.WriteLine("1. IMPRIMIR FACTURA");
                Console.WriteLine("2. IMPRIMIR FACTURA LUZ");
                Console.WriteLine("3. IMPRIMIR RECIBO SUELDO");
                Console.WriteLine("4. IMPRIMIR REMITO");
                Console.WriteLine("5. IMPRIMIR MUNICIPAL");
                Console.WriteLine("6. SALIR");
                Console.Write("Seleccione una opción: ");

                // Leer la tecla del usuario
                choice = Console.ReadKey().KeyChar;

                // Procesar la opción seleccionada
                switch (choice)
                {
                    case '1':
                        factura.Imprimir(); // Llama al método Imprimir de la clase Impresora
                        break;

                    case '2':
                        facturaLuz.Imprimir(facturaLuz);
                        break;

                    case '3':
                        reciboSueldo.Imprimir(reciboSueldo);
                        break;

                    case '4':
                        remito.Imprimir(remito);
                        break;

                    case '5':
                        municipal.Imprimir(municipal);
                        break;

                    case '6':
                        Console.WriteLine("\nCERRANDO PROGRAMA.....\n");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Introduce una opción válida.");
                        break;
                }

                Console.WriteLine("\nPulsa cualquier tecla para continuar...\n");
                Console.ReadKey();

            } while (choice != '6');
        }
    }
}