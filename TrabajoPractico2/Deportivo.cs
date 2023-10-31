using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Deportivo : Vehiculo
    {
        private int velocidadMax;

        public Deportivo(int numero, string matricula, string marca, string color, int capacidadTanque, string estado, double precioDiario, int kmPorLitro, int velocidadMax) 
            : base(numero, matricula, marca, color, capacidadTanque, estado, precioDiario, kmPorLitro)
        {
            this.velocidadMax = velocidadMax;
        }
        public int getVelocidadMax() => this.velocidadMax;
        public int setVelocidadMax(int velocidadMax) => this.velocidadMax = velocidadMax;
    }
}
