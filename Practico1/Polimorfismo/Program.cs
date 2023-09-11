namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematicas objMatematicas = new Matematicas();
            Lengua objLengua = new Lengua();
            Fisica objFisica = new Fisica();

            Asignaturas[] objAsignaturas = new Asignaturas[3];
            objAsignaturas[0] = objMatematicas;
            objAsignaturas[1] = objLengua;
            objAsignaturas[2] = objFisica;

            // Polimorfismo Parametrico
            objMatematicas.sumar(3.5, 2.2);
            objMatematicas.sumar(3, 2);

            // Polimorfismo Sobrecarga
            objLengua.sumar("Juan", "Pedro");

            // Polimorfismo Subtipado
            for(int i = 0; i < 3; i++)
            {
                objAsignaturas[i].nota();
            }
            Console.ReadLine();
        }
    }
}