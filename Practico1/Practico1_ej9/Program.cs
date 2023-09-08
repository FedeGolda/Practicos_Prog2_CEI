namespace Practico1_ej9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias
            Familia nuevo = new Familia("ninguno"); // Llama el constructor por defecto
            Gato gatoSimpson = new Gato(); // Llama al constructor por defecto

            Perro perroSimpson = new Perro("Ayudante de Santa", "Huesos"); // Llaman al segundo constructor
            Humano hijoSimpson = new Humano("Bart");
            Humano hijaSimpson = new Humano("Lisa");

            // Utilizar instancias
            perroSimpson.ladrar();
            gatoSimpson.maullar();
            gatoSimpson.respirar();
            nuevo.respirar();
            Console.WriteLine(nuevo.getInfo());
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
