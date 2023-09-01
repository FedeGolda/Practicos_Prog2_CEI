using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej7
{
    internal class Factura
    {
        private int fecha;
        private int importe;

        public int GetFecha() 
        { 
            return fecha;
        }

        public int GetImporte()
        {
            return importe;
        }

        public void SetFecha(int fecha)
        { 
            this.fecha = fecha;
        }

        public void SetImporte(int importe)
        { 
            this.importe = importe;
        }

    }
}
