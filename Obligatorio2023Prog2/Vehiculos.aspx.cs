using Microsoft.Ajax.Utilities;
using Obligatorio2023Prog2.Clases;
using System;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Vehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogeado.getVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogeado.getVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogeado.getVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogeado.getVerAlquileres();
            Master.FindControl("lnkUsuarios").Visible = BaseDeDatos.usuarioLogeado.getVerUsuarios();
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.setMatricula(txtMatricula.Text);
            vehiculo.setModelo(txtModelo.Text);
            vehiculo.setMarca(txtMarca.Text);
            vehiculo.setColor(txtColor.Text);
            vehiculo.setAño(txtAño.Text);

            // Validar y convertir los valores a los tipos adecuados
            if (int.TryParse(txtKilometros.Text, out int kilometros))
            {
                vehiculo.setKilometros(kilometros);
            }

            if (double.TryParse(txtPrecioVenta.Text, out double precioVenta))
            {
                vehiculo.setPrecioVenta(precioVenta);
            }

            if (double.TryParse(txtPrecioAlquiler.Text, out double precioAlquilerDia))
            {
                vehiculo.setPrecioAlquilerDia(precioAlquilerDia);
            }

            BaseDeDatos.listaVehiculos.Add(vehiculo);

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

            TextBox txtMarcaGrid = filaSeleccionada.FindControl("txtMarcaGrid") as TextBox;
            TextBox txtModeloGrid = filaSeleccionada.FindControl("txtModeloGrid") as TextBox;

            if (txtMarcaGrid != null && txtModeloGrid != null)
            {
                string marca = txtMarcaGrid.Text;
                string modelo = txtModeloGrid.Text;

                foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                {
                    if (vehiculo.getMatricula() == matricula)
                    {
                        vehiculo.setMarca(marca);
                        vehiculo.setModelo(modelo);
                        //vehiculo.setAño(año);
                        break;
                    }
                }
            }

            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();

            this.dgVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.dgVehiculos.DataBind();
        }

        protected void txtAuto_TextChanged(object sender, EventArgs e)
        {
                txtAuto.Visible = true;
        }
    }
}
