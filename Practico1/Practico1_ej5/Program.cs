using System;

namespace Practico1_ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;

            Matriz matriz1 = new Matriz(x, y);
            Matriz matriz2 = new Matriz(x, y);

            // Crear una instancia de Random para generar valores aleatorios
            Random rand = new Random();

            // Configurar valores aleatorios en las matrices matriz1 y matriz2
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matriz1.SetMatriz1Value(i, j, rand.Next(1, 10)); // Valores aleatorios entre 1 y 9
                    matriz2.SetMatriz2Value(i, j, rand.Next(1, 10)); // Valores aleatorios entre 1 y 9
                }
            }

            

            Console.WriteLine("Matriz 1:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(matriz1.GetMatriz1(i, j) + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz 2:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(matriz2.GetMatriz2(i, j) + "\t");
                }
                Console.WriteLine();
            }

            // Calcular la suma de las matrices
            int[,] suma = matriz1.SumarMatrices();

            Console.WriteLine("\nSuma de las matrices:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(suma[i, j] + "\t");
                }
                Console.WriteLine(); // Nueva línea para la siguiente fila
            }
        }
    }
}
