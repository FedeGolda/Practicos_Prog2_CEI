using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    internal class Diputado : Legislador
    {
        private int NumAsientoCamaraBaja;

        public Diputado(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado, int numAsientoCamaraBaja)
            : base(partidoPolitico, departamentoQueRepresenta, numDespacho, nombre, apellido, edad, casado)
        {
            NumAsientoCamaraBaja = numAsientoCamaraBaja;
        }

        public int getNumAsientoCamaraBaja()
        {
            return NumAsientoCamaraBaja;
        }

        public void setNumAsientoCamaraBaja(int numAsientoCamaraBaja)
        {
            this.NumAsientoCamaraBaja = numAsientoCamaraBaja;
        }

    }
}
