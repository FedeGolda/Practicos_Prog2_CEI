namespace Practico_ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado = 0;
            Console.WriteLine("Ingresar el lado del cuadrado: ");
            lado = int.Parse(Console.ReadLine());

            for (int i = 0; i < lado; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

            for (int i = 2; i < lado; i++)
            {
                Console.Write("*");
                for (int j = 2; j < lado; j++)
                {
                    Console.Write(" ");
                }
            Console.WriteLine("*");
            }

            for (int i = 0; i < lado; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}