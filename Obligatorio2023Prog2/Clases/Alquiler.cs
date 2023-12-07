using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2
{
    public class Alquiler
    {
        public string Cedula { get; set; }
        public string Matricula { get; set; }

        public string NombreUsuario { get; set; }

        public DateTime FechaAlquiler { get; set; }
        public int Dias { get; set; }
        public int Precio { get; set; }
        public bool AutoDevuelto { get; set; }
        public string getCedula() { return Cedula; }
        public string getMatricula() { return Matricula; }
        public string getNombreUsuario() { return NombreUsuario; }
        public DateTime getFechaAlquiler() { return FechaAlquiler; }
        public int getDias() { return Dias; }
        public int getPrecio() { return Precio; }
        public bool getAutoDevuelto() { return AutoDevuelto; }
        public void setCedula(string Cedula) { this.Cedula = Cedula; }
        public void setMatricula(string Matricula) { this.Matricula = Matricula; }
        public void setNombreUsuario(string NombreUsuario) { this.NombreUsuario = NombreUsuario; }
        public void setFechaAlquiler(DateTime FechaAlquiler) { this.FechaAlquiler = FechaAlquiler; }
        public void setDias(int Dias) { this.Dias = Dias; }
        public void setPrecio(int Precio) { this.Precio = Precio;}
        public void setAutoDevuelto(bool AutoDevuelto) { this.AutoDevuelto = AutoDevuelto; }

        public string Estado
        {
            get
            {
                if (!AutoDevuelto && DateTime.Now > FechaAlquiler.AddDays(Dias))
                {
                    return "Atrasado";
                }
                else if (!AutoDevuelto)
                {
                    return "Al día";
                }
                else
                {
                    return "Vehículo devuelto";
                }
            }
        }

    }
}