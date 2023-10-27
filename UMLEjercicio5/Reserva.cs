using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEjercicio5
{
    internal class Reserva
    {
        private int numeroReserva;
        private string fechaIngreso;
        private string fechaSalida;
        private int cantDias;
        private double precioTotal;
        private Habitacion habitacion; // Relacion de asociacion
        private string estado; // Nueva propiedad para el estado de la reserva
        private Cliente cliente;
        public Reserva()
        {

        }
        public Reserva(int numeroReserva, string fechaIngreso, string fechaSalida, int cantDias, double precioTotal, List<Habitacion> colHabitaciones, string estado, Cliente cliente)
        {
            this.numeroReserva = numeroReserva;
            this.fechaIngreso = fechaIngreso;
            this.fechaSalida = fechaSalida;
            this.cantDias = cantDias;
            this.precioTotal = precioTotal;
            this.habitacion = habitacion;
            this.estado = estado;
            this.cliente = cliente;
        }

        public int getNumeroReserva() => this.numeroReserva;
        public void setNumeroReserva(int numeroReserva) => this.numeroReserva = numeroReserva;
        public string getFechaIngreso() => this.fechaIngreso;
        public void setFechaIngreso(string fechaIngreso) => this.fechaIngreso = fechaIngreso;
        public string getFechaSalida() => this.fechaSalida;
        public void setFechaSalida(string fechaSalida) => this.fechaSalida = fechaSalida;
        public int getCantDias() => this.cantDias;
        public void setCantDias(int cantDias) => this.cantDias = cantDias;
        public double getPrecioTotal() => this.precioTotal;
        public void setPrecioTotal(double precioTotal) => this.precioTotal = precioTotal;
        public List<Habitacion> getColHabitaciones() => this.colHabitaciones;
        public void setColHabitaciones(List<Habitacion> colHabitaciones) => this.colHabitaciones = colHabitaciones;
        public string getEstado() => this.estado;
        public void setEstado(string estado) => this.estado = estado;
        public Cliente getCliente() => this.cliente;
        public void setCliente(Cliente cliente) => this.cliente = cliente;

    }
}
