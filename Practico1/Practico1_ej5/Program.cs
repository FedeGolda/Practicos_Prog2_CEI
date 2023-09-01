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


            // Configurar valores en las matrices matriz1 y matriz2
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matriz1.SetMatriz1Value(i, j, i + j);  // Ejemplo: Configurando valores en matriz1
                    matriz2.SetMatriz2Value(i, j, i - j);  // Ejemplo: Configurando valores en matriz2
                }
            }

            // Calcular y mostrar la suma de las matrices
            int[,] suma = matriz1.SumarMatrices();
            Console.WriteLine("Suma de las matrices:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(suma[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
