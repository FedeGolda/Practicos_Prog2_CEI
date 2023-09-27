using System;
using System.Collections.Generic;

namespace TrabajoPractico1
{
    public enum Voto
    {
        Aprobado,
        Rechazado,
        Abstencion
    }

    internal class Legislador
    {
        private string partidoPolitico;
        private string departamentoQueRepresenta;
        private int numeroDespacho;
        private string nombre;
        private string apellido;
        private int edad;
        private bool casado;
        private List<string> propuestasLegislativas = new List<string>();
        private Dictionary<string, List<string>> votosPorPropuesta = new Dictionary<string, List<string>>();

        public Legislador(string partidoPolitico, string departamentoQueRepresenta, int numeroDespacho, string nombre, string apellido, int edad, bool casado)
        {
            this.partidoPolitico = partidoPolitico;
            this.departamentoQueRepresenta = departamentoQueRepresenta;
            this.numeroDespacho = numeroDespacho;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.casado = casado;
        }

        public string GetPartidoPolitico()
        {
            return partidoPolitico;
        }

        public string GetDepartamento()
        {
            return departamentoQueRepresenta;
        }

        public int GetNumDespacho()
        {
            return numeroDespacho;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public int GetEdad()
        {
            return edad;
        }

        public bool GetCasado()
        {
            return casado;
        }

        public string GetCamara()
        {
            return (numeroDespacho <= 99) ? "Diputados" : "Senadores";
        }

        // Método para registrar un voto y la propuesta
        public void RegistrarVotoYPropuesta(string propuesta, string voto)
        {
            string votoRegistrado = $"Proyecto: {propuesta}, Voto: {voto}";
            if (!votosPorPropuesta.ContainsKey(propuesta))
            {
                votosPorPropuesta[propuesta] = new List<string>();
            }
            votosPorPropuesta[propuesta].Add(voto);

            // Verificar si la propuesta no existe en las propuestas legislativas
            if (!propuestasLegislativas.Contains(propuesta))
            {
                propuestasLegislativas.Add(propuesta);
            }
        }

        // Método para mostrar la lista de votos
        public void MostrarVotos()
        {
            Console.WriteLine($"Lista de votos de {nombre} {apellido}:");
            foreach (var propuesta in votosPorPropuesta)
            {
                Console.WriteLine($"Propuesta: {propuesta.Key}");
                foreach (var voto in propuesta.Value)
                {
                    Console.WriteLine($"Voto: {voto}");
                }
            }
        }

        // En la clase Legislador (y sus subclases Diputado y Senador)
        public void PresentarPropuestaLegislativa(string propuesta)
        {
            propuestasLegislativas.Add(propuesta);
        }

        // Método para mostrar las propuestas legislativas
        public void ListarPropuestasLegislativas()
        {
            Console.WriteLine($"Propuestas legislativas de {nombre} {apellido}:");
            foreach (var propuesta in propuestasLegislativas)
            {
                Console.WriteLine(propuesta);
            }
        }
    }
}
