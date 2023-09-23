namespace TrabajoPractico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Parlamento
            Parlamento miParlamento = new Parlamento();

            // Agregar legisladores a miParlamento (puedes usar el método RegistrarLegislador)

            // Luego, contar y mostrar la cantidad de senadores y diputados
            miParlamento.ContarLegisladoresPorTipo();

            Senador senador = new Senador("Partido A", "Departamento X", 1, "Juan", "Perez", 45, true, 101);
            Diputado diputado = new Diputado("Partido B", "Departamento Y", 2, "Maria", "Gomez", 35, false, 201);

            senador.PresentarPropuestaLegislativa("Ley de Educación");
            diputado.PresentarPropuestaLegislativa("Reforma Fiscal");

            senador.Votar("Ley de Educación", Voto.Aprobado);
            diputado.Votar("Reforma Fiscal", Voto.Rechazado);

            senador.ParticiparDebate("Reforma de Pensiones");
            diputado.ParticiparDebate("Presupuesto Nacional");
        }
    }
}