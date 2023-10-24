using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEjercicio5
{
    internal class Habitacion
    {
        private int numero;
        private int piso;
        private string descripcion;
        private List<TipoHabitacion> coltipoHabitacion; // Relacion
        public Habitacion() 
        {
            
        }

        public Habitacion(int numero, int piso, string descripcion)
        {
            this.numero = numero;
            this.piso = piso;
            this.descripcion = descripcion;
            this.coltipoHabitacion = new List<TipoHabitacion>(); // Agregacion
        }

        public int getNumero() => this.numero;
        public void setNumero(int numero) => this.numero = numero;
        public int getPiso() => this.piso;
        public void setPiso(int piso) => this.piso = piso;
        public string getDescripcion() => this.descripcion;
        public void setDescripcion(string descripcion) => this.descripcion = descripcion;
        public List<TipoHabitacion> GetTipoHabitacions() => this.coltipoHabitacion;
        public void setTipoHabitacion(List<TipoHabitacion> colTipoHabitacion) => this.coltipoHabitacion = colTipoHabitacion;
    }
}
