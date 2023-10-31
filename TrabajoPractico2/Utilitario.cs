using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Utilitario : Vehiculo
    {
        private int capacidadCarga;

        public Utilitario(int numero, string matricula, string marca, string color, int capacidadTanque, string estado, double precioDiario, int kmPorLitro, int capacidadCarga)
            : base(numero, matricula, marca, color, capacidadTanque, estado, precioDiario, kmPorLitro)
        {
            this.capacidadCarga = capacidadCarga;
        }
        public int getCapacidadCarga() => this.capacidadCarga;
        public void setCapacidadCarga(int capacidadCarga) => this.capacidadCarga = capacidadCarga;
    }
}