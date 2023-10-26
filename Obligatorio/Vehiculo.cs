using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    internal class Vehiculo
    {
        private string tipo;
        private string marca;
        private string modelo;
        private int anio;
        private int kilometros;
        private string color;
        private string matricula;
        private decimal precioVenta;
        private decimal precioAlquilerPorDia;
        private List<string> imagenes;
        
        public Vehiculo(string tipo, string marca, string modelo, int anio, int kilometros, string color, string matricula, decimal precioVenta, decimal precioAlquilerPorDia, List<string> imagenes)
        {
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.kilometros = kilometros;
            this.color = color;
            this.matricula = matricula;
            this.precioVenta = precioVenta;
            this.precioAlquilerPorDia = precioAlquilerPorDia; 
            this.imagenes = imagenes;  
        }

        public string getTipo() => this.tipo;
        public string getMarca() => this.marca;
        public string getModelo() => this.modelo;
        public int getAnio() => this.anio;
        public int getKilometros() => this.kilometros;
        public string getColor() => this.color;
        public string getMatricula() => this.matricula;
        public decimal getPrecioVenta() => this.precioVenta;
        public decimal getPrecioAlquilerPorDia() => this.precioAlquilerPorDia;
        public List<string> getImagenes() => this.imagenes;
        public void setTipo(string tipo) => this.tipo = tipo;
        public void setMarca(string marca) => this.marca = marca;
        public void setModelo(string modelo) => this.modelo = modelo;
        public void setAnio(int anio) => this.anio = anio;
        public void setKilometros(int kilometros) => this.kilometros = kilometros;
        public void setColor(string color) => this.color = color;
        public void setMatricula(string matricula) => this.matricula = matricula;
        public void setPrecioVenta(decimal precioVenta) => this.precioVenta = precioVenta;
        public void setPrecioAlquilerPorDia(decimal precioAlquilerPorDia) => this.precioAlquilerPorDia = precioAlquilerPorDia;
        public void setImagenes(List<string> imagenes) => this.imagenes = imagenes;
    }
}
