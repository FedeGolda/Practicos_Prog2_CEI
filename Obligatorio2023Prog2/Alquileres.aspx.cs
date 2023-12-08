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

                // Configura el DataSource y DataBind para gvAlquileres
                gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
                gvAlquileres.DataBind();
            }
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Alquiler
            Alquiler alquiler = new Alquiler();
            alquiler.setCedula(cboClientes.SelectedItem.Value);
            alquiler.setMatricula(cboVehiculos.SelectedItem.Value);
            alquiler.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);
            alquiler.setFechaAlquiler(Convert.ToDateTime(txtFechaAlquiler.Text));
            alquiler.setDias(Convert.ToInt32(txtDias.Text));
            alquiler.setAutoDevuelto(chkDevuelto.Checked);
            alquiler.setNombreUsuario(BaseDeDatos.usuarioLogeado.NombreUsuario);

            // Obtén el precio total utilizando el método calcularPrecioAlquiler
            int precioTotal = calcularPrecioAlquiler();
            alquiler.setPrecio(precioTotal);

            // Actualiza el estado antes de agregar el alquiler a la lista
            alquiler.ActualizarEstado();

            // Agrega el alquiler a la lista
            BaseDeDatos.listaAlquileres.Add(alquiler);

            // Desactiva el vehículo en la lista de vehículos
            foreach (var vehiculo in BaseDeDatos.listaVehiculos)
            {
                if (vehiculo.getMatricula() == cboVehiculos.SelectedItem.Value)
                {
                    vehiculo.Activo = false;
                    break;
                }
            }

            // Actualiza el origen de datos del DropDownList de vehículos activos
            cboVehiculos.DataSource = BaseDeDatos.ListadoVehiculosActivos();
            cboVehiculos.DataTextField = "Matricula";
            cboVehiculos.DataBind();

            // Asigna el origen de datos y vuelve a llamar a DataBind para actualizar el GridView
            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();

            // Muestra un mensaje con el precio guardado
            Response.Write($"<script>alert('Alquiler ingresado correctamente. Precio: {alquiler.getPrecio()}')</script>");
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

            // Encuentra el alquiler en la lista
            Alquiler alquiler = BaseDeDatos.listaAlquileres.Find(a => a.Matricula == matricula);
            Vehiculo vehiculo = BaseDeDatos.listaVehiculos.Find(a => a.matricula == matricula);
            bool devuelto = (row.FindControl("chkDevueltoGrid") as CheckBox).Checked;
            vehiculo.setActivo(devuelto);

            // Actualiza las propiedades
            string nuevosDias = (row.FindControl("txtDiasGrid") as TextBox)?.Text;
            string nuevoPrecio = (row.FindControl("txtPrecioGrid") as TextBox)?.Text;
            alquiler.Dias = Convert.ToInt32(nuevosDias);
            alquiler.Precio = Convert.ToInt32(nuevoPrecio);

            // Actualiza el estado directamente
            alquiler.ActualizarEstado();

            // Limpia el índice de edición después de la actualización
            gvAlquileres.EditIndex = -1;
            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }


        protected void gvAlquileres_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Lógica para eliminar una fila en la lista de alquileres
            // Puedes acceder a los valores de la fila que se está eliminando utilizando e.RowIndex

            GridViewRow row = gvAlquileres.Rows[e.RowIndex];
            string matricula = gvAlquileres.DataKeys[e.RowIndex].Values["Matricula"].ToString();

            // Eliminar la fila de la lista o de la base de datos
            // ...

            gvAlquileres.DataSource = BaseDeDatos.listaAlquileres;
            gvAlquileres.DataBind();
        }


        protected void txtAlquilerDia_TextChanged(object sender, EventArgs e)
        {
            calcularPrecioAlquiler();
        }

        public int calcularPrecioAlquiler()
        {
            if (!string.IsNullOrEmpty(txtFechaAlquiler.Text) && !string.IsNullOrEmpty(lblPrecio.Text))
            {
                // Obtiene la cantidad de días y el precio por día
                int dias = Convert.ToInt32(txtDias.Text);
                int precioPorDia = Convert.ToInt32(lblPrecio.Text);

                // Realiza el cálculo del precio total
                int precioTotal = dias * precioPorDia;

                return precioTotal;
            }

            return 0; // Otra opción sería lanzar una excepción si no se cumplen las condiciones necesarias.
        }


        protected void chkDevueltoGrid_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkDevueltoGrid = sender as CheckBox;
            GridViewRow row = chkDevueltoGrid.NamingContainer as GridViewRow;
            int rowIndex = row.RowIndex;

            // Accede al alquiler correspondiente en la lista y actualiza el estado AutoDevuelto
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


    }
}