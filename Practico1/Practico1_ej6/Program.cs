namespace Practico1_ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoraConPrecisionSegundos hora1 = new HoraConPrecisionSegundos(10, 30, 45);
            HoraConPrecisionSegundos hora2 = new HoraConPrecisionSegundos(5, 15, 20);

            Console.WriteLine("Hora 1: {0}:{1}:{2}", hora1.GetHoras(), hora1.GetMinutos(), hora1.GetSegundos());
            Console.WriteLine("Hora 2: {0}:{1}:{2}", hora2.GetHoras(), hora2.GetMinutos(), hora2.GetSegundos());

            // Incrementar horas
            hora1.Incrementar(2, 15, 10);
            Console.WriteLine("Hora 1 después de incrementar: {0}:{1}:{2}", hora1.GetHoras(), hora1.GetMinutos(), hora1.GetSegundos());

            // Calcular diferencia de tiempo
            TimeSpan diferencia = hora2.CalcularDiferencia(hora1);
            Console.WriteLine("Diferencia de tiempo entre Hora 2 y Hora 1: {0} horas", diferencia.TotalHours);

            // Sumar horas
            HoraConPrecisionSegundos sumaHoras = HoraConPrecisionSegundos.SumarHoras(hora1, hora2);
            Console.WriteLine("Suma de Hora 1 y Hora 2: {0}:{1}:{2}", sumaHoras.GetHoras(), sumaHoras.GetMinutos(), sumaHoras.GetSegundos());
        }
    }
}
