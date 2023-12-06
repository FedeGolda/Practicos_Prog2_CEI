using System;
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
        public static List<Venta> listaVentas = new List<Venta>();
        public static List<Alquiler> listaAlquileres = new List<Alquiler>();
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

            // Agregar un usuario normal
            Usuario usuario1 = new Usuario();
            usuario1.setNombreUsuario("Vendedor");
            usuario1.setContrasena("Vendedor");
            usuario1.setVerAlquileres(true);
            usuario1.setVerVentas(true);
            usuario1.setVerClientes(true);
            usuario1.setVerUsuarios(false);
            usuario1.setVerVehiculos(true);
            listaUsuarios.Add(usuario1);

            // Agregar clientes
            Cliente cliente = new Cliente { Apellido = "Perez", Cedula = "45866580", Direccion = "dr Edye 3456", Nombre = "Juan" };
            Cliente cliente2 = new Cliente { Apellido = "Lopez", Cedula = "45899989", Direccion = "dr Edye 5585", Nombre = "Javier" };
            Cliente cliente3 = new Cliente { Apellido = "Gomez", Cedula = "37854682", Direccion = "Aigua 3588", Nombre = "Luis" };
            listaClientes.Add(cliente);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);

            // Agregar vehículos
            Vehiculo vehiculo1 = new Vehiculo("Chevrolet", "Spark", "ABC123", "2012", 150000, "Rojo", 7900, 500, true, "https://s3.amazonaws.com/static.multiaviso.com/vehicle/images/2-EZE549R2Q67X-chevrolet-spark.jpg", "https://s3.amazonaws.com/static.multiaviso.com/vehicle/images/2-U69RHYHS6L8R-chevrolet-spark.jpg", "https://s3.amazonaws.com/static.multiaviso.com/vehicle/images/2-BXAJLEJ5PWQF-chevrolet-spark-th.jpg", "Cant. Pasajeros 5");
            Vehiculo vehiculo2 = new Vehiculo("Baccio", "Classic", "DEF456", "2023", 6000, "Negro", 1899, 100, true, "https://www.fama.com.uy/imgs/productos/productos34_16143.jpg", "https://f.fcdn.app/imgs/180b31/bikeup.uy/bikeuy/7386/original/catalogo/BACCLAF200_NE_5/2000-2000/baccio-classic-f200-negro.jpg", "https://f.fcdn.app/imgs/d21ae2/bikeup.uy/bikeuy/05c4/original/catalogo/BACCLAF200_NE_2/2000-2000/baccio-classic-f200-negro.jpg", "Cilindradas. 200");
            Vehiculo vehiculo3 = new Vehiculo("JAC TRACTOR", "375", "GHI789", "2018", 599547, "Azul", 35000, 500, true, "https://www.transportecarretero.com.uy/media/zoo/images/375_2_4e53cddc72aa47abe920dd2508d8cadc.jpg", "https://www.transportecarretero.com.uy/media/zoo/images/Jac-375-tractor_5_50f853ec42910e7d6dcb466f25cae3fc.jpg", "https://www.transportecarretero.com.uy/media/zoo/images/Jac-375-tractor_6_e96d308477095e4a2a4af82ab3e79a8d.jpg", "Toneladas. 2");


            listaVehiculos.Add(vehiculo1);
            listaVehiculos.Add(vehiculo2);
            listaVehiculos.Add(vehiculo3);


            Alquiler alquiler1 = new Alquiler { AutoDevuelto = false, Cedula = "45809059", Matricula = "MA125865", Dias = 3, FechaAlquiler = DateTime.Now.AddDays(-5), NombreUsuario = "Admin", Precio = 10000 };
            Alquiler alquiler2 = new Alquiler { AutoDevuelto = false, Cedula = "25688549", Matricula = "SG321555", Dias = 3, FechaAlquiler = DateTime.Now, NombreUsuario = "Admin", Precio = 12000 };
            Alquiler alquiler3 = new Alquiler { AutoDevuelto = true, Cedula = "45826584", Matricula = "RT9875578", Dias = 8, FechaAlquiler = DateTime.Now.AddDays(-12), NombreUsuario = "Vendedor", Precio = 20000 };
            listaAlquileres.Add(alquiler1);
            listaAlquileres.Add(alquiler2);
            listaAlquileres.Add(alquiler3);
        }

    public static List<Vehiculo> ListadoVehiculosActivos()
    {
        List<Vehiculo> vehiculosActivos = new List<Vehiculo>();
        foreach (var vehiculo in listaVehiculos)
        {
            if (vehiculo.Activo)
            {
                vehiculosActivos.Add(vehiculo);
            }
        }
        return vehiculosActivos;
    }

    public static void GuardarUsuarioLogeado(Usuario usuario)
    {
        usuarioLogeado = usuario;
    }
}
}