using Obligatorio2023Prog2.Clases;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Obligatorio2023Prog2
{
    public partial class Usuarios : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogeado.getVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogeado.getVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogeado.getVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogeado.getVerAlquileres();
            Master.FindControl("lnkUsuarios").Visible = BaseDeDatos.usuarioLogeado.getVerUsuarios();

            if (!IsPostBack)
            {
                CargarUsuarios();
            }
        }

        protected void CargarUsuarios()
        {
            gvUsuarios.DataSource = BaseDeDatos.listaUsuarios;
            gvUsuarios.DataBind();
        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo usuario y asignar los valores
                Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.setNombreUsuario(txtNombreUsuario.Text);
                nuevoUsuario.setContrasena(txtContrasena.Text);

                // Obtener los valores seleccionados del CheckBoxList
                foreach (ListItem item in cblPermisos.Items)
                {
                    if (item.Selected)
                    {
                        switch (item.Value)
                        {
                            case "VerClientes":
                                nuevoUsuario.setVerClientes(true);
                                break;
                            case "VerUsuarios":
                                nuevoUsuario.setVerUsuarios(true);
                                break;
                            case "VerVentas":
                                nuevoUsuario.setVerVentas(true);
                                break;
                            case "VerVehiculos":
                                nuevoUsuario.setVerVehiculos(true);
                                break;
                            case "VerAlquileres":
                                nuevoUsuario.setVerAlquileres(true);
                                break;
                        }
                    }
                }

                // Verificar si los TextBox están vacíos
                if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    lblMensajeError.Text = "Todos los campos son obligatorios. Complete la información.";
                    return;
                }

                // Agregar el usuario a la lista
                BaseDeDatos.listaUsuarios.Add(nuevoUsuario);

                // Limpiar campos y recargar la GridView
                LimpiarCampos();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                Response.Write($"Error al guardar el usuario: {ex.Message}");
            }
        }


        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContrasena.Text = "";
        }

        protected void gvUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvUsuarios.EditIndex = -1;
            CargarUsuarios();  // Vuelve a cargar los datos después de cancelar la edición
        }

        protected void gvUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // Obtén el valor de la clave primaria para el elemento que se está eliminando
                string nombreUsuario = gvUsuarios.DataKeys[e.RowIndex].Values["NombreUsuario"].ToString();

                // Busca el usuario en la lista de usuarios y elimínalo
                Usuario usuarioAEliminar = BaseDeDatos.listaUsuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

                if (usuarioAEliminar != null)
                {
                    BaseDeDatos.listaUsuarios.Remove(usuarioAEliminar);

                    // Vuelve a cargar los usuarios después de la eliminación
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la eliminación
                // Puedes personalizar esto según tus necesidades, por ejemplo, mostrar un mensaje de error.
                Response.Write($"Error al eliminar el usuario: {ex.Message}");
            }
        }

        protected void gvUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Establece el índice de edición y vuelve a cargar los usuarios
            gvUsuarios.EditIndex = e.NewEditIndex;
            CargarUsuarios();
        }

        protected void gvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                // Obtén los nuevos valores desde los controles de edición
                bool nuevaVerClientes = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerClientesGrid")).Checked;
                bool nuevaVerVentas = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerVentasGrid")).Checked;
                bool nuevaVerVehiculos = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerVehiculosGrid")).Checked;
                bool nuevaVerAlquileres = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerAlquileresGrid")).Checked;
                bool nuevaVerUsuarios = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerUsuariosGrid")).Checked;




                // Busca el usuario en la lista de usuarios y actualiza sus datos
                string nombreUsuarioOriginal = gvUsuarios.DataKeys[e.RowIndex].Values["NombreUsuario"].ToString();
                Usuario usuarioActualizar = BaseDeDatos.listaUsuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuarioOriginal);

                if (usuarioActualizar != null)
                {
                    // Actualiza los datos del usuario
                    usuarioActualizar.VerClientes = nuevaVerClientes;
                    usuarioActualizar.VerVentas = nuevaVerVentas;
                    usuarioActualizar.VerVehiculos = nuevaVerVehiculos;
                    usuarioActualizar.VerAlquileres = nuevaVerAlquileres;
                    usuarioActualizar.VerUsuarios = nuevaVerUsuarios;

                    gvUsuarios.EditIndex = -1;
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la actualización
                Response.Write($"Error al actualizar el usuario: {ex.Message}");
            }
        }


    }
}
