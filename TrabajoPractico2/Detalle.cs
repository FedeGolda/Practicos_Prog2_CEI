using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Detalle
    {
        private Vehiculo vehiculo;
        private DateTime fechaRetiro;
        private int cantidadDias; 

        public Detalle(Vehiculo vehiculo, DateTime fechaRetiro, int cantidadDias)
        {
            this.vehiculo = vehiculo;
            this.fechaRetiro = fechaRetiro;
            this.cantidadDias = cantidadDias;
        }

        public Vehiculo getVehiculo() => this.vehiculo;
        public void setVehiculo(Vehiculo vehiculo) => this.vehiculo = vehiculo;
        public DateTime getFechaRetiro() => this.fechaRetiro;
        public void setFechaRetiro(DateTime fechaRetiro) => this.fechaRetiro = fechaRetiro;
        public int getCantidadDias() => this.cantidadDias;
        public void setCantidadDias(int cantidadDias) => this.cantidadDias = cantidadDias;
    }
}
