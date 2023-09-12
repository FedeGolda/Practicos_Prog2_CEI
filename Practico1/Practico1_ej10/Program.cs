namespace Practico1_ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("Artax");
            Humano guerrero = new Humano("Atreyu");
            Tortuga miTortuga = new Tortuga("Morla");
            Humano principal = new Humano("Sebastian");

            string idea = "lucha";
            Personaje[] historiaSinFin = new Personaje[4];
            historiaSinFin[0] = miCaballo; // Tiene el metodo pensar() de la clase Personaje
            historiaSinFin[1] = guerrero; // Tiene el metodo pensar() de la clase Humano
            historiaSinFin[2] = miTortuga; // Tiene el metodo pensar() de la clase Tortuga
            historiaSinFin[3] = principal; // Tiene el metodo pensar() de la clase Humano
            
            // Verifico los metodos pensar()
            for(int i = 0; i < 4; i++)
            {
                /*
                 El objeto Personaje es Polimorfico ya que tiene la capacidad de comportarse de
                diferente forma dependiendo del contexto.
                llama al metodo respirar() de Personaje y se deriva al metodo respirar() de la clase hijo,
                segun "virtual" seguido de override
                 */
                historiaSinFin[i].pensar();
            }

            // Verifico los metodos respirar()
            for (int i = 0; i < 4; i++)
            {
                historiaSinFin[i].respirar();
            }
            guerrero.pensar(idea); // funciona
            miTortuga.dormir(); // funciona
            // Ver -> Lista de tareas (Ctrl +°, T)
            // TODO
            //historiaSinFin[1].respirar(idea);
            //historiaSinFin[2].dormir();
        }
    }
}