using Obligatorio2023Prog2.Clases;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Ventas : System.Web.UI.Page
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
                // Mostrar el nombre de usuario
                lblNombreUsuario.Text = BaseDeDatos.usuarioLogeado.NombreUsuario;

                cboClientes.DataSource = BaseDeDatos.listaClientes;
                cboClientes.DataTextField = "DatosMostrar";
                cboClientes.DataValueField = "Cedula";
                cboClientes.DataBind();

                cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                cboVehiculos.DataTextField = "DatosMostrar";
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                // Verifica si esta vacio cboVehiculos, que muestre
                if (cboVehiculos.SelectedItem != null)
                {
                    string Matricula = cboVehiculos.SelectedItem.Value;

                    foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                    {
                        if (vehiculo.getMatricula() == Matricula)
                        {
                            lblPrecio.Text = vehiculo.getPrecioVenta().ToString();
                            lblPrecio.Visible = true;
                            lblPrecioSimbolo.Visible = true;
                        }
                    }
                }

                // Configura el DataSource y DataBind para gvAlquileres
                gridVentas.DataSource = BaseDeDatos.listaVentas;
                gridVentas.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            // Verificar si cboClientes es nulo
            if (cboClientes.SelectedItem == null)
            {
                lblMensaje.Text = "No hay clientes seleccionados para vender";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
                return; // Sale del método para evitar procesamiento adicional
            }

            // Verificar si cboVehiculos es nulo
            if (cboVehiculos.SelectedItem == null)
            {
                lblMensaje.Text = "No hay vehículos seleccionados para vender";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
                return; // Sale del método para evitar procesamiento adicional
            }

            Venta venta = new Venta();
            venta.setCedula(cboClientes.SelectedItem.Value);
            venta.setMatricula(cboVehiculos.SelectedItem.Value);
            venta.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);

            // Verificar si la fecha es válida antes de intentar convertirla
            DateTime fechaVenta;
            if (DateTime.TryParse(txtFecha.Text, out fechaVenta))
            {
                venta.setFechaVenta(fechaVenta);

                int precio;
                if (int.TryParse(lblPrecio.Text, out precio))
                {
                    venta.setPrecio(precio);
                }

                BaseDeDatos.listaVentas.Add(venta);

                foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                {
                    if (vehiculo.getMatricula() == cboVehiculos.SelectedItem.Value)
                    {
                        vehiculo.Activo = false;
                        break;
                    }
                }

                // Vuelve a enlazar el GridView después de agregar la venta
                cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                gridVentas.DataSource = BaseDeDatos.listaVentas;
                gridVentas.DataBind();

                lblMensaje.Text = "Venta ingresada correctamente";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Visible = true;
            }
            else
            {
                // Manejar el caso en el que la fecha no es válida
                lblMensaje.Text = "Fecha de venta no válida";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
            }
        }


        protected void cboVehiculos_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == Matricula)
                {
                    lblPrecio.Text = vehiculo.getPrecioVenta().ToString();
                    lblPrecio.Visible = true;
                    lblPrecioSimbolo.Visible = true;
                }
            }
        }

    }
}
