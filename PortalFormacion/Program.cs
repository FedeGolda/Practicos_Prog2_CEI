namespace PortalFormacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista para almacenar los alumnos registrados
             List<AlumnoUsuario> listaAlumnos = new List<AlumnoUsuario>();

            // Ejemplo de uso:
            Alta("Juan", 20);
            Alta("Maria", 22);
            MostrarAlumnos();
            Baja("Juan");
            MostrarAlumnos();
        }
    }
}