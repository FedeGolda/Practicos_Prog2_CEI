using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    internal class Legislador
    {
        protected string PartidoPolitico;
        protected string Departamento;
        protected int NumDespacho;
        protected string Nombre;
        protected string Apellido;
        protected int Edad;
        protected bool Casado;

        // Constructor
        public Legislador(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado)
        {
            PartidoPolitico = partidoPolitico;
            Departamento = departamentoQueRepresenta;
            NumDespacho = numDespacho;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Casado = casado;
        }

        public string getPartidoPolitico()
        { 
            return PartidoPolitico;
        }

        public string getDepartamento()
        {  
            return Departamento;
        }

        public int getNumDespacho() 
        {
            return NumDespacho;
        }

        public string getNombre()
        { 
            return Nombre;
        }

        public string getApellido()
        {
            return Apellido;
        }

        public int getEdad() 
        {
            return Edad;
        }

        public bool getCasado()
        { 
            return Casado;
        }

        public void setPartidoPolitico(string partidoPolitico)
        {
            this.PartidoPolitico = partidoPolitico;
        }

        public void setDepartamento(string departamentoQueRepresenta)
        {
            this.Departamento = departamentoQueRepresenta;
        }

        public void setNumDespacho(int numDespacho)
        {
            this.NumDespacho = numDespacho;
        }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            this.Apellido = apellido;
        }

        public void setEdad(int edad)
        {
            this.Edad = edad;
        }

        public void setCasado(bool casado)
        { 
            this.Casado = casado;
        }

        public void getCamara()
        {
            
        }

    }
}
