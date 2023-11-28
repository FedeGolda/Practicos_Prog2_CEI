using Obligatorio2023Prog2.Clases;
using System;
using System.Web.UI;

namespace Obligatorio2023Prog2
{
    public partial class Alquileres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                cboClientes.DataSource = BaseDeDatos.listaClientes;
                cboClientes.DataTextField = "Cedula";
                cboClientes.DataBind();
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

        protected void txtAlquilerDia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAlquilerDia.Text))
            {
                int dias = Convert.ToInt32(txtAlquilerDia.Text);

                // Obtén el precio por día directamente desde el DropDownList cboVehiculos
                double precioAlquilerDia = Convert.ToDouble(cboVehiculos.SelectedItem.Text);

                // Calcula el precio total multiplicando el número de días por el precio por día del vehículo
                double precioTotal = dias * precioAlquilerDia;

                // Muestra el precio total en el Label correspondiente
                lblPrecio.Text = precioTotal.ToString();

                // Haz visible el Label que muestra el precio
                lblPrecioSimbolo.Visible = true;
                lblPrecio.Visible = true;
            }
            else
            {
                // Si el TextBox está vacío, oculta los Labels
                lblPrecioSimbolo.Visible = false;
                lblPrecio.Visible = false;
            }
        }
    }
}