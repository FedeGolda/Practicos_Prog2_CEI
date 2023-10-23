namespace RelojDigital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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