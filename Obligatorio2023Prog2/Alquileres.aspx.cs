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
            if (!Page.IsPostBack)
            {
                if (!Page.IsPostBack)
                {
                    gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
                    gvAlquileres.DataBind();
                }
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

        protected void grdAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        protected void grdAlquileres_EntrgarClick(object sender, EventArgs e)
        {



        }

        protected void gvVehiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {



        }

        protected void gvVehiculos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvAlquileres.EditIndex = e.NewEditIndex;
            this.gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void gvVehiculos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvAlquileres.Rows[e.RowIndex];
            string matricula = this.gvAlquileres.DataKeys[e.RowIndex].Values[0].ToString();

            bool devuelto = (filaSeleccionada.FindControl("chkDevueltoGrid") as CheckBox).Checked;

            foreach (var alquiler in BaseDeDatos.listaAlquileres)
            {
                if (alquiler.Matricula == matricula)
                {
                    alquiler.AutoDevuelto = devuelto;
                }
            }

            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void txtAlquilerDia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}