using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSimulacro
{
    internal class NotaCredito : DocumentoContable
    {
        public NotaCredito(double importe, int numero, string siglas) : base(importe, numero, siglas)
        {

        }
        public override double total()
        {
            return (getImporte() * -1);
        }
    }
}
