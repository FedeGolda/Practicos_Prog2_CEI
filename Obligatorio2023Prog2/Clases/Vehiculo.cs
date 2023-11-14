using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Obligatorio2023Prog2.Clases
{
    public class Vehiculo
    {
        /*
        public string matricula { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string año { get; set; }
        */


        private string marca;
        private string modelo;
        private string matricula;
        private string año;
        private int kilometros;
        private string color;
        private double precioVenta;
        private double precioAlquiler;

        public Vehiculo()
        {

        }
        public Vehiculo(string marca, string modelo, string matricula, string año, int kilometros, string color, double precioVenta, double precioAlquiler)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
            this.año = año;
            this.kilometros = kilometros;
            this.color = color;
            this.precioVenta = precioVenta;
            this.precioAlquiler = precioAlquiler;
        }

        public string getMarca() { return marca; }
        public string getModelo() { return modelo; }
        public string getMatricula() { return matricula; }
        public string getAño() { return año; }
        public int getKilometros() { return kilometros; }
        public string getColor() { return color; }
        public double getPrecioVenta() { return precioVenta; }
        public double getPrecioAlquiler() { return precioAlquiler; }
        public void setMarca(string marca) { this.marca = marca; }
        public void setModelo(string modelo) { this.modelo = modelo; }
        public void setMatricula(string matricula) { this.matricula = matricula; }
        public void setAño(string año) { this.año = año; }
        public void setKilometros(int kilometros) { this.kilometros = kilometros; }
        public void setColor(string color) { this.color = color; }
        public void setPrecioVenta(double precioVenta) { this.precioVenta = precioVenta; }
        public void setPrecioAlquiler(double precioAlquiler) { this.precioAlquiler = precioAlquiler; }

    }
}
