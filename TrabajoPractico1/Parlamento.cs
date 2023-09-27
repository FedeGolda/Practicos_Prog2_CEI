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
                Console.WriteLine($"Nombre: {legislador.getNombre()}");
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

            Console.WriteLine($"Cantidad de Senadores: {cantidadSenadores}");
            Console.WriteLine($"Cantidad de Diputados: {cantidadDiputados}");
        }


        public bool BorrarLegislador(string nombre)
        {
            // Recorre la lista de legisladores para buscar y borrar al legislador por nombre
            for (int i = 0; i < Legisladores.Count; i++)
            {
                Legislador legislador = Legisladores[i];
                if (legislador.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    // Se encontró el legislador, borrarlo de la lista
                    Legisladores.RemoveAt(i);
                    return true; // Indica que se borró el legislador con éxito
                }
            }

            return false; // Indica que no se encontró ningún legislador con el nombre proporcionado
        }

        public bool ExisteLegisladorPorNumeroDespacho(int numeroDespacho)
        {
            return Legisladores.Any(legislador => legislador.getNumDespacho() == numeroDespacho);
        }



    }
}