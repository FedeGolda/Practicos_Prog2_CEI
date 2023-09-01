using System;
using Practico1_ej3.Practico1_ej3;

namespace Practico1_ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valoresX = { 4, 5 };
            int[] valoresY = { 2, 3 };

            Console.WriteLine("Valores actuales X: " + string.Join(", ", valoresX));
            Console.WriteLine("Valores actuales Y: " + string.Join(", ", valoresY));

            int[] suma = Vectores.SumaVectores(valoresX, valoresY);
            Console.WriteLine("Suma: " + string.Join(", ", suma));

            string resta = Vectores.ImprimirResta(valoresX, valoresY);
            Console.WriteLine(resta);

            double distancia = Vectores.calculoDistancia2vectores(valoresX, valoresY);
            Console.WriteLine("Distancia: " + distancia);
        }
    }
}
