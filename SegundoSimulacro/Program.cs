namespace SegundoSimulacro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaCredito unaNotaCredito = new NotaCredito(1500, 00001, "NC-A");
            Factura unaFactura = new Factura(1500, 00002, "F-A");
            Impresora unaImpresora = new Impresora();
            unaImpresora.Imprimir(unaFactura);
            unaImpresora.Imprimir(unaNotaCredito);
        }
    }
}