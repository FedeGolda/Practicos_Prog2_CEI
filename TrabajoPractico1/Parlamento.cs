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


        public List<Legislador> getLegisladores()
        { 
            return Legisladores;
        }

        public void setLegisladores(List<Legislador> legisladores)
        {
            this.Legisladores = legisladores;
        }

        // Este método agrega un nuevo legislador a la lista de los mismos.
        public void RegistrarLegislador(Legislador legislador)
        {
            Legisladores.Add(legislador); // Agregar el legislador proporcionado a la lista de Legisladores
        }



        // Imprime en la consola el número de despacho y la cámara en la que trabaja el legislador (Senadores o Diputados).
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

        // Lista la cantidad de senadores y diputados.
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




    }
}
