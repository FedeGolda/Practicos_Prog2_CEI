using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2
{
    public class Venta
    {
        public string Cedula { get; set; }
        public string Matricula { get; set; }

        public string NombreUsuario { get; set; }

        public DateTime FechaVenta { get; set; }
        public int Precio { get; set; }
        

        public string getCedula() { return Cedula; }
        public string getMatricula() { return Matricula; }
        public string getNombreUsuario() { return NombreUsuario; }
        public DateTime getFechaVenta() { return FechaVenta; }
        public int getPrecio() { return Precio; }
        public void setCedula(string Cedula) { this.Cedula = Cedula; }
        public void setMatricula(string Matricula) { this.Matricula = Matricula; }
        public void setNombreUsuario(string NombreUsuario) { this.NombreUsuario = NombreUsuario; }
        public void setFechaAlquiler(DateTime FechaVenta) { this.FechaVenta = FechaVenta; }
        public void setPrecio(int Precio) { this.Precio = Precio; }
    }
}