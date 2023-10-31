using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Vehiculo
    {
        private int numero;
        private string matricula;
        private string marca;
        private string color;
        private int capacidadTanque;
        private string estado;
        private double precioDiario;
        private int kmPorLitro;

        public Vehiculo(int numero, string matricula, string marca, string color, int capacidadTanque, string estado, double precioDiario, int kmPorLitro)
        {
            this.numero = numero;
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
            this.capacidadTanque = capacidadTanque; 
            this.estado = estado;
            this.precioDiario = precioDiario;
            this.kmPorLitro = kmPorLitro;
        }

        public void setNumero(int numero) => this.numero = numero;
        public int getNumero() => this.numero;
        public void setMatricula(string matricula) => this.matricula = matricula;
        public string getMatricula() => this.matricula;
        public void setMarca(string marca) => this.marca = marca;
        public string getMarca() => this.marca;
        public void setColor(string color) => this.color = color;
        public string getColor() => this.color;
        public void setCapacidadTanque(int capacidadTanque) => this.capacidadTanque = capacidadTanque;
        public int getCapacidadTanque() => this.capacidadTanque;
        public void setEstado(string estado) => this.estado = estado;
        public string getEstado() => this.estado;
        public void setPrecioDiario(double precioDiario) => this.precioDiario = precioDiario;
        public double getPrecioDiario() => this.precioDiario;
        public void setKmPorLitro(int kmPorLitro) => this.kmPorLitro = kmPorLitro;
        public int getKmPorLitro() => this.kmPorLitro;
    }
}
