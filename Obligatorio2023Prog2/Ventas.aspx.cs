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
                lblNombreUsuario.Text = "Usuario: " + BaseDeDatos.usuarioLogeado.NombreUsuario;

                cboClientes.DataSource = BaseDeDatos.listaClientes;
                cboClientes.DataTextField = "DatosMostrar";
                cboClientes.DataValueField = "Cedula";
                cboClientes.DataBind();

                cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                cboVehiculos.DataTextField = "DatosMostrar";
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                gridVentas.DataSource = BaseDeDatos.listaVentas;
                gridVentas.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.setCedula(cboClientes.SelectedItem.Value);
            venta.setMatricula(cboVehiculos.SelectedItem.Value);
            venta.setFechaVenta(DateTime.Now);
            venta.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);

            int precio;
            if (int.TryParse(lblPrecio.Text, out precio))
            {
                venta.setPrecio(precio);
            }
            venta.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);

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

            Response.Write("<script>alert('Venta ingresada correctamente')</script>");
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
