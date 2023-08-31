using System.Numerics;
using System.Runtime.Intrinsics;

namespace Practico1_ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valoresX = { 1, 2, 3 };
            int[] valoresY = { 4, 5, 6 };

            Vector vector = new Vector(valoresX, valoresY);

            int[] suma = vector.SumaVectores(valoresX, valoresY);
            Console.WriteLine("Suma: " + string.Join(", ", suma));

            string resta = vector.ImprimirResta(valoresX, valoresY);
            Console.WriteLine(resta);
        }
    }
}