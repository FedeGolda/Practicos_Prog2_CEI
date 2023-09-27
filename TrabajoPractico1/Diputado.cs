using System;

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

        public int GetNumAsientoCamaraBaja()
        {
            return NumAsientoCamaraBaja;
        }

        public void SetNumAsientoCamaraBaja(int numAsientoCamaraBaja)
        {
            this.NumAsientoCamaraBaja = numAsientoCamaraBaja;
        }

        public override void PresentarPropuestaLegislativa(string propuesta)
        {
            base.PresentarPropuestaLegislativa(propuesta);
            Console.WriteLine($"{GetNombre()} {GetApellido()} del partido {GetPartidoPolitico()} (Diputados) ha presentado la propuesta: '{propuesta}'");
        }

        public override void ParticiparDebate(string temaDebate)
        {
            Console.WriteLine($"{GetNombre()} {GetApellido()} del partido {GetPartidoPolitico()} (Diputados) ha participado en el debate sobre '{temaDebate}'.");
        }
    }
}
