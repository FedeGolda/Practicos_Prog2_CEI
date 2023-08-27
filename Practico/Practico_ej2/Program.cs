namespace Practico_ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado = 0;
            Console.Write("Ingresar el lado del cuadrado: ");
            lado = int.Parse(Console.ReadLine());

            // Dibujar la primera fila de asteriscos
            for (int i = 0; i < lado; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(""); // Cambiar de línea después de dibujar la primera fila

            // Dibujar las filas intermedias
            for (int i = 2; i < lado; i++)
            {
                Console.Write("*"); // Primer asterisco de cada fila

                // Rellenar con espacios en las columnas intermedias
                for (int j = 2; j < lado; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*"); // Último asterisco de cada fila
            }

            // Dibujar la última fila de asteriscos
            for (int i = 0; i < lado; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine(""); // Cambiar de línea después de dibujar la última fila
            Console.ReadLine(); // Esperar a que el usuario presione Enter antes de salir
        }
    }
}
