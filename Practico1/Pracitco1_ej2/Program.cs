using System;

namespace Pracitco1_ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Carlos", 28);
            Alumno alumno2 = new Alumno("Juan", 25);

            Console.WriteLine(alumno1.imprimirNombre());
            Console.WriteLine(alumno1.imprimirNombreEdad());
            Console.WriteLine(alumno2.imprimirNombreEdad());

            // Modificando valores con los métodos Set
            alumno1.setNombre("Andrea");
            alumno1.setEdad(22);

            Console.WriteLine(alumno1.imprimirNombre());
            Console.WriteLine(alumno1.imprimirNombreEdad());

        }
    }
}