using System.Collections.Generic;
using System;

namespace Obligatorio2023Prog2
{
    public partial class Login : System.Web.UI.Page
    {
        // Lista de usuarios (simulación, en una aplicación real usarías una base de datos)
        List<Usuario> listaUsuarios = new List<Usuario>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Simulación de usuarios (deberías cargar desde la base de datos)
                listaUsuarios.Add(new Usuario("pepe", "1234"));
                listaUsuarios.Add(new Usuario("juan", "4567"));

                // Enlazar la lista de usuarios al GridView
                gvUsuarios.DataSource = listaUsuarios;
                gvUsuarios.DataBind();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Depuración: verificar los valores ingresados
            System.Diagnostics.Debug.WriteLine($"Nombre de usuario: {nombreUsuario}, Contraseña: {contraseña}");

            // Realizar la validación
            if (ValidarUsuario(nombreUsuario, contraseña))
            {
                // Iniciar sesión exitosa
                Response.Write("Inicio de sesión exitoso");
            }
            else
            {
                // Iniciar sesión fallido
                Response.Write("Nombre de usuario o contraseña incorrectos");
            }
        }


        private bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            foreach (var usuario in listaUsuarios)
            {
                if (usuario.getNombre() == nombreUsuario && usuario.getContraseña() == contraseña)
                {
                    return true; // Usuario válido
                }
            }

            return false; // Usuario no válido
        }
    }
}
