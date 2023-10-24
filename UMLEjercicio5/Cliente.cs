using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace UMLEjercicio5
{
    internal class Cliente
    {
        private string documento;
        private string nombre;
        private string apellido;
        private string telefono;
        private string direccion;
        private string tipoCliente;

        public Cliente()
        {

        }
        public Cliente(string documento, string nombre, string apellido, string telefono, string direccion, string tipoCliente)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.tipoCliente = tipoCliente;
        }

        public string getDocumento() => this.documento;
        public void setDocumento(string documento) => this.documento = documento;
        public string getNombre() => this.nombre;
        public void setNombre(string nombre) => this.nombre = nombre;
        public string getApellido() => this.apellido;
        public void setApellido(string apellido) => this.apellido = apellido;
        public string getTelefono() => this.telefono;
        public void setTelefono(string telefono) => this.telefono = telefono;
        public string getDireccion() => this.direccion;
        public void setDireccion(string direccion) => this.direccion = direccion;
        public string getTipoCliente() => this.tipoCliente;
        public void setTipoCliente(string tipoCliente) => this.tipoCliente = tipoCliente;
    }
}
