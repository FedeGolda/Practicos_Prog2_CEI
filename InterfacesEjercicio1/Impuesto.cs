using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    internal class Impuesto : Iimprimible
    {
        private int importe;
        public Impuesto(int importe)
        {
            this.importe = importe;
        }

        public int getImporte() { return importe; }
        public void setImporte(int importe) { this.importe = importe; }

        //Metodos obligatorios
        public void Imprimir()
        {
            Console.WriteLine($"Impresion de Importe: {importe}");
        }
    }
}
