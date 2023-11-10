using Obligatorio2023Prog2.Clases;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridVehiculos();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string matricula = txtMatricula.Text.Trim();
                string marca = txtMarca.Text.Trim();
                string modelo = txtModelo.Text.Trim();

                if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
                {
                    throw new ApplicationException("Todos los campos son obligatorios.");
                }

                Vehiculo vehiculo = new Vehiculo
                {
                    Matricula = matricula,
                    Marca = marca,
                    Modelo = modelo
                };

                BaseDeDatos.listaVehiculos.Add(vehiculo);

                CargarGridVehiculos();

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarMensajeError("Error al guardar el vehículo: " + ex.Message);
            }
        }

        protected void gvVehiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvVehiculos.EditIndex = -1;
            CargarGridVehiculos();
        }

        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string matricula = gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();

                foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                {
                    if (vehiculo.Matricula == matricula)
                    {
                        BaseDeDatos.listaVehiculos.Remove(vehiculo);
                        break;
                    }
                }

                gvVehiculos.EditIndex = -1;
                CargarGridVehiculos();
            }
            catch (Exception ex)
            {
                MostrarMensajeError("Error al eliminar el vehículo: " + ex.Message);
            }
        }

        protected void gvVehiculos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = gvVehiculos.Rows[e.RowIndex];

                string matricula = gvVehiculos.DataKeys[e.RowIndex].Values[0].ToString();
                string marca = (row.FindControl("txtMarcaGrid") as TextBox).Text;
                string modelo = (row.FindControl("txtModeloGrid") as TextBox).Text;

                foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                {
                    if (vehiculo.Matricula == matricula)
                    {
                        vehiculo.Marca = marca;
                        vehiculo.Modelo = modelo;
                        break;
                    }
                }

                gvVehiculos.EditIndex = -1;
                CargarGridVehiculos();
            }
            catch (Exception ex)
            {
                MostrarMensajeError("Error al actualizar el vehículo: " + ex.Message);
            }
        }

        private void CargarGridVehiculos()
        {
            gvVehiculos.DataSource = BaseDeDatos.listaVehiculos;
            gvVehiculos.DataBind();
        }

        private void LimpiarCampos()
        {
            txtMatricula.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
        }

        protected void MostrarMensajeError(string mensaje)
        {
            lblMensajeError.Text = $"<span style='color:red'>{mensaje}</span>";
        }
    }
}
