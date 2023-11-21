using System.Collections.Generic;
using System;
using Obligatorio2023Prog2.Clases;

namespace Obligatorio2023Prog2
{
    public partial class Login : System.Web.UI.Page
    {
        // Lista de usuarios
        List<Usuario> listaUsuarios = new List<Usuario>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkHome").Visible = false;
            Master.FindControl("lnkAbout").Visible = false;
            Master.FindControl("lnkVehiculos").Visible = false;
            Master.FindControl("lnkVentas").Visible = false;
            Master.FindControl("lnkAlquileres").Visible = false;
            Master.FindControl("lnkUsuarios").Visible = false;

            if(!Page.IsPostBack)
            {
                BaseDeDatos.CargarDatosIniciales();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginCorrecto = false;
            foreach (var usuario in listaUsuarios)
            {
                if (usuario.getNombre() == txtUsuario.Text && usuario.getContraseña() == txtContraseña.Text)
                {
                    BaseDeDatos.usuarioLogeado = usuario;
                    Response.Redirect("Vehiculos.aspx");
                    loginCorrecto = true;
                }
            }
            if (!loginCorrecto)
            {
                lblError.Visible = true;
                Response.Write("<script>alert('usuario y/o contraseña incorrectos')</script>");
            }
        }
    }
}
