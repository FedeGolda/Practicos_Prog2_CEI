using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    internal class Senador : Legislador
    {
        private int NumAsientoCamaraAlta;

        public Senador(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado, int numAsientoCamaraAlta)
            : base(partidoPolitico, departamentoQueRepresenta, numDespacho, nombre, apellido, edad, casado)
        {
            NumAsientoCamaraAlta = numAsientoCamaraAlta;
        }

        public int getNumAsiendoCamaraAlta()
        {
            return NumAsientoCamaraAlta;
        }

        public void setNumAsientoCamaraAlta(int numAsiendoCamaraAlta)
        {
            this.NumAsientoCamaraAlta = numAsiendoCamaraAlta;
        }
    }
}
