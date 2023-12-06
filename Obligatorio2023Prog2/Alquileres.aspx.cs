using Obligatorio2023Prog2.Clases;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Alquileres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogeado.getVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogeado.getVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogeado.getVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogeado.getVerAlquileres();
            Master.FindControl("lnkUsuarios").Visible = BaseDeDatos.usuarioLogeado.getVerUsuarios();

            if (!Page.IsPostBack)
            {
                gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
                gvAlquileres.DataBind();
            }
        }



        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.setCedula(cboClientes.SelectedItem.Value);
            alquiler.setMatricula(cboVehiculos.SelectedItem.Value);
            alquiler.setFechaAlquiler(DateTime.Now);
            alquiler.setPrecio(Convert.ToInt32(lblPrecio.Text));
            alquiler.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);

            BaseDeDatos.listaAlquileres.Add(alquiler);

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == cboVehiculos.SelectedItem.Value)
                {
                    vehiculo.Activo = false;
                    break;
                }
            }

            cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
            cboVehiculos.DataTextField = "Matricula";
            cboVehiculos.DataBind();

            Response.Write("<script>alert('Venta ingresada correctamente')</script>");
        }

        protected void gvAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para manejar el evento SelectedIndexChanged
            // Puedes acceder a la fila seleccionada utilizando gvAlquileres.SelectedRow
            // y obtener los valores de las celdas según tus necesidades

            GridViewRow selectedRow = gvAlquileres.SelectedRow;

            // Ejemplo de cómo obtener el valor de una celda en la fila seleccionada
            string matricula = selectedRow.Cells[0].Text;

            // Puedes continuar con la lógica según tus necesidades
            // ...
        }


        protected void gvAlquileres_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvAlquileres.EditIndex = -1;
            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }


        protected void gvAlquileres_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvAlquileres.EditIndex = e.NewEditIndex;
            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }

        protected void gvAlquileres_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Lógica para actualizar una fila en la lista de alquileres
            // Puedes acceder a los controles de edición de la fila utilizando e.RowIndex y encontrar los valores necesarios

            GridViewRow row = gvAlquileres.Rows[e.RowIndex];
            string matricula = gvAlquileres.DataKeys[e.RowIndex].Values["Matricula"].ToString();
            string nuevosDias = (row.FindControl("txtDiasGrid") as TextBox).Text;
            string nuevoPrecio = (row.FindControl("txtPrecioGrid") as TextBox).Text;

            // Actualizar la lista o la base de datos con los nuevos valores
            // ...

            gvAlquileres.EditIndex = -1;
            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }

        protected void gvAlquileres_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Lógica para eliminar una fila en la lista de alquileres
            // Puedes acceder a los valores de la fila que se está eliminando utilizando e.RowIndex

            GridViewRow row = gvAlquileres.Rows[e.RowIndex];
            string matricula = gvAlquileres.DataKeys[e.RowIndex].Values["Matricula"].ToString();

            // Eliminar la fila de la lista o de la base de datos
            // ...

            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }


        protected void txtAlquilerDia_TextChanged(object sender, EventArgs e)
        {
            // Lógica que deseas ejecutar cuando el texto en el TextBox cambia
            // Puedes acceder al valor actual del TextBox con txtAlquilerDia.Text
        }

    }
}