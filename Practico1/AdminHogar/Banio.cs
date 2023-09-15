using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminHogar
{
    internal class Banio : Hogar
    {
        private int cantidad;

        public Banio(int cantidad, string nombreBanio) : base(nombreBanio)
        {
            this.cantidad = cantidad;
        }

        public int GetCantidad()
        {
            return cantidad;
        }
    }
}
