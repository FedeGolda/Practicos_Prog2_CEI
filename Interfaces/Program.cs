namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro miperro = new Perro("Fluffy");
            miperro.informacion();
            miperro.imprimirFigura();
            Console.WriteLine($"Mi nombre es {miperro.getNombre()}");
            miperro.imprimirFigura();

            Gato migato = new Gato("Sra. Norria");
            migato.informacion();
            migato.imprimirAnimal();
            Console.WriteLine($"Mi nombre es {migato.getNombre()}");
            migato.imprimirFigura();

        }
    }
}