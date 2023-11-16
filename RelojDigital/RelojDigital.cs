namespace RelojDigital
{
    public partial class RelojDigital : Form
    {
        public RelojDigital()
        {
            InitializeComponent();
            // Configurar el estilo del borde y deshabilitar la opción de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Tamaño fijo de la ventana
            this.MaximizeBox = false; // Deshabilitar el botón de maximizar
            this.Text = "Reloj Digital";  // Cambiar el texto de la barra de título


            // Configurar la fuente y el color de fondo para las etiquetas
            labelHora.Font = new Font("DS-Digital", 48, FontStyle.Regular, GraphicsUnit.Point);
            labelFecha.Font = new Font("DS-Digital", 24, FontStyle.Regular, GraphicsUnit.Point);
            labelHora.BackColor = Color.Black;  // Color de fondo negro para el efecto de display de siete segmentos
            labelFecha.BackColor = Color.Black; // Color de fondo negro para el efecto de display de siete segmentos
            labelHora.ForeColor = Color.Red;    // Color rojo para los dígitos de la hora
            labelFecha.ForeColor = Color.Green;   // Color verde para los dígitos de la fecha
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            try
            {
                // Actualizar las etiquetas con la hora y la fecha actual
                labelHora.Text = DateTime.Now.ToLongTimeString();
                labelFecha.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, mostrar un mensaje de error.
                MessageBox.Show("Error al obtener la hora y la fecha: " + ex.Message);
            }
        }
    }
}