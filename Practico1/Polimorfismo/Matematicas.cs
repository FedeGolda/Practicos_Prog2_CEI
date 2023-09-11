using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Matematicas : Asignaturas
    {
        public void sumar(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sumar(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public override void nota()
        {
            Console.WriteLine("10");
        }
    }
}
