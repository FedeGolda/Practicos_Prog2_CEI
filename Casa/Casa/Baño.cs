using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa
{
    internal class Baño:Casa
    {
        public override void infoPintura()
        {
            Console.WriteLine("esta habitacion tiene azulejos");
        }
        public override double metrosPintura()
        {
            
            return 0;
        }
    }
}
