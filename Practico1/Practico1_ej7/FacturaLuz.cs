using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej7
{
    internal class FacturaLuz
    {
        private int CodigoPago;
        private int importe;

        public int GetCodigoPago()
        { 
            return CodigoPago;
        }
        public int GetImporte()
        { 
            return importe;
        }
        public void SetCodigoPago(int codigoPago)
        { 
            this.CodigoPago = codigoPago;
        }

        public void SetImporte(int importe)
        {
            this.importe = importe;
        }

    }
}
