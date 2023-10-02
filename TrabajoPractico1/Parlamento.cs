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

        public List<Legislador> GetLegisladores()
        {
            return Legisladores;
        }

        public void SetLegisladores(List<Legislador> legisladores)
        {
            this.Legisladores = legisladores;
        }

        public void RegistrarLegislador(Legislador legislador)
        {
            Legisladores.Add(legislador);
        }

        public void ListarCamaras()
        {
            foreach (var legislador in Legisladores)
            {
                Console.WriteLine($"\nNombre: {legislador.getNombre()}");
                Console.WriteLine($"Número de Despacho: {legislador.getNumDespacho()}");
                Console.WriteLine($"Cámara: {legislador.getCamara()}");
                Console.WriteLine();
            }
        }

        public void ContarLegisladoresPorTipo()
        {
            int cantidadSenadores = 0;
            int cantidadDiputados = 0;

            foreach (var legislador in Legisladores)
            {
                if (legislador.getCamara() == "Senado")
                {
                    cantidadSenadores++;
                }
                else if (legislador.getCamara() == "Diputados")
                {
                    cantidadDiputados++;
                }
            }

            Console.WriteLine($"\nCantidad de Senadores: {cantidadSenadores}");
            Console.WriteLine($"Cantidad de Diputados: {cantidadDiputados}");
        }


        public bool BorrarLegisladorPorNumero(int numeroDespacho)
        {
            // Busca el legislador por número de despacho
            Legislador legisladorABorrar = null;
            foreach (Legislador legislador in Legisladores)
            {
                if (legislador.getNumDespacho() == numeroDespacho)
                {
                    legisladorABorrar = legislador;
                    break; // Se encontró el legislador, sal del bucle
                }
            }

            if (legisladorABorrar != null)
            {
                // Borra el legislador de la lista
                Legisladores.Remove(legisladorABorrar);

                // Ahora, reorganiza los números de despacho de los legisladores restantes
                for (int i = 0; i < Legisladores.Count; i++)
                {
                    Legisladores[i].setNumDespacho(i + 1);
                }

                return true; // Indica que se borró el legislador con éxito
            }

            return false; // Indica que no se encontró ningún legislador con el número de despacho proporcionado
        }




        public bool ExisteLegisladorPorNumeroDespacho(int numeroDespacho)
        {
            return Legisladores.Any(legislador => legislador.getNumDespacho() == numeroDespacho);
        }
    }
}