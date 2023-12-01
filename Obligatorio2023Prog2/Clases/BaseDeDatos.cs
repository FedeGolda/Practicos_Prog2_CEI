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

            // Agregar clientes
            Cliente cliente = new Cliente { Apellido = "Perez", Cedula = "45866580", Direccion = "dr Edye 3456", Nombre = "Juan" };
            Cliente cliente2 = new Cliente { Apellido = "Lopez", Cedula = "45899989", Direccion = "dr Edye 5585", Nombre = "Javier" };
            Cliente cliente3 = new Cliente { Apellido = "Gomez", Cedula = "37854682", Direccion = "Aigua 3588", Nombre = "Luis" };
            listaClientes.Add(cliente);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);

            // Agregar vehículos
            Vehiculo vehiculo1 = new Vehiculo("Toyota", "Corolla", "ABC123", "2022", 5000, "Rojo", 25000, 100, true, "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg");
            Vehiculo vehiculo2 = new Vehiculo("Ford", "Focus", "DEF456", "2021", 8000, "Azul", 22000, 80, true, "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg");
            Vehiculo vehiculo3 = new Vehiculo("Honda", "Civic", "GHI789", "2020", 10000, "Negro", 20000, 90, true, "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg");
            Vehiculo vehiculo4 = new Vehiculo("Chevrolet", "Cruze", "JKL012", "2022", 6000, "Blanco", 23000, 95, true, "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg");
            Vehiculo vehiculo5 = new Vehiculo("Nissan", "Sentra", "MNO345", "2023", 3000, "Gris", 27000, 110, true, "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg", "https://phantom-expansion.unidadeditorial.es/1f59a66b768009525bd78ad642177e2c/crop/55x0/770x477/resize/414/f/jpg/assets/multimedia/imagenes/2022/09/15/16632231996207.jpg");

            listaVehiculos.Add(vehiculo1);
            listaVehiculos.Add(vehiculo2);
            listaVehiculos.Add(vehiculo3);
            listaVehiculos.Add(vehiculo4);
            listaVehiculos.Add(vehiculo5);
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