using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej5
{
    internal class Matriz
    {
        private int[,] matriz1;
        private int[,] matriz2;
        private int x; // Filas
        private int y; // Columnas

        public Matriz(int x, int y)
        {
            this.x = x;
            this.y = y;
            matriz1 = new int[x, y];
            matriz2 = new int[x, y];
        }

        public int GetMatriz1(int x, int y)
        {
            return matriz1[x, y];
        }

        public int GetMatriz2(int x, int y)
        {
            return matriz2[x, y];
        }

        public void SetMatriz1Value(int x, int y, int value)
        {
            matriz1[x, y] = value;
        }

        public void SetMatriz2Value(int x, int y, int value)
        {
            matriz2[x, y] = value;
        }

        public int[,] SumarMatrices()
        {
            int[,] sumMatrix = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    sumMatrix[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return sumMatrix;
        }

    }
}
