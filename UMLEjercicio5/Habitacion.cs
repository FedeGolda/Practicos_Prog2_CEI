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
        private TipoHabitacion tipoHabitacion; // Composicion
        public Habitacion() 
        {
            
        }

        public Habitacion(int numero, int piso, string descripcion, int codigo, string nombre, double costo)
        {
            this.numero = numero;
            this.piso = piso;
            this.descripcion = descripcion;
            this.tipoHabitacion = new TipoHabitacion( codigo, nombre, costo); // Composicion
        }

        public int getNumero() => this.numero;
        public void setNumero(int numero) => this.numero = numero;
        public int getPiso() => this.piso;
        public void setPiso(int piso) => this.piso = piso;
        public string getDescripcion() => this.descripcion;
        public void setDescripcion(string descripcion) => this.descripcion = descripcion;
        public TipoHabitacion GetTipoHabitacions() => this.tipoHabitacion;
        public void setTipoHabitacion(TipoHabitacion tipoHabitacion) => this.tipoHabitacion = tipoHabitacion;
    }
}
