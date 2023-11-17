using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestObligatorioP2.Clases;

namespace TestObligatorioP2
{
    public partial class Vehiculos2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Matricula = txtMatricula.Text;
            vehiculo.Marca = txtMarca.Text;
            vehiculo.Modelo = txtModelo.Text;

            BaseDeDatos.listaVehiculos.Add( vehiculo );

            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();
        }

        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string matricula = this.gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString(); 

            foreach(var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if(vehiculo.Matricula == matricula)
                {
                    BaseDeDatos.listaVehiculos.Remove( vehiculo );
                    break;
                }
            }

            this.gvVehiculos.EditIndex = -1;
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
                if (vehiculo.Matricula == matricula)
                {
                    vehiculo.Marca = marca;
                    vehiculo.Modelo = modelo;
                }
            }

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
    }
}