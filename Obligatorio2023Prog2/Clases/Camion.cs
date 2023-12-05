using Obligatorio2023Prog2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2
{
    public class Camion : Vehiculo
    {
        public double carga { get; set; }

        public Camion(string marca, string modelo, string matricula, string año, int kilometros, string color, double precioVenta, double precioAlquiler, bool activo, string Imagen1, string Imagen2, string Imagen3, string CampoEspecial, double carga)
            : base(marca, modelo, matricula, año, kilometros, color, precioVenta, precioAlquiler, activo, Imagen1, Imagen2, Imagen3, CampoEspecial)
        {
            this.carga = carga;
        }
        public double getCarga() { return carga; }
        public void setCarga(double carga) { this.carga = carga; }
    }
}