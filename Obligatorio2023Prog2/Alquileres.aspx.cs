using Obligatorio2023Prog2.Clases;
using System;
using System.Linq;
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
                // Data binding for cboClientes
                cboClientes.DataSource = BaseDeDatos.listaClientes;
                cboClientes.DataTextField = "DatosMostrar";
                cboClientes.DataValueField = "Cedula";
                cboClientes.DataBind();

                // Data binding for cboVehiculos
                cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                cboVehiculos.DataTextField = "DatosMostrar";
                cboVehiculos.DataValueField = "Matricula";
                cboVehiculos.DataBind();

                // Check if there is a selected item in cboVehiculos
                if (cboVehiculos.SelectedItem != null)
                {
                    string Matricula = cboVehiculos.SelectedItem.Value;

                    // Find the vehicle and update lblPrecio
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

                // Data binding for gvAlquileres
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

                        // Validar si ya existe un alquiler con la misma combinación de cliente y vehículo
                        if (ExisteAlquiler(alquiler))
                        {
                            lblMensaje.Text = "Ya existe un alquiler registrado para este cliente y vehículo.";
                            lblMensaje.ForeColor = System.Drawing.Color.Red;
                            lblMensaje.Visible = true;
                            return;
                        }

                        foreach (var vehiculo in BaseDeDatos.listaVehiculos)
                        {
                            if (vehiculo.getMatricula() == cboVehiculos.SelectedItem.Value)
                            {
                                // Actualizar el estado antes de obtener la lista activa
                                vehiculo.Activo = false;
                                break;
                            }
                        }

                        // Obtener la lista de vehículos activos después de la actualización
                        cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                        cboVehiculos.DataTextField = "DatosMostrar";
                        cboVehiculos.DataValueField = "Matricula";
                        cboVehiculos.DataBind();

                        if (fechaAlquiler != DateTime.MinValue)
                        {
                            BaseDeDatos.listaAlquileres.Add(alquiler);

                            // Actualizar cboVehiculos después de agregar el alquiler
                            cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                            cboVehiculos.DataTextField = "DatosMostrar";
                            cboVehiculos.DataValueField = "Matricula";
                            cboVehiculos.DataBind();

                            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
                            gvAlquileres.DataBind();

                            lblMensaje.Text = "Alquiler ingresado correctamente";
                            lblMensaje.ForeColor = System.Drawing.Color.Green;
                            lblMensaje.Visible = true;
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

            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            this.gvAlquileres.DataBind();

            // Redirigir para refrescar la página
            Response.Redirect(Request.RawUrl);
        }

        protected void gvAlquileres_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Obtén la Matricula de la fila que se va a eliminar
            string matricula = gvAlquileres.DataKeys[e.RowIndex].Values["Matricula"].ToString();

            // Encuentra el alquiler que corresponde a la Matricula
            Alquiler alquiler = BaseDeDatos.listaAlquileres.Find(a => a.Matricula == matricula);

            // Asegúrate de que se encontró el alquiler antes de intentar eliminar
            if (alquiler != null)
            {
                // Elimina el alquiler de la lista
                BaseDeDatos.listaAlquileres.Remove(alquiler);
                /*
                // Encuentra el vehículo asociado y márcalo como activo
                Vehiculo vehiculoAsociado = BaseDeDatos.listaVehiculos.Find(v => v.getMatricula() == matricula);
                if (vehiculoAsociado != null)
                {
                    vehiculoAsociado.Activo = true;
                }
                */

                // Actualiza la lista de vehículos activos y la vista del GridView
                cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
                cboVehiculos.DataTextField = "DatosMostrar";
                cboVehiculos.DataValueField = "Matricula";
                cboVehiculos.DataBind();

                gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
                gvAlquileres.DataBind();
            }
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

            // Busca el vehículo en la lista y muestra el precio del alquiler
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

        private bool ExisteAlquiler(Alquiler nuevoAlquiler)
        {
            // Verificar si ya existe un alquiler con la misma combinación de cliente y vehículo
            return BaseDeDatos.listaAlquileres.Any(a => a.getCedula() == nuevoAlquiler.getCedula() && a.getMatricula() == nuevoAlquiler.getMatricula());
        }
    }
}
