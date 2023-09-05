using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej7
{
    internal class Impresora
    {
        public void Imprimir()
        {

        }

        public void Imprimir(FacturaLuz facturaLuz)
        {
            // Lógica de impresión de factura de luz
            Console.WriteLine("\nImprimiendo factura de luz...");
        }

        public void Imprimir(Municipal municipal)
        {
            // Lógica de impresión de documento municipal
            Console.WriteLine("\nImprimiendo municipal...");

        }

        public void Imprimir(ReciboSueldo reciboSueldo)
        {
            // Lógica de impresión de recibo de sueldo
            Console.WriteLine("\nImprimiendo recibo sueldo...");
        }

        public void Imprimir(Remito remito)
        {
            // Lógica de impresión de remito
            Console.WriteLine("\nImprimiendo remito...");
        }
    }
}
