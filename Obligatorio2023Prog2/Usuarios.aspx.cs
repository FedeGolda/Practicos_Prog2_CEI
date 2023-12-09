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

                // Verificar si el nombre de usuario ya existe en la lista
                if (BaseDeDatos.listaUsuarios.Any(u => u.NombreUsuario == nuevoUsuario.getNombreUsuario()))
                {
                    lblMensaje.Text = "El nombre de usuario ya existe. Por favor, elige otro.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;  // Establecer el color del texto en rojo
                    return;
                }

                // Obtener los valores seleccionados del CheckBoxList
                foreach (ListItem item in cblPermisos.Items)
                {
                    if (item.Selected)
                    {
                        // Asignar permisos según la selección
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
                    lblMensaje.Text = "Todos los campos son obligatorios. Complete la información.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;  // Establecer el color del texto en rojo
                    return;
                }

                // Agregar el usuario a la lista si no existe
                BaseDeDatos.listaUsuarios.Add(nuevoUsuario);

                // Limpiar campos y recargar la GridView
                LimpiarCampos();
                CargarUsuarios();

                // Mostrar mensaje de confirmación en verde
                lblMensaje.Text = "Usuario registrado correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;  // Establecer el color del texto en verde
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                lblMensaje.Text = $"Error al guardar el usuario: {ex.Message}";
                lblMensaje.ForeColor = System.Drawing.Color.Red;  // Establecer el color del texto en rojo
            }
        }




        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContrasena.Text = "";
        }

        protected void gvUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            lblMensaje.Text = "";
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
            lblMensaje.Text = "";  // Limpiar el mensaje al cargar la página
            // Establece el índice de edición y vuelve a cargar los usuarios
            gvUsuarios.EditIndex = e.NewEditIndex;
            gvUsuarios.DataSource = BaseDeDatos.listaUsuarios;
            CargarUsuarios();
        }

        protected void gvUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                // Obtén los nuevos valores desde los controles de edición
                string nuevoNombreUsuario = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("txtNombreUsuarioGrid")).Text;
                string nuevaContrasena = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("txtContrasenaGrid")).Text;
                bool nuevaVerClientes = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerClientesGrid")).Checked;
                bool nuevaVerVentas = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerVentasGrid")).Checked;
                bool nuevaVerVehiculos = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerVehiculosGrid")).Checked;
                bool nuevaVerAlquileres = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerAlquileresGrid")).Checked;
                bool nuevaVerUsuarios = ((CheckBox)gvUsuarios.Rows[e.RowIndex].FindControl("chkVerUsuariosGrid")).Checked;

                // Busca el usuario en la lista de usuarios y verifica si el nuevo nombre ya existe
                string nombreUsuarioOriginal = gvUsuarios.DataKeys[e.RowIndex].Values["NombreUsuario"].ToString();
                Usuario usuarioActualizar = BaseDeDatos.listaUsuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuarioOriginal);

                if (usuarioActualizar != null)
                {
                    // Verifica si el nuevo nombre de usuario ya existe en la lista
                    if (BaseDeDatos.listaUsuarios.Any(u => u.NombreUsuario == nuevoNombreUsuario && u != usuarioActualizar))
                    {
                        // El nuevo nombre de usuario ya existe, muestra un mensaje de error
                        lblMensaje.Text = "El nombre de usuario ya existe. Por favor, elige otro.";
                        return;
                    }

                    // Almacena temporalmente la contraseña
                    string contraseñaTemporal = usuarioActualizar.getContrasena();

                    // Actualiza los datos del usuario
                    usuarioActualizar.setNombreUsuario(nuevoNombreUsuario);
                    usuarioActualizar.setContrasena(nuevaContrasena); // Asigna la nueva contraseña

                    // Restaura la contraseña original
                    if (string.IsNullOrEmpty(nuevaContrasena))
                    {
                        usuarioActualizar.setContrasena(contraseñaTemporal);
                    }

                    usuarioActualizar.VerClientes = nuevaVerClientes;
                    usuarioActualizar.VerVentas = nuevaVerVentas;
                    usuarioActualizar.VerVehiculos = nuevaVerVehiculos;
                    usuarioActualizar.VerAlquileres = nuevaVerAlquileres;
                    usuarioActualizar.VerUsuarios = nuevaVerUsuarios;

                    gvUsuarios.EditIndex = -1;
                    CargarUsuarios();
                    lblMensaje.Text = "";  // Limpiar el mensaje al cargar la página
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
