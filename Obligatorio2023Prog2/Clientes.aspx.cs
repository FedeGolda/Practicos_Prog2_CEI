using Obligatorio2023Prog2.Clases;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Configuración inicial de la página
                CargarClientes();
            }
        }

        // Función para verificar si ya existe un cliente con la misma cédula
        private bool ClienteExistente(string cedula)
        {
            // Utiliza LINQ para verificar si hay un cliente con la misma cédula en la lista
            return BaseDeDatos.listaClientes.Any(cliente => cliente.getCedula() == cedula);
        }

        protected void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo cliente y asignar los valores
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.setCedula(txtCedula.Text);
                nuevoCliente.setNombre(txtNombre.Text);
                nuevoCliente.setApellido(txtApellido.Text);
                nuevoCliente.setDireccion(txtDireccion.Text);

                // Mostrar la cédula en la consola o en un mensaje de alerta
                Console.WriteLine("Cédula ingresada: " + nuevoCliente.getCedula());

                // Verificar si ya existe un cliente con la misma cédula
                if (ClienteExistente(nuevoCliente.getCedula()))
                {
                    // Mostrar un mensaje de error
                    lblMensajeError.Text = "Ya existe un cliente con esa cédula.";

                    // Mostrar la cédula y el mensaje de error en la consola o en un mensaje de alerta
                    Console.WriteLine("Cédula duplicada: " + nuevoCliente.getCedula());
                    Console.WriteLine("Mensaje de error: " + lblMensajeError.Text);

                    return;
                }

                // Verificar la validez de la cédula uruguaya utilizando la nueva función Validate
                if (!Cliente.Validate(nuevoCliente.getCedula()))
                {
                    // Mostrar un mensaje de error
                    lblMensajeError.Text = "La cédula no es válida. Por favor, ingrese una cédula uruguaya válida.";

                    // Mostrar la cédula y el mensaje de error en la consola o en un mensaje de alerta
                    Console.WriteLine("Cédula no válida: " + nuevoCliente.getCedula());
                    Console.WriteLine("Mensaje de error: " + lblMensajeError.Text);

                    return;
                }

                // Agregar el cliente a la lista
                BaseDeDatos.listaClientes.Add(nuevoCliente);

                lblMensajeError.Visible = false;

                // Actualizar la GridView
                BindGridView();
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                Console.WriteLine("Excepción: " + ex.Message);
                // Puedes agregar más lógica de manejo de errores si es necesario.
            }
        }



        // Función para enlazar la lista de clientes a la GridView
        private void BindGridView()
        {
            gvClientes.DataSource = BaseDeDatos.listaClientes;
            gvClientes.DataBind();
        }

        private void CargarClientes()
        {
            gvClientes.DataSource = BaseDeDatos.listaClientes;
            gvClientes.DataBind();
        }
    }
}
