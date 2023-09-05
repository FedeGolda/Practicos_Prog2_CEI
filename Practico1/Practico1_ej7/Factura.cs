using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej7
{
    internal class Factura : Impresora
    {
        private DateTime fecha;
        private int importe;

        public Factura()
        {
            fecha = DateTime.ParseExact("05/12/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            importe = 100;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }

        public int GetImporte()
        {
            return importe;
        }

        public void SetFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void SetImporte(int importe)
        {
            this.importe = importe;
        }



    }
}
