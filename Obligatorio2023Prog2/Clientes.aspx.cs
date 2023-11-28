using Obligatorio2023Prog2.Clases;
using System;
using System.Collections.Generic;
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

        protected void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            // Crear un nuevo cliente y asignar los valores
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.setCedula(txtCedula.Text);
            nuevoCliente.setNombre(txtNombre.Text);
            nuevoCliente.setApellido(txtApellido.Text);
            nuevoCliente.setDireccion(txtDireccion.Text);

            // Agregar el cliente a la lista
            BaseDeDatos.listaClientes.Add(nuevoCliente);

            // Actualizar la GridView
            BindGridView();
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

