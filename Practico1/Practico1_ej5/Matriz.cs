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

        public Matriz(int x, int y)
        {
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

    }
}
