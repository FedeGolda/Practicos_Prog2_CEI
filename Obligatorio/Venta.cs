using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    internal class Venta
    {
        private Vehiculo vehiculo;
        private Cliente cliente;
        private DateTime fecha;

        public Venta(Vehiculo vehiculo, Cliente cliente, DateTime fecha)
        {
            this.vehiculo = vehiculo;
            this.cliente = cliente;
            this.fecha = fecha;
        }

        public Vehiculo getVehiculo() => vehiculo;
        public Cliente getCliente() => cliente;
        public DateTime getFecha() => fecha;
        public void setVehiculo(Vehiculo vehiculo) => this.vehiculo = vehiculo;
        public void setCliente(Cliente cliente) => this.cliente = cliente;
        public void setFecha(DateTime fecha) => this.fecha = fecha;

    }
}
