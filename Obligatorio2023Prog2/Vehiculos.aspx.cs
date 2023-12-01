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

            // Validar y convertir los valores a los tipos adecuados
            if (string.IsNullOrEmpty(txtImagen1.Text) || string.IsNullOrEmpty(txtImagen2.Text) || string.IsNullOrEmpty(txtImagen3.Text))
            {
                Response.Write("<script>alert('Debe ingresar las 3 imágenes')</script>");
            }
            else
            {
                vehiculo.setImagen1(txtImagen1.Text);
                vehiculo.setImagen2(txtImagen2.Text);
                vehiculo.setImagen3(txtImagen3.Text);

                BaseDeDatos.listaVehiculos.Add(vehiculo);

                this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
                this.gvVehiculos.DataBind();
            }
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

            string imagen1 = (filaSeleccionada.FindControl("txtImagen1Grid") as TextBox).Text;
            string imagen2 = (filaSeleccionada.FindControl("txtImagen2Grid") as TextBox).Text;
            string imagen3 = (filaSeleccionada.FindControl("txtImagen3Grid") as TextBox).Text;

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == matricula)
                {
                    vehiculo.setMarca(marca);
                    vehiculo.setModelo(modelo);
                    vehiculo.setImagen1(imagen1);
                    vehiculo.setImagen2(imagen2);
                    vehiculo.setImagen3(imagen3);
                }
            }

            this.gvVehiculos.EditIndex = -1;
            this.gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            this.gvVehiculos.DataBind();

        }
    }
}
