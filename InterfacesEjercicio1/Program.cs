using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaCredito unaNotaCredito = new NotaCredito("NC-A", 00001, 1500);
            Factura unaFactura = new Factura("F-A",00001,1500);

            Impresora unaImpresora = new Impresora();
            unaImpresora.Imprimir(unaFactura);
            unaImpresora.Imprimir(unaNotaCredito);
        }
    }
}
