﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public abstract class BaseDeDatos
    {
        public static  List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        public static  List<Usuario> listaUsuarios = new List<Usuario>();
        public static Usuario usuarioLogeado;


        public static void CargarDatosIniciales()
        {
            Usuario usuario = new Usuario();
            usuario.setNombreUsuario("Admin");
            usuario.setContrasena("Admin");
            usuario.setVerAlquileres(true);
            usuario.setVerVentas(true);
            usuario.setVerClientes(true);
            usuario.setVerUsuarios(true);
            usuario.setVerVehiculos(true);

            listaUsuarios.Add(usuario);
        }

        public static void GuardarUsuarioLogeado(Usuario usuario)
        {
            usuarioLogeado = usuario;
        }



    }
}