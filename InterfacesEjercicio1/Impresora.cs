using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class Impresora
    {
        public void Imprimir(Iimprimible unImprimible)
        {
            unImprimible.Imprimir();
        }
    }
}
