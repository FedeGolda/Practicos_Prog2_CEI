using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej7
{
    internal class Factura : Impresora
    {
        private int fecha;
        private int importe;

        public Factura()
        {
            fecha = 051223;
            importe = 100;
        }

        public string GetFecha()
        {
            return "Fecha :" + fecha;
        }

        public string GetImporte()
        {
            return "Importe: " + importe;
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
