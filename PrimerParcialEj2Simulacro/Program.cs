namespace PrimerParcialEj2Simulacro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de las clases Perro, Gato y Víbora
            Perro perro1 = new Perro("Max", "Marrón");
            Perro perro2 = new Perro("Buddy", "Blanco");
            Gato gato = new Gato("Whiskers", "Gris");
            Vibora vibora = new Vibora("Slytherin", "Verde");

            // Imprimir el nombre de la instancia de la Clase Gato
            Console.WriteLine("Nombre del gato: " + gato.GetNombre());

            // Cambiar el nombre del gato y volver a imprimirlo
            gato.SetNombre("Mittens");
            Console.WriteLine("Nuevo nombre del gato: " + gato.GetNombre());

            // Verificar los métodos Correr y vozAnimal para todas las instancias
            perro1.Correr();
            perro1.VozAnimal();

            perro2.Correr();
            perro2.VozAnimal();

            gato.Correr();
            gato.VozAnimal();

            vibora.Reptar();
            vibora.VozAnimal();
        }
    }
}