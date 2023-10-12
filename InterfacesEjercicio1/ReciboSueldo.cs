using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class ReciboSueldo : Iimprimible
    {
        private int legajo;
        private int total;

        public ReciboSueldo(int legajo, int total)
        {
            this.legajo = legajo;
            this.total = total;
        }

        public int getLegajo() { return legajo; }
        public void setLegajo(int legajo) { this.legajo = legajo; }

        public int getTotal() { return total; }
        public void setTotal(int total) { this.total = total; }

        //Metodos obligatorios
        public void Imprimir()
        {
            Console.WriteLine($"Impresion de Legajo {legajo} de total: ${total}");
        }
    }
}
