using Obligatorio2023Prog2.Clases;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Vehiculos : System.Web.UI.Page
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

            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();

            this.dgVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.dgVehiculos.DataBind();

        }
        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvVehiculos.Rows[e.RowIndex];
            string matricula = ((Label)row.FindControl("lblMatricula")).Text;

            List<Vehiculo> vehiculosAEliminar = new List<Vehiculo>();

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == matricula)
                {
                    vehiculosAEliminar.Add(vehiculo);
                    break;
                }
            }

            foreach (var vehiculoAEliminar in vehiculosAEliminar)
            {
                BaseDeDatos.listaVehiculos.Remove(vehiculoAEliminar);
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
            string matricula = ((Label)filaSeleccionada.FindControl("lblMatricula")).Text;

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