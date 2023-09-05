using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej7
{
    internal class Municipal : Impresora
    {
        private int importe;
        private int partida;

        public Municipal()
        {
            this.importe = 200;
            this.partida = 2;
        }

        public int GetImporte()
        { 
            return importe;
        }
        public int GetPartida()
        {
            return partida;   
        }
        public void SetImporte(int importe)
        { 
            this.importe = importe;
        }
        public void SetPartida(int partida)
        { 
            this.partida = partida;
        }
    }
}
