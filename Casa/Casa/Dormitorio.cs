namespace Casa
{
    internal class Dormitorio : Casa
    {
        // Atributo adicional para el tipo de cama en el dormitorio
        private string cama;

        // Constructor de Dormitorio que llama al constructor de Casa
        public Dormitorio(double ancho, double largo, double alto, string color, string cama) : base(ancho, largo, alto, color)
        {
            this.cama = cama;
        }

        // Método para obtener el tipo de cama
        public string getCama()
        {
            return this.cama;
        }
    }
}
