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
        protected List<Banio> banios;
        protected List<Dormitorio> dormitorios;
        protected List<Cocina> cocinas;

        public Casa(int numero, int metros)
        {
            numeroHabitaciones = numero;
            metrosCuadrados = metros;
            banios = new List<Banio>();
            dormitorios = new List<Dormitorio>();
            cocinas = new List<Cocina>();
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

        public void AgregarBanio(string tieneDucha, int numero, int metros)
        {
            banios.Add(new Banio(tieneDucha, numero, metros));
        }

        public void AgregarDormitorio(int numeroCamas, int numero, int metros)
        {
            dormitorios.Add(new Dormitorio(numeroCamas, numero, metros));
        }

        public void AgregarCocina(string tieneHorno, int numero, int metros)
        {
            cocinas.Add(new Cocina(tieneHorno, numero, metros));
        }

        public virtual void Descripcion()
        {
            Console.WriteLine($"Esta es una casa con {numeroHabitaciones} habitaciones y {metrosCuadrados}m2");

            // Verificar si hay baños y, si los hay, imprimir la información
            if (banios.Any())
            {
                Console.WriteLine("Baños:");
                foreach (var banio in banios)
                {
                    banio.Descripcion();
                }
            }

            // Verificar si hay dormitorios y, si los hay, imprimir la información
            if (dormitorios.Any())
            {
                Console.WriteLine("Dormitorios:");
                foreach (var dormitorio in dormitorios)
                {
                    dormitorio.Descripcion();
                }
            }

            // Verificar si hay cocinas y, si las hay, imprimir la información
            if (cocinas.Any())
            {
                Console.WriteLine("Cocinas:");
                foreach (var cocina in cocinas)
                {
                    cocina.Descripcion();
                }
            }
        }



    }

}
