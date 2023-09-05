using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej7
{
    internal class Impresora
    {
        public void Imprimir(Factura factura)
        {
            Console.WriteLine("\nImprimiendo factura...");
            Console.WriteLine("\nFecha: " + factura.GetFecha());
            Console.WriteLine("Numero: " + factura.GetImporte());

        }

        public void Imprimir(FacturaLuz facturaLuz)
        {
            Console.WriteLine("\nImprimiendo factura de luz...");
            Console.WriteLine("\nCodigo pago: " + facturaLuz.GetCodigoPago());
            Console.WriteLine("Importe: " + facturaLuz.GetImporte());
        }

        public void Imprimir(Municipal municipal)
        {
            Console.WriteLine("\nImprimiendo municipal...");
            Console.WriteLine("\nImporte: " + municipal.GetImporte());
            Console.WriteLine("Partida: " + municipal.GetPartida());
        }

        public void Imprimir(ReciboSueldo reciboSueldo)
        {
            Console.WriteLine("\nImprimiendo recibo sueldo...");
            Console.WriteLine("\nLegajo: " + reciboSueldo.GetLegajo());
            Console.WriteLine("Total: " + reciboSueldo.GetTotal());
        }

        public void Imprimir(Remito remito)
        {
            Console.WriteLine("\nImprimiendo remito...");
            Console.WriteLine("\nCantidad bultos: " + remito.GetCantBultos());
            Console.WriteLine("Fecha: " + remito.GetFecha());
            Console.WriteLine("Numero: " + remito.GetNumero());
        }
    }
}
