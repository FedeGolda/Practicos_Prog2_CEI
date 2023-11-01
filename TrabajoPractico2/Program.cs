namespace TrabajoPractico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> colVehiculos = new List<Vehiculo>();
            List<Alquiler> colAlquileres = new List<Alquiler>();
            List<Detalle> colDetalles = new List<Detalle>();

            // Crear una instancia de la clase Sucursal
            Sucursal sucursal = new Sucursal(1, "Dirección de la Sucursal", colVehiculos, colAlquileres);

            // Crear instancias de Vehiculo
            Vehiculo vehiculo1 = new Vehiculo(1, "ABC123", "Toyota", "Rojo", 50, "Disponible", 50.0, 15);
            Vehiculo vehiculo2 = new Vehiculo(2, "DEF456", "Ford", "Azul", 45, "Disponible", 45.0, 18);
            Vehiculo vehiculo3 = new Vehiculo(3, "GHI789", "Chevrolet", "Verde", 55, "Disponible", 55.0, 14);
            Vehiculo vehiculo4 = new Vehiculo(4, "JKL012", "Honda", "Amarillo", 48, "Disponible", 48.0, 17);
            Vehiculo vehiculo5 = new Vehiculo(5, "MNO345", "Nissan", "Negro", 52, "Disponible", 52.0, 16);

            // Crear instancias de Alquiler
            Alquiler alquiler1 = new Alquiler(1, 200.0, "12345678", "123456789", "Cliente1", "Apellido1");
            Alquiler alquiler2 = new Alquiler(2, 300.0, "23456789", "234567890", "Cliente2", "Apellido2");
            Alquiler alquiler3 = new Alquiler(3, 150.0, "34567890", "345678901", "Cliente3", "Apellido3");

            // Crear instancias de Detalle y asociarlas con Alquiler
            Detalle detalle1 = new Detalle(vehiculo1, DateTime.Now, 3);
            Detalle detalle2 = new Detalle(vehiculo2, DateTime.Now, 5);
            Detalle detalle3 = new Detalle(vehiculo3, DateTime.Now, 2);

            // Registrar vehículos en la sucursal
            sucursal.RegistrarVehiculo(vehiculo1);
            sucursal.RegistrarVehiculo(vehiculo2);
            sucursal.RegistrarVehiculo(vehiculo3);
            sucursal.RegistrarVehiculo(vehiculo4);
            sucursal.RegistrarVehiculo(vehiculo5);

            // Registrar alquileres en la sucursal
            sucursal.RegistrarAlquiler(alquiler1);
            sucursal.RegistrarAlquiler(alquiler2);
            sucursal.RegistrarAlquiler(alquiler3);

            alquiler1.AgregarDetalle(detalle1);
            alquiler2.AgregarDetalle(detalle2);
            alquiler3.AgregarDetalle(detalle3);

            // Mostrar vehículos y alquileres
            sucursal.ListarVehiculos();
            sucursal.ListarAlquileres();
        }
    }
}