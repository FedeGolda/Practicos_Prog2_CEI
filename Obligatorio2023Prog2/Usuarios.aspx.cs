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
            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = txtNombreUsuario.Text,
                Contrasena = txtContrasena.Text
            };

            BaseDeDatos.listaUsuarios.Add(nuevoUsuario);

            CargarUsuarios();

            LimpiarCampos();
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
                string nuevoNombreUsuario = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("txtNombreUsuarioGrid")).Text;
                string nuevaContrasena = ((TextBox)gvUsuarios.Rows[e.RowIndex].FindControl("txtContrasenaGrid")).Text;

                // Busca el usuario en la lista de usuarios y actualiza sus datos
                string nombreUsuarioOriginal = gvUsuarios.DataKeys[e.RowIndex].Values["NombreUsuario"].ToString();
                Usuario usuarioAActualizar = BaseDeDatos.listaUsuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuarioOriginal);

                if (usuarioAActualizar != null)
                {
                    // Actualiza los datos del usuario
                    usuarioAActualizar.NombreUsuario = nuevoNombreUsuario;
                    usuarioAActualizar.Contrasena = nuevaContrasena;
                    // Actualiza otros campos según sea necesario

                    // Desactiva el modo de edición y vuelve a cargar los usuarios
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

        protected void rblPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblPermisos.SelectedItem.Value == "VerUsuarios")
            {
                VerUsuarios.Visible = false;
                VerClientes.Visible = true;
                VerVentas.Visible = true;
                VerAlquileres.Visible = true;
                VerVehiculos.Visible = true;
            }
        }

    }
}
