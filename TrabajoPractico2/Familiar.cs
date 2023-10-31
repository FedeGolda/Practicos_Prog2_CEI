using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Familiar : Vehiculo
    {
        private int capacidadMaletero;

        public Familiar(int numero, string matricula, string marca, string color, int capacidadTanque, string estado, double precioDiario, int kmPorLitro, int capacidadMaletero) 
            : base(numero, matricula, marca, color, capacidadTanque, estado, precioDiario, kmPorLitro)
        {
            this.capacidadMaletero = capacidadMaletero;
        }
        public int getCapacidadMaletero() => this.capacidadMaletero;
        public void setCapacidadMaletero(int capacidadMaletero) => this.capacidadMaletero = capacidadMaletero;
    }
}
