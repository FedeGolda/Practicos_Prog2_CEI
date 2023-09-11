using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Lengua : Asignaturas
    {
        public void sumar(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        public override void nota()
        {
            Console.WriteLine("6");
        }
    }
}
