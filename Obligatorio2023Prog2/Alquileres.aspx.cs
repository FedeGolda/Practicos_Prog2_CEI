using Obligatorio2023Prog2.Clases;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Alquileres : System.Web.UI.Page
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
                cboClientes.DataSource = BaseDeDatos.listaClientes;
                cboClientes.DataTextField = "DatosMostrar";
                cboClientes.DataValueField = "Cedula";
                cboClientes.DataBind();

                cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                cboVehiculos.DataTextField = "DatosMostrar";
                cboVehiculos.DataValueField = "Matricula";
                cboVehiculos.DataBind();

                if (cboVehiculos.SelectedItem != null)
                {
                    string Matricula = cboVehiculos.SelectedItem.Value;

                    foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                    {
                        if (vehiculo.getMatricula() == Matricula)
                        {
                            lblPrecio.Text = vehiculo.getPrecioAlquilerDia().ToString();
                            lblPrecio.Visible = true;
                            lblPrecioSimbolo.Visible = true;
                        }
                    }
                }

                gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
                gvAlquileres.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDias.Text))
            {
                if (int.TryParse(txtDias.Text, out int dias))
                {
                    Alquiler alquiler = new Alquiler();
                    alquiler.setCedula(cboClientes.SelectedItem.Value);
                    alquiler.setMatricula(cboVehiculos.SelectedItem.Value);
                    alquiler.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);
                    alquiler.setDias(dias);
                    alquiler.setAutoDevuelto(chkDevuelto.Checked);
                    alquiler.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);

                    int precioTotal = calcularPrecioAlquiler();
                    alquiler.setPrecio(precioTotal);

                    alquiler.ActualizarEstado();

                    DateTime fechaAlquiler;
                    if (DateTime.TryParse(txtFechaAlquiler.Text, out fechaAlquiler))
                    {
                        alquiler.setFechaAlquiler(fechaAlquiler);

                        foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                        {
                            if (vehiculo.getMatricula() == cboVehiculos.SelectedItem.Value)
                            {
                                vehiculo.Activo = false;
                                break;
                            }
                        }

                        if (fechaAlquiler != DateTime.MinValue)
                        {
                            BaseDeDatos.listaAlquileres.Add(alquiler);

                            lblMensaje.Text = "Alquiler ingresado correctamente";
                            lblMensaje.ForeColor = System.Drawing.Color.Green;
                            lblMensaje.Visible = true;

                            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
                            gvAlquileres.DataBind();
                        }
                        else
                        {
                            lblMensaje.Text = "La fecha de alquiler no puede ser nula";
                            lblMensaje.ForeColor = System.Drawing.Color.Red;
                            lblMensaje.Visible = true;
                        }
                    }
                    else
                    {
                        lblMensaje.Text = "Fecha de alquiler no válida";
                        lblMensaje.ForeColor = System.Drawing.Color.Red;
                        lblMensaje.Visible = true;
                    }
                }
                else
                {
                    lblMensaje.Text = "Por favor, ingrese un valor válido para los días.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Visible = true;
                }
            }
            else
            {
                lblMensaje.Text = "Por favor, ingrese la cantidad de días.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
            }
        }

        protected void gvAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Matricula = cboVehiculos.SelectedItem.Value;

            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == Matricula)
                {
                    lblPrecio.Text = vehiculo.getPrecioAlquilerDia().ToString();
                    lblPrecio.Visible = true;
                    lblPrecioSimbolo.Visible = true;
                }
            }
        }

        protected void gvAlquileres_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvAlquileres.EditIndex = -1;
            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }

        protected void gvAlquileres_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvAlquileres.EditIndex = e.NewEditIndex;
            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }

        protected void gvAlquileres_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvAlquileres.Rows[e.RowIndex];
            string matricula = gvAlquileres.DataKeys[e.RowIndex].Values["Matricula"].ToString();

            Alquiler alquiler = BaseDeDatos.listaAlquileres.Find(a => a.Matricula == matricula);
            Vehiculo vehiculo = BaseDeDatos.listaVehiculos.Find(a => a.matricula == matricula);
            bool devuelto = (row.FindControl("chkDevueltoGrid") as CheckBox).Checked;
            vehiculo.setActivo(devuelto);

            string nuevosDias = (row.FindControl("txtDiasGrid") as TextBox)?.Text;
            string nuevoPrecio = (row.FindControl("txtPrecioGrid") as TextBox)?.Text;
            alquiler.Dias = Convert.ToInt32(nuevosDias);
            alquiler.Precio = Convert.ToInt32(nuevoPrecio);

            alquiler.ActualizarEstado();

            gvAlquileres.EditIndex = -1;
            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }

        protected void gvAlquileres_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvAlquileres.Rows[e.RowIndex];
            string matricula = gvAlquileres.DataKeys[e.RowIndex].Values["Matricula"].ToString();

            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }

        protected void txtAlquilerDia_TextChanged(object sender, EventArgs e)
        {
            calcularPrecioAlquiler();
        }

        public int calcularPrecioAlquiler()
        {
            if (!string.IsNullOrEmpty(txtFechaAlquiler.Text) && !string.IsNullOrEmpty(txtDias.Text) && !string.IsNullOrEmpty(lblPrecio.Text))
            {
                int dias = Convert.ToInt32(txtDias.Text);
                int precioPorDia = Convert.ToInt32(lblPrecio.Text);

                int precioTotal = dias * precioPorDia;

                return precioTotal;
            }

            return 0;
        }

        protected void chkDevueltoGrid_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkDevueltoGrid = sender as CheckBox;
            GridViewRow row = chkDevueltoGrid.NamingContainer as GridViewRow;
            int rowIndex = row.RowIndex;

            BaseDeDatos.listaAlquileres[rowIndex].AutoDevuelto = chkDevueltoGrid.Checked;
        }

        protected void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matricula = cboVehiculos.SelectedValue;

            Vehiculo vehiculo = BaseDeDatos.listaVehiculos.Find(v => v.getMatricula() == matricula);

            if (vehiculo != null)
            {
                lblPrecio.Text = vehiculo.getPrecioAlquilerDia().ToString();
                lblPrecio.Visible = true;
                lblPrecioSimbolo.Visible = true;
            }
            else
            {
                lblPrecio.Text = string.Empty;
                lblPrecio.Visible = false;
                lblPrecioSimbolo.Visible = false;
            }
        }
    }
}
