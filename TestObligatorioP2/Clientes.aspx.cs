using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestObligatorioP2.Clases;

namespace TestObligatorioP2
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Si es la primera carga de la página, puedes realizar alguna lógica aquí.
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtén el valor del TextBox txtCedula
            string cedula = txtCedula.Text;

            // Crea una instancia de Cliente con la cédula ingresada
            Cliente cliente = new Cliente(cedula);

            // Agrega el cliente a la lista de clientes en BaseDeDatos
            BaseDeDatos.listaClientes.Add(cliente);

            // Asigna la lista de clientes al GridView gvClientes
            this.gvClientes.DataSource = BaseDeDatos.listaClientes;
            this.gvClientes.DataBind();

            // Asigna la lista de clientes al DataGrid dgClientes
            this.dgClientes.DataSource = BaseDeDatos.listaClientes;
            this.dgClientes.DataBind();
        }

        protected void gvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string cedula = this.gvClientes.DataKeys[e.RowIndex].Values[0].ToString();

            // Encuentra el cliente en la lista y remuévelo
            Cliente clienteToRemove = BaseDeDatos.listaClientes.FirstOrDefault(c => c.getCedula() == cedula);
            if (clienteToRemove != null)
            {
                BaseDeDatos.listaClientes.Remove(clienteToRemove);
            }

            this.gvClientes.DataSource = BaseDeDatos.listaClientes;
            this.gvClientes.DataBind();

            this.dgClientes.DataSource = BaseDeDatos.listaClientes;
            this.dgClientes.DataBind();
        }

        protected void gvClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvClientes.EditIndex = -1;
            this.gvClientes.DataSource = BaseDeDatos.listaClientes;
            this.gvClientes.DataBind();
        }

        protected void gvClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvClientes.EditIndex = e.NewEditIndex;
            this.gvClientes.DataSource = BaseDeDatos.listaClientes;
            this.gvClientes.DataBind();
        }

        protected void gvClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvClientes.Rows[e.RowIndex];
            string cedula = this.gvClientes.DataKeys[e.RowIndex].Values[0].ToString();

            // Encuentra el cliente en la lista y actualiza su cédula
            Cliente clienteToUpdate = BaseDeDatos.listaClientes.FirstOrDefault(c => c.getCedula() == cedula);
            if (clienteToUpdate != null)
            {
                TextBox txtEditCedula = (TextBox)filaSeleccionada.FindControl("txtEditCedula");
                clienteToUpdate.setCedula(txtEditCedula.Text);
            }

            this.gvClientes.EditIndex = -1;
            this.gvClientes.DataSource = BaseDeDatos.listaClientes;
            this.gvClientes.DataBind();

            this.dgClientes.DataSource = BaseDeDatos.listaClientes;
            this.dgClientes.DataBind();
        }
    }
}
