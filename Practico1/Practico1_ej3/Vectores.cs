﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej3
{
    namespace Practico1_ej3
    {
        public class Vectores
        {
            private int[] x;
            private int[] y;

            public Vectores(int[] x, int[] y)
            {
                // Aquí podrías agregar validación para asegurarte de que los arreglos tengan la misma longitud.
                this.x = x;
                this.y = y;
            }

            public void SetVectores(int[] x, int[] y)
            {
                this.x = x;
                this.y = y;
            }

            public string GetVectores()
            {
                string vector1 = "Vector1: " + string.Join(", ", x);
                string vector2 = "Vector2: " + string.Join(", ", y);
                return vector1 + "\n" + vector2;
            }

            public static int[] SumaVectores(int[] x, int[] y)
            {
                int[] resultado = new int[x.Length];

                for (int i = 0; i < x.Length; i++)
                {
                    resultado[i] = x[i] + y[i];
                }

                return resultado;
            }

            public static string ImprimirResta(int[] x, int[] y)
            {
                int[] resultado = new int[x.Length];

                for (int i = 0; i < x.Length; i++)
                {
                    resultado[i] = x[i] - y[i];
                }

                return "Resta: " + string.Join(", ", resultado);
            }

            // 4- Intente ampliar el ejercicio anterior para que el código pueda calcular la distancia entre los puntos asociados a los vectores creados.

            public static double calculoDistancia2vectores(int[] x, int[] y)
            {
                double sumaCuadrados = 0;

                for (int i = 0; i < x.Length; i++)
                {
                    int diferencia = x[i] - y[i];
                    sumaCuadrados += Math.Pow(diferencia, 2);
                }

                double distancia = Math.Sqrt(sumaCuadrados);
                return distancia;
            }
                

        }
    }
}
