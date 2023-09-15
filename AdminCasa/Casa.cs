using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCasa
{
    internal class Casa
    {
        protected int numeroHabitaciones;
        protected int metrosCuadrados;

        public Casa(int numero, int metros)
        {
            numeroHabitaciones = numero;
            metrosCuadrados = metros;
        }

        public int getNumeroHabitaciones()
        {
            return numeroHabitaciones; 
        }

        public int getMetrosCuadrados()
        {
            return metrosCuadrados;
        }

        public void setNumeroHabitaciones(int numeroHabitaciones)
        {
            this.numeroHabitaciones = numeroHabitaciones;
        }

        public void setMetrosCuadrados(int metrosCuadrados)
        {
            this.metrosCuadrados = metrosCuadrados;
        }

        public virtual void Descripcion()
        {
            Console.WriteLine("Esta es una casa con {0} habitaciones y {1} metros cuadrados.", numeroHabitaciones, metrosCuadrados);
        }

    }
}
