using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Obligatorio2023Prog2.Clases
{
    public class Vehiculo
    {
        public string matricula { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string año { get; set; }
        public int kilometros { get; set; }
        public string color { get; set; }
        public double precioVenta { get; set; }
        public double precioAlquilerDia { get; set; }
        public bool Activo { get; set; }
        public string Imagen1 { get; set; }
        public string Imagen2 { get; set; }
        public string Imagen3 { get; set; }
        public string CampoEspecial { get; set; }

        public Vehiculo()
        {

        }
        public Vehiculo(string marca, string modelo, string matricula, string año, int kilometros, string color, double precioVenta, double precioAlquilerDia, bool Activo, string Imagen1, string Imagen2, string Imagen3, string CampoEspecial)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
            this.año = año;
            this.kilometros = kilometros;
            this.color = color;
            this.precioVenta = precioVenta;
            this.precioAlquilerDia = precioAlquilerDia;
            this.Activo = Activo;
            this.Imagen1 = Imagen1;
            this.Imagen2 = Imagen2;
            this.Imagen3 = Imagen3;
            this.CampoEspecial = CampoEspecial;
        }


        public string getMarca() { return marca; }
        public string getModelo() { return modelo; }
        public string getMatricula() { return matricula; }
        public string getAño() { return año; }
        public int getKilometros() { return kilometros; }
        public string getColor() { return color; }
        public double getPrecioVenta() { return precioVenta; }
        public double getPrecioAlquilerDia() { return precioAlquilerDia; }
        public bool getActivo() { return Activo; }
        public string getImagen1() { return Imagen1; }
        public string getImagen2() { return Imagen2; }
        public string getImagen3() {  return Imagen3; }
        public string getCampoEspecial() { return CampoEspecial; }
        public void setMarca(string marca) { this.marca = marca; }
        public void setModelo(string modelo) { this.modelo = modelo; }
        public void setMatricula(string matricula) { this.matricula = matricula; }
        public void setAño(string año) { this.año = año; }
        public void setKilometros(int kilometros) { this.kilometros = kilometros; }
        public void setColor(string color) { this.color = color; }
        public void setPrecioVenta(double precioVenta) { this.precioVenta = precioVenta; }
        public void setPrecioAlquilerDia(double precioAlquilerDia) { this.precioAlquilerDia = precioAlquilerDia; }
        public void setActivo(bool Activo) { this.Activo = Activo; }
        public void setImagen1(string Imagen1) { this.Imagen1 = Imagen1; }
        public void setImagen2(string Imagen2) { this.Imagen2 = Imagen2; }
        public void setImagen3(string Imagen3) { this.Imagen3 = Imagen3; }
        public void setCampoEspecial(string CampoEspecial) { this.CampoEspecial = CampoEspecial; }

        public string DatosMostrar
        {
            get
            {
                return "Matricula: " + matricula + "Marca" + marca + "Modelo:" + modelo;
            }
        }
    }
}
