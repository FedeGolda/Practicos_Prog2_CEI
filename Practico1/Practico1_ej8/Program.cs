namespace Practico1_ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos instancias
            Familia Nuevo = new Familia("ninguno"); // Llama el constructor por defecto
            Gato gatoSimpson = new Gato(); // Llama al constructor por defecto

            Perro perroSimpson = new Perro("Ayudante de Santa"); // Llaman al segundo constructor
            Humano hijoSimpson = new Humano("Bart");
            Humano hijaSimpson = new Humano("Lisa");

            // Utilizo instancias
            perroSimpson.ladrar();
            gatoSimpson.maullar();
            gatoSimpson.respirar();
            Nuevo.respirar();
            Console.WriteLine(Nuevo.getInfo());
            hijaSimpson.hablar();

            Console.WriteLine("");
            Console.WriteLine(gatoSimpson.getInfo());
            gatoSimpson.setInfo("Bola de Nieve");
            Console.WriteLine("");

            Console.WriteLine(perroSimpson.getInfo());
            perroSimpson.setApodoPerro("huesos");
            Console.WriteLine(perroSimpson.getApodoPerro());

            Console.Read();

        }
    }
}