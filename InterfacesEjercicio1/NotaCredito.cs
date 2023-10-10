using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class NotaCredito : DocumentoContable
    {
        public NotaCredito(string siglas, int numero, double importe) : base(siglas, numero, importe)
        {
            
        }
        public override double total()
        {
            return (getImporte() * 1.21 * -1);

        }
        
    }
}
