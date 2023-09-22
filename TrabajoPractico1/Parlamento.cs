using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    internal class Parlamento
    {
        private List<Legislador> Legisladores;

        public Parlamento()
        {
            Legisladores = new List<Legislador>();
        }


        public List<Legislador> getLegisladores()
        { 
            return Legisladores;
        }

        public void setLegisladores(List<Legislador> legisladores)
        {
            this.Legisladores = legisladores;
        }

        // Este método agrega un nuevo legislador a la lista de los mismos.
        public void RegistrarLegislador(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado)
        {
            Legislador nuevoLegislador = new Legislador(partidoPolitico, departamentoQueRepresenta, numDespacho, nombre, apellido, edad, casado);
            Legisladores.Add(nuevoLegislador);
        }


    }
}
