using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        protected string PartidoPolitico;
        protected string Departamento;
        protected int NumDespacho;
        protected string Nombre;
        protected string Apellido;
        protected int Edad;
        protected bool Casado;


        // Lista de votos del legislador

        public List<string> PropuestasLegislativas { get; private set; }

        private List<string> votos = new List<string>(); // Agregar una lista para rastrear los votos


        // Constructor
        public Legislador(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado)
        {
            PartidoPolitico = partidoPolitico;
            Departamento = departamentoQueRepresenta;
            NumDespacho = numDespacho;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Casado = casado;
            PropuestasLegislativas = new List<string>();
        }

        public string getPartidoPolitico()
        {
            return PartidoPolitico;
        }

        public string getDepartamento()
        {
            return Departamento;
        }

        public int getNumDespacho()
        {
            return NumDespacho;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getApellido()
        {
            return Apellido;
        }

        public int getEdad()
        {
            return Edad;
        }

        public bool getCasado()
        {
            return Casado;
        }


        // Método para registrar un voto
        public void RegistrarVoto(string voto)
        {
            votos.Add(voto);
        }

        // Método para obtener la lista de votos
        public List<string> ObtenerVotos()
        {
            return votos;
        }

        public void setPartidoPolitico(string partidoPolitico)
        {
            this.PartidoPolitico = partidoPolitico;
        }

        public void setDepartamento(string departamentoQueRepresenta)
        {
            this.Departamento = departamentoQueRepresenta;
        }

        public void setNumDespacho(int numDespacho)
        {
            this.NumDespacho = numDespacho;
        }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            this.Apellido = apellido;
        }

        public void setEdad(int edad)
        {
            this.Edad = edad;
        }

        public void setCasado(bool casado)
        {
            this.Casado = casado;
        }

        public string getCamara()
        {
            if (Edad > 30)
            {
                return "Senador";
            }
            else
            {
                return "Diputados";
            }
        }

        // Método para registrar un voto
        public void RegistrarVoto(string proyectoDeLey, string voto)
        {
            string votoRegistrado = $"Proyecto: {proyectoDeLey}, Voto: {voto}";
            votos.Add(votoRegistrado);
        }

        // Método para mostrar la lista de votos
        public void MostrarVotos()
        {
            Console.WriteLine($"Lista de votos de {Nombre} {Apellido}:");
            foreach (var voto in votos)
            {
                Console.WriteLine(voto);
            }
        }



        // Método virtual para presentar una propuesta legislativa
        public virtual void PresentarPropuestaLegislativa(string propuesta)
        {
            Console.WriteLine($"{Nombre} {Apellido} del partido {PartidoPolitico} ha presentado la propuesta: '{propuesta}'");
            PropuestasLegislativas.Add(propuesta); // Agregar la propuesta a la lista de propuestas
        }


        // Método virtual para emitir un voto
        public virtual void Votar(string proyectoDeLey, Voto voto)
        {
            Console.WriteLine($"{Nombre} {Apellido} del partido {PartidoPolitico} ha votado '{voto}' en el proyecto de ley '{proyectoDeLey}'.");
        }

        // Método virtual para participar en un debate legislativo
        public virtual void ParticiparDebate(string temaDebate)
        {
            Console.WriteLine($"{Nombre} {Apellido} del partido {PartidoPolitico} ha participado en el debate sobre '{temaDebate}'.");
        }

    }

}
