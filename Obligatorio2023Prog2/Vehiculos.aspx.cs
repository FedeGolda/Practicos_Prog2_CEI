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
        /*
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Auto (puedes cambiarlo por Moto o Camion según sea necesario)
            Auto vehiculo = new Auto(
                txtMarca.Text,
                txtModelo.Text,
                txtMatricula.Text,
                txtAño.Text,
                int.Parse(txtKilometros.Text), // Asumimos que los kilómetros son un valor entero
                txtColor.Text,
                double.Parse(txtPrecioVenta.Text), // Asumimos que el precio de venta es un valor double
                double.Parse(txtPrecioAlquiler.Text), // Asumimos que el precio de alquiler es un valor double
                int.Parse(txtPasajeros.Text) // Asumimos que los pasajeros son un valor entero
            );



            // Convertir el valor de txtKilometros.Text a un entero antes de asignarlo
            if (int.TryParse(txtKilometros.Text, out int kilometros))
            {
                vehiculo.setKilometros(kilometros);
            }
            else
            {
                // Manejar el caso en que la conversión falla (puede mostrar un mensaje de error, asignar un valor predeterminado, etc.)
                // Por ejemplo:
                //lblMensajeError.Text = "El valor de los kilómetros no es válido.";
            }

            vehiculo.setColor(txtColor.Text);

            // Convertir el valor de txtPrecioVenta.Text a double antes de asignarlo
            if (double.TryParse(txtPrecioVenta.Text, out double precioVenta))
            {
                vehiculo.setPrecioVenta(precioVenta);
            }
            else
            {
                // Manejar el caso en que la conversión falla (puede mostrar un mensaje de error, asignar un valor predeterminado, etc.)
                // Por ejemplo:
                // lblMensajeError.Text = "El valor de precio de venta no es válido.";
            }

            // Convertir el valor de txtPrecioAlquiler.Text a double antes de asignarlo
            if (double.TryParse(txtPrecioAlquiler.Text, out double precioAlquiler))
            {
                vehiculo.setPrecioAlquiler(precioAlquiler);
            }
            else
            {
                // Manejar el caso en que la conversión falla (puede mostrar un mensaje de error, asignar un valor predeterminado, etc.)
                // Por ejemplo:
                // lblMensajeError.Text = "El valor de precio de alquiler no es válido.";
            }

            BaseDeDatos.listaVehiculos.Add(vehiculo);

            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();

            this.dgVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.dgVehiculos.DataBind();

        }
        */
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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
