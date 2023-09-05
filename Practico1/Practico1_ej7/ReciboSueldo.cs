using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej7
{
    internal class ReciboSueldo : Impresora
    {
        private int legajo;
        private int total;

        public ReciboSueldo()
        {
            legajo = 12;
            total = 250;
        }
        public int GetLegajo()
        {
            return legajo;
        }
        public int GetTotal()
        {
            return total;
        }
        public void SetTotal(int total)
        { 
            this.total = total;
        }
        public void SetLegajo(int legajo)
        { 
            this.legajo = legajo;
        }
    }
}
