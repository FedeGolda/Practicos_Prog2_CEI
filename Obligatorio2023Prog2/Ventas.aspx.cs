using Obligatorio2023Prog2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                cboVehiculos.DataSource = BaseDeDatos.listaVehiculos;
                cboVehiculos.DataTextField = "Matricula";
                cboVehiculos.DataBind();

                cboCleintes.DataSource = BaseDeDatos.listaClientes;
                cboCleintes.DataTextField = "Cedula";
                cboCleintes.DataBind();
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string Cedula = cboCleintes.SelectedItem.Value;

            string Matricula = cboVehiculos.SelectedValue;

        }

        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
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
