using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEjercicio5
{
    internal class Hotel
    {
        private string nombre;
        private string direccion;
        private List<Habitacion> colHabitaciones;
        private List<Cliente> colClientes;
        private List<Reserva> colReservas;

        public Hotel()
        {

        }

        public Hotel(string nombre, string direccion, List<Habitacion> colHabitaciones, List<Cliente> colClientes, List<Reserva> colReservas)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.colHabitaciones = colHabitaciones;
            this.colClientes = colClientes;
            this.colReservas = colReservas;
        }

        public string getNombre() => this.nombre;
        public void setNombre(string nombre) => this.nombre = nombre;
        public string getDireccion() => this.direccion;
        public void setDireccion(string direccion) => this.direccion = direccion;
        public List<Habitacion> getColHabitaciones() => this.colHabitaciones;
        public List<Cliente> getColClientes() => this.colClientes;
        public List<Reserva> getColReservas() => this.colReservas;
        public void setColHabitaciones(List<Habitacion> colHabitaciones) => this.colHabitaciones = colHabitaciones;
        public void setColClientes(List<Cliente> colClientes) => this.colClientes = colClientes;
        public void setColReserva(List<Reserva> colReserva) => this.colReservas = colReserva;



        // Método para obtener reservas pendientes para un cliente específico
        public List<Reserva> ObtenerReservasPendientesPorCliente(int documentoCliente)
        {
            List<Reserva> reservasPendientes = new List<Reserva>();
            foreach (var reserva in colReservas)
            {
                // Verificar si la reserva pertenece al cliente y está pendiente
                if (reserva.getDocumento() == documentoCliente && reserva.getEstado() == "PENDIENTE")
                {
                    reservasPendientes.Add(reserva);
                }
            }
            return reservasPendientes;
        }


    }
}
