using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLEjercicio5
{
    internal class TipoHabitacion
    {
        private int codigo;
        private string nombre;
        private double costo;

        public TipoHabitacion()
        {
        
        }
        public TipoHabitacion(int codigo, string nombre, double costo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.costo = costo;
        }

        public int getCodigo() => this.codigo;
        public void setCodigo(int codigo) => this.codigo = codigo;
        public string getNombre() => this.nombre;
        public void setNombre(string nombre) => this.nombre = nombre;
        public double getCosto() => this.costo;
        public void setCosto(double costo) => this.costo = costo;


    }
}
