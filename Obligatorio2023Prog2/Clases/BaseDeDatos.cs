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
    }
}