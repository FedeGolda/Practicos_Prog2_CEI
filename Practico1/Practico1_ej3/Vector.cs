using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej3
{
    namespace Practico1_ej3
    {
        public class Vector
        {
            private int[] x;
            private int[] y;

            public Vector(int[] x, int[] y)
            {
                // Aquí podrías agregar validación para asegurarte de que los arreglos tengan la misma longitud.
                this.x = x;
                this.y = y;
            }

            public string GetVectores()
            {
                string vector1 = "Vector1: " + string.Join(", ", x);
                string vector2 = "Vector2: " + string.Join(", ", y);
                return vector1 + "\n" + vector2;
            }

            // Puedes agregar métodos para realizar operaciones con los vectores, como suma, resta, producto escalar, etc.

            public int[] sumaVectores(int[] x, int[] y) 
            {
                int[] resultado = new int[x.Length];

                for (int i = 0; i < x.Length; i++)
                {
                    resultado[i] = x[i] + y[i];
                }

                return resultado;
            }

            public string imprimirResta(int[] x, int[] y)
            {
                int[] resultado = new int[x.Length];

                for(int i = 0; i < x.Length; i++)
                {
                    resultado[i] = x[i] - y[i];
                }

                return "Resultado Resta: " + resultado;
            }

        }
    }
}
