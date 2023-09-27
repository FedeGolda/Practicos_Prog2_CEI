using System;
using System.Collections.Generic;

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
                Console.WriteLine($"Nombre: {legislador.GetNombre()}");
                Console.WriteLine($"Número de Despacho: {legislador.GetNumDespacho()}");
                Console.WriteLine($"Cámara: {legislador.GetCamara()}");
                Console.WriteLine();
            }
        }

        public void ContarLegisladoresPorTipo()
        {
            int cantidadSenadores = 0;
            int cantidadDiputados = 0;

            foreach (var legislador in Legisladores)
            {
                if (legislador.GetCamara() == "Senadores")
                {
                    cantidadSenadores++;
                }
                else if (legislador.GetCamara() == "Diputados")
                {
                    cantidadDiputados++;
                }
            }

            Console.WriteLine($"Cantidad de Senadores: {cantidadSenadores}");
            Console.WriteLine($"Cantidad de Diputados: {cantidadDiputados}");
        }

        public bool BorrarLegislador(string nombre)
        {
            for (int i = 0; i < Legisladores.Count; i++)
            {
                Legislador legislador = Legisladores[i];
                if (legislador.GetNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Legisladores.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public bool ExisteLegisladorPorNumeroDespacho(int numeroDespacho)
        {
            return Legisladores.Exists(legislador => legislador.GetNumDespacho() == numeroDespacho);
        }
    }
}
