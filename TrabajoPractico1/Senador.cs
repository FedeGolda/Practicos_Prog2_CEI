using System;

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

        public int GetNumAsientoCamaraAlta()
        {
            return NumAsientoCamaraAlta;
        }

        public void SetNumAsientoCamaraAlta(int numAsientoCamaraAlta)
        {
            this.NumAsientoCamaraAlta = numAsientoCamaraAlta;
        }

        public override void PresentarPropuestaLegislativa(string propuesta)
        {
            base.PresentarPropuestaLegislativa(propuesta);
            Console.WriteLine($"{GetNombre()} {GetApellido()} del partido {GetPartidoPolitico()} (Senado) ha presentado la propuesta: '{propuesta}'");
        }

        public override void ParticiparDebate(string temaDebate)
        {
            Console.WriteLine($"{GetNombre()} {GetApellido()} del partido {GetPartidoPolitico()} (Senado) ha participado en el debate sobre '{temaDebate}'.");
        }
    }
}
