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

        // Implementación específica para Diputados
        public override void PresentarPropuestaLegislativa(string propuesta)
        {
            Console.WriteLine($"{Nombre} {Apellido} del partido {PartidoPolitico} (Diputados) ha presentado la propuesta: '{propuesta}'");
        }

        // Implementación específica para Diputados
        public override void ParticiparDebate(string temaDebate)
        {
            Console.WriteLine($"{Nombre} {Apellido} del partido {PartidoPolitico} (Diputados) ha participado en el debate sobre '{temaDebate}'.");
        }



    }
}
