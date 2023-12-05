using Obligatorio2023Prog2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2
{
    public class Moto : Vehiculo
    {
        public int cilindradas { get; set; }

        public Moto(string marca, string modelo, string matricula, string año, int kilometros, string color, double precioVenta, double precioAlquiler, bool activo, string Imagen1, string Imagen2, string Imagen3, string CampoEspecial, int cilindradas)
            : base(marca, modelo, matricula, año, kilometros, color, precioVenta, precioAlquiler, activo, Imagen1, Imagen2, Imagen3, CampoEspecial)
        {
            this.cilindradas = cilindradas;
        }

        public int getCilindradas() { return cilindradas; }
        public void setCilindradas(int cilindradas) { this.cilindradas = cilindradas; }
    }

}