using System;
using System.Web.UI.WebControls;
using Obligatorio2023Prog2.Clases;

namespace Obligatorio2023Prog2
{
    public partial class VehiculosPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.setMatricula(txtMatricula.Text);
            vehiculo.setModelo(txtModelo.Text);
            vehiculo.setMarca(txtMarca.Text);

            BaseDeDatos.listaVehiculos.Add(vehiculo);

            // Actualizar las vistas de datos
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();

            this.dgVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.dgVehiculos.DataBind();
        }

        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string matricula = this.gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == matricula)
                {
                    BaseDeDatos.listaVehiculos.Remove(vehiculo);
                    break;
                }
            }

            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();

            this.dgVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.dgVehiculos.DataBind();
        }

        protected void gvVehiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvVehiculos.EditIndex = e.NewEditIndex;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvVehiculos.Rows[e.RowIndex];
            string matricula = this.gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();

            string marca = (filaSeleccionada.FindControl("txtMarcaGrid") as TextBox).Text;
            string modelo = (filaSeleccionada.FindControl("txtModeloGrid") as TextBox).Text;

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == matricula)
                {
                    vehiculo.setMarca(marca);
                    vehiculo.setModelo(modelo);
                    break;
                }
            }

            // Actualizar las vistas de datos
            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();

            this.dgVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.dgVehiculos.DataBind();
        }
    }
}
