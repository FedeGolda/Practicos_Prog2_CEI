using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Alquiler
    {
        private int numero;
        private double precioTotal;
        private string documento;
        private string telefono;
        private string nombre;
        private string apellido;
        private List<Detalle> colDetalles; // Relacion de Composicion. Tengo una lista de Detalles 1--->1..*

        public Alquiler(int numero, double precioTotal, string documento, string telefono, string nombre, string apellido)
        {
            this.numero = numero;
            this.precioTotal = precioTotal;
            this.documento = documento;
            this.telefono = telefono;
            this.nombre = nombre;
            this.apellido = apellido;
            this.colDetalles = new List<Detalle>(); // Composicion
        }
        public void AgregarDetalle(Vehiculo vehiculo, DateTime fechaRetiro, int cantidadDias)
        {
            Detalle miDetalle = new Detalle(vehiculo, fechaRetiro, cantidadDias);
            colDetalles.Add(miDetalle);
        }
        public int getNumero() => this.numero;
        public void setNumero(int numero) => this.numero = numero;
        public double getPrecioTotal() => this.precioTotal;
        public void setPrecioTotal(double precioTotal) => this.precioTotal = precioTotal;
        public string getDocumento() => this.documento;
        public void set(string documento) => this.documento = documento;
        public string getTelefono() => this.telefono;
        public void setTelefono(string telefono) => this.telefono = telefono;
        public string getNombre() => this.nombre;
        public void setNombre(string nombre) => this.nombre = nombre;
        public string getApellido() => this.apellido;
        public void setApellido(string apellido) => this.apellido = apellido;
        public List<Detalle> getDetalles() => this.colDetalles;
        public void setDetalles(List<Detalle> colDetalles) => this.colDetalles = colDetalles;
    }
}
