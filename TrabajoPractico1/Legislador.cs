using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    internal class Legislador
    {
        protected string partidoPolitico;
        protected string departamento;
        protected int numDespacho;
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected bool casado;

        // Constructor
        public Legislador(string PartidoPolitico, string departamentoQueRepresenta, int NumDespacho, string Nombre, string Apellido, int Edad, bool Casado)
        {
            partidoPolitico = PartidoPolitico;
            departamento = departamentoQueRepresenta;
            numDespacho = NumDespacho;
            nombre = Nombre;
            apellido = Apellido;
            edad = Edad;
            casado = Casado;
        }

        public void getCamara()
        {
            
        }

    }
}
