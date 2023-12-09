using System.Collections.Generic;
using System;
using Obligatorio2023Prog2.Clases;

namespace Obligatorio2023Prog2
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkClientes").Visible = false;
            Master.FindControl("lnkVehiculos").Visible = false;
            Master.FindControl("lnkVentas").Visible = false;
            Master.FindControl("lnkAlquileres").Visible = false;
            Master.FindControl("lnkUsuarios").Visible = false;
            Master.FindControl("lnkSalir").Visible = false;

            if (!Page.IsPostBack)
            {
                if (BaseDeDatos.listaUsuarios.Count == 0)
                    BaseDeDatos.CargarDatosIniciales();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            bool loginCorrecto = false;
            foreach (var usuario in BaseDeDatos.listaUsuarios)
            {
                if (usuario.getNombreUsuario() == txtUsuario.Text && usuario.getContrasena() == txtContrasena.Text)
                {
                    BaseDeDatos.GuardarUsuarioLogeado(usuario);

                    if (usuario.TieneAlgunPermiso())
                    {
                        // Redirige a la página según los permisos del usuario
                        if (usuario.getVerVehiculos())
                            Response.Redirect("Vehiculos.aspx");
                        else if (usuario.getVerUsuarios())
                            Response.Redirect("Usuarios.aspx");
                        else if (usuario.getVerClientes())
                            Response.Redirect("Clientes.aspx");
                        else if (usuario.getVerVentas())
                            Response.Redirect("Ventas.aspx");
                        else if (usuario.getVerAlquileres())
                            Response.Redirect("Alquileres.aspx");
                    }
                    else
                    {
                        // El usuario no tiene ningún permiso, muestra un mensaje de error
                        lblError.Text = "El usuario no tiene permisos para acceder al sistema.";
                        lblError.Visible = true;
                    }

                    loginCorrecto = true;
                }
            }
            if (!loginCorrecto)
            {
                lblError.Text = "Credenciales incorrectas. Inténtelo de nuevo.";
                lblError.Visible = true;
            }
        }

    }
}