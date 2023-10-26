using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    internal class Alquiler
    {
        private Vehiculo vehiculo;
        private Cliente cliente;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private bool devuelto;

        public Alquiler(Vehiculo vehiculo, Cliente cliente, DateTime fechaInicio, DateTime fechaFin, bool devuelto)
        {
            this.vehiculo = vehiculo;
            this.cliente = cliente;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.devuelto = devuelto;
        }

        public void setVehiculo(Vehiculo vehiculo) => this.vehiculo = vehiculo;
        public void setCliente(Cliente cliente) => this.cliente = cliente;
        public void setFechaInicio(DateTime fechaInicio) => this.fechaInicio = fechaInicio;
        public void setFechaFin(DateTime fechaFin) => this.fechaFin = fechaFin;
        public void setDevuelto(bool devuelto) => this.devuelto = devuelto;
        public Vehiculo getVehiculo() => this.vehiculo;
        public Cliente getCliente() => this.cliente;
        public DateTime getFechaInicio() => this.fechaInicio;
        public DateTime getFechaFin() => this.fechaFin;
        public bool getDevuelto() => this.devuelto;
    }
}
