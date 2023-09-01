using System.Numerics;
using System.Runtime.Intrinsics;
using Practico1_ej3.Practico1_ej3;

namespace Practico1_ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valoresX = { 1, 2 };
            int[] valoresY = { 4, 5 };

            Console.WriteLine("Valores actuales: " + valoresX, valoresY);

            int[] suma = Vectores.SumaVectores(valoresX, valoresY);
            Console.WriteLine("Suma: " + string.Join(", ", suma));

            string resta = Vectores.ImprimirResta(valoresX, valoresY);
            Console.WriteLine(resta);
        }
    }
}