using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baño miBaño = new Baño();
            Console.WriteLine(miBaño.getColor());

            Dormitorio miDormitorio = new Dormitorio(2,2,2,"blanco","cama king");
            Console.WriteLine(miDormitorio.getColor());
            Console.WriteLine(miDormitorio.getCama());
            miBaño.infoPintura();
            Console.WriteLine(miDormitorio.metrosCuadradosTecho());
            Console.WriteLine(miDormitorio.metrosCuadradosPared());
        }
    }
}
