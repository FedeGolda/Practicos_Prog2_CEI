using Obligatorio2023Prog2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2
{
    public class Auto : Vehiculo
    {
        public int pasajeros { get; set; }
        public Auto(string marca, string modelo, string matricula, string año, int kilometros, string color, double precioVenta, double precioAlquiler, int pasajeros)
            : base(marca, modelo, matricula, año, kilometros, color, precioVenta, precioAlquiler)
        {
            this.pasajeros = pasajeros;
        }

        public int getPasajeros() { return pasajeros; }
        public void setPasajeros(int pasajeros) { this.pasajeros = pasajeros; }
    }
}