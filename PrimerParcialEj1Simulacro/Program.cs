namespace PrimerParcialEj1Simulacro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro miPerro = new Perro("Falkor");
            Humano niño = new Humano("Sebastian");
            Tortuga miTortuga = new Tortuga("Morla");

            string idea = "Volar en Falkor!";
            Personaje[] historiaSinFin = new Personaje[3];
            historiaSinFin[0] = miPerro;
            historiaSinFin[1] = niño;
            historiaSinFin[2] = miTortuga;

            niño.pensar(idea);
            miPerro.mensaje();
            miTortuga.mensaje();

            for(int i = 0; i < 3; i++)
            {
                historiaSinFin[i].pensar();
            }

        }
    }
}