﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2.Clases
{
    public abstract class BaseDeDatos
    {
        public static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        public static List<Cliente> listaClientes = new List<Cliente>();
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static Usuario usuarioLogeado;

        public static void CargarDatosIniciales()
        {
            // Agregar un usuario administrador
            Usuario usuario = new Usuario();
            usuario.setNombreUsuario("Admin");
            usuario.setContrasena("Admin");
            usuario.setVerAlquileres(true);
            usuario.setVerVentas(true);
            usuario.setVerClientes(true);
            usuario.setVerUsuarios(true);
            usuario.setVerVehiculos(true);
            listaUsuarios.Add(usuario);

            // Agregar clientes
            Cliente cliente1 = new Cliente();
            cliente1.setId(1);
            cliente1.setNombre("Pepe");
            cliente1.setApellido("Gonzalez");
            cliente1.setCedula("1.111.111-1");
            listaClientes.Add(cliente1);

            // Agregar vehículos
            Vehiculo vehiculo1 = new Vehiculo("Toyota", "Corolla", "ABC123", "2022", 5000, "Rojo", 25000, 100);
            Vehiculo vehiculo2 = new Vehiculo("Ford", "Focus", "DEF456", "2021", 8000, "Azul", 22000, 80);
            Vehiculo vehiculo3 = new Vehiculo("Honda", "Civic", "GHI789", "2020", 10000, "Negro", 20000, 90);
            Vehiculo vehiculo4 = new Vehiculo("Chevrolet", "Cruze", "JKL012", "2022", 6000, "Blanco", 23000, 95);
            Vehiculo vehiculo5 = new Vehiculo("Nissan", "Sentra", "MNO345", "2023", 3000, "Gris", 27000, 110);

            listaVehiculos.Add(vehiculo1);
            listaVehiculos.Add(vehiculo2);
            listaVehiculos.Add(vehiculo3);
            listaVehiculos.Add(vehiculo4);
            listaVehiculos.Add(vehiculo5);
        }


        public static void GuardarUsuarioLogeado(Usuario usuario)
        {
            usuarioLogeado = usuario;
        }
    }
}