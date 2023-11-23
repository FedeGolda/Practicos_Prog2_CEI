using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2.Clases
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                CargarDatos();
        }

        private void CargarDatos()
        {
            BaseDeDatos.ListarClientes();
            gvClientes.DataSource = BaseDeDatos.listaClientes;
            gvClientes.DataBind();
        }

        protected void gvClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvClientes.EditIndex = e.NewEditIndex;
            CargarDatos();
        }

        protected void gvClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvClientes.Rows[e.RowIndex];
            int id = Convert.ToInt32(gvClientes.DataKeys[e.RowIndex].Value);
            string nombre = ((TextBox)row.FindControl("txtNombre")).Text;
            string apellido = ((TextBox)row.FindControl("txtApellido")).Text;
            string cedula = ((TextBox)row.FindControl("txtCedula")).Text;

            // Actualizar el cliente en la lista
            Cliente cliente = BaseDeDatos.listaClientes.Find(c => c.getId() == id);
            if (cliente != null)
            {
                cliente.setNombre(nombre);
                cliente.setApellido(apellido);
                cliente.setCedula(cedula);
            }

            gvClientes.EditIndex = -1;
            CargarDatos();
        }

        protected void gvClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvClientes.EditIndex = -1;
            CargarDatos();
        }

        protected void gvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvClientes.DataKeys[e.RowIndex].Value);

            // Eliminar el cliente de la lista
            Cliente cliente = BaseDeDatos.listaClientes.Find(c => c.getId() == id);
            if (cliente != null)
                BaseDeDatos.listaClientes.Remove(cliente);

            CargarDatos();
        }

        protected void gvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manejar la selección si es necesario
        }
    }
}
