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

            if (!IsPostBack)
            {
                // Verificar si hay vehículos en la lista
                if (BaseDeDatos.listaVehiculos.Count > 0)
                {
                    // Asignar la lista de vehículos como origen de datos para el GridView
                    gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
                    gvVehiculos.DataBind();
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtAño.Text) ||
                string.IsNullOrWhiteSpace(txtKilometros.Text) ||
                string.IsNullOrWhiteSpace(txtColor.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioAlquiler.Text) ||
                string.IsNullOrWhiteSpace(txtCilindradas.Text) ||
                string.IsNullOrWhiteSpace(txtCantPasajeros.Text) ||
                string.IsNullOrWhiteSpace(txtToneladas.Text) ||
                string.IsNullOrWhiteSpace(txtImagen1.Text) ||
                string.IsNullOrWhiteSpace(txtImagen2.Text) ||
                string.IsNullOrWhiteSpace(txtImagen3.Text))
            {
                lblMensajeError.Text = "Todos los campos son obligatorios. Complete la información.";
                return;
            }

            if (rblTipoVehiculo.SelectedItem.Value == "Moto")
            {
                Moto moto = new Moto();
                moto.setMatricula(txtMatricula.Text);
                moto.setModelo(txtModelo.Text);
                moto.setMarca(txtMarca.Text);
                moto.setAño(txtAño.Text);
                moto.setColor(txtColor.Text);

                // Validar y convertir la entrada de txtPrecioVenta.Text
                if (int.TryParse(txtPrecioVenta.Text, out int precioVenta))
                {
                    moto.setPrecioVenta(precioVenta);
                }
                else
                {
                    // Manejar la entrada no válida, mostrar un mensaje de error, etc.
                    Response.Write("<script>alert('Precio de venta no válido')</script>");
                    return;
                }

                // Repetir el mismo proceso para txtPrecioAlquiler.Text
                if (int.TryParse(txtPrecioAlquiler.Text, out int precioAlquiler))
                {
                    moto.setPrecioAlquilerDia(precioAlquiler);
                }
                else
                {
                    Response.Write("<script>alert('Precio de alquiler no válido')</script>");
                    return;
                }

                moto.setImagen1(txtImagen1.Text);
                moto.setImagen2(txtImagen2.Text);
                moto.setImagen3(txtImagen3.Text);

                // Validar y convertir la entrada de txtCilindradas.Text
                if (int.TryParse(txtCilindradas.Text, out int cilindradas))
                {
                    moto.setCilindradas(cilindradas);
                }
                else
                {
                    Response.Write("<script>alert('Cilindradas no válidas')</script>");
                    return;
                }

                BaseDeDatos.listaVehiculos.Add(moto);
            }
            else if (rblTipoVehiculo.SelectedItem.Value == "Auto")
            {
                Auto auto = new Auto();
                auto.setMatricula(txtMatricula.Text);
                auto.setModelo(txtModelo.Text);
                auto.setMarca(txtMarca.Text);
                auto.setAño(txtAño.Text);
                auto.setKilometros(Convert.ToInt32(txtKilometros.Text));
                auto.setColor(txtColor.Text);
                auto.setPrecioVenta(Convert.ToInt32(txtPrecioVenta.Text));
                auto.setPrecioAlquilerDia(Convert.ToInt32(txtPrecioAlquiler.Text));
                auto.setImagen1(txtImagen1.Text);
                auto.setImagen2(txtImagen2.Text);
                auto.setImagen3(txtImagen3.Text);
                auto.setCampoEspecial("Pasajeros: " + txtCantPasajeros.Text);
                auto.setPasajeros(Convert.ToInt32(txtCantPasajeros.Text));

                BaseDeDatos.listaVehiculos.Add(auto);
            }
            else if (rblTipoVehiculo.SelectedItem.Value == "Camion")
            {
                Camion camion = new Camion();
                camion.setMatricula(txtMatricula.Text);
                camion.setModelo(txtModelo.Text);
                camion.setMarca(txtMarca.Text);
                camion.setAño(txtAño.Text);
                camion.setKilometros(Convert.ToInt32(txtKilometros.Text));
                camion.setColor(txtColor.Text);
                camion.setPrecioVenta(Convert.ToInt32(txtPrecioVenta.Text));
                camion.setPrecioAlquilerDia(Convert.ToInt32(txtPrecioAlquiler.Text));
                camion.setImagen1(txtImagen1.Text);
                camion.setImagen2(txtImagen2.Text);
                camion.setImagen3(txtImagen3.Text);
                camion.setCampoEspecial("Toneladas: " + txtToneladas.Text);
                camion.setCarga(Convert.ToInt32(txtToneladas.Text));

                BaseDeDatos.listaVehiculos.Add(camion);
            }

            else
            {
                // Tipo de vehículo no reconocido
                Response.Write("<script>alert('Tipo de vehículo no reconocido')</script>");
                return;
            }

            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string matricula = gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();

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
        }

        protected void gvVehiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvVehiculos.EditIndex = -1;
            gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvVehiculos.EditIndex = e.NewEditIndex;
            gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvVehiculos.Rows[e.RowIndex];
            string matricula = gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();

            string marca = (filaSeleccionada.FindControl("txtMarcaGrid") as TextBox).Text;
            string modelo = (filaSeleccionada.FindControl("txtModeloGrid") as TextBox).Text;
            string imagen1 = (filaSeleccionada.FindControl("txtImagen1Grid") as TextBox).Text;
            string imagen2 = (filaSeleccionada.FindControl("txtImagen2Grid") as TextBox).Text;
            string imagen3 = (filaSeleccionada.FindControl("txtImagen3Grid") as TextBox).Text;

            Vehiculo vehiculoToUpdate = BaseDeDatos.listaVehiculos.Find(v => v.getMatricula() == matricula);

            if (vehiculoToUpdate != null)
            {
                vehiculoToUpdate.setMarca(marca);
                vehiculoToUpdate.setModelo(modelo);
                vehiculoToUpdate.setAño((filaSeleccionada.FindControl("txtAñoGrid") as TextBox).Text);
                vehiculoToUpdate.setColor((filaSeleccionada.FindControl("txtColorGrid") as TextBox).Text);
                vehiculoToUpdate.setImagen1(imagen1);
                vehiculoToUpdate.setImagen2(imagen2);
                vehiculoToUpdate.setImagen3(imagen3);

                this.gvVehiculos.EditIndex = -1;
                this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
                this.gvVehiculos.DataBind();
            }
        }

        protected void rblTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblTipoVehiculo.SelectedItem.Value == "Moto")
            {
                txtCilindradas.Visible = true;
                txtCantPasajeros.Visible = false;
                txtToneladas.Visible = false;
            }
            if (rblTipoVehiculo.SelectedItem.Value == "Auto")
            {
                txtCilindradas.Visible = false;
                txtCantPasajeros.Visible = true;
                txtToneladas.Visible = false;
            }
            if (rblTipoVehiculo.SelectedItem.Value == "Camion")
            {
                txtCilindradas.Visible = false;
                txtCantPasajeros.Visible = false;
                txtToneladas.Visible = true;
            }
        }

        protected void gvVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
