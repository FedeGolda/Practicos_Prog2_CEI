using System;

namespace Practico1_ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto Auto usando el constructor sin parámetros
            Auto auto1 = new Auto();
            Console.WriteLine(auto1.GetTapiceria());
            Console.WriteLine(auto1.GetTipoClimatizador());

            // Crear otro objeto Auto usando el constructor sobrecargado
            Auto auto2 = new Auto("Cuero", "Automático");
            Console.WriteLine(auto2.GetTapiceria());
            Console.WriteLine(auto2.GetTipoClimatizador());

            // Cambiar la tapicería y el tipo de climatizador del segundo auto
            auto2.SetTapiceria("Tela");
            auto2.SetTipoClimatizador("Manual");
            Console.WriteLine(auto2.GetTapiceria());
            Console.WriteLine(auto2.GetTipoClimatizador());

            Console.ReadLine();
        }
    }
}