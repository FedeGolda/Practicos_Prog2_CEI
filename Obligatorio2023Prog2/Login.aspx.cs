﻿using System.Collections.Generic;
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
                    if (BaseDeDatos.usuarioLogeado.getVerVehiculos())
                        Response.Redirect("Vehiculos.aspx");

                    if (BaseDeDatos.usuarioLogeado.getVerUsuarios())
                        Response.Redirect("Usuarios.aspx");

                    if (BaseDeDatos.usuarioLogeado.getVerClientes())
                        Response.Redirect("Clientes.aspx");

                    if (BaseDeDatos.usuarioLogeado.getVerVentas())
                        Response.Redirect("Ventas.aspx");

                    if (BaseDeDatos.usuarioLogeado.getVerAlquileres())
                        Response.Redirect("Alquileres.aspx");

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