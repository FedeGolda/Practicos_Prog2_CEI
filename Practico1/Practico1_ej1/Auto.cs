using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1_ej1
{
    internal class Auto
    {
        // Declaracion de variables (propiedades) de la clase Auto. Solo puedo acceder desde la clase Auto
        private string tapiceria;
        private string climatizador;

        public Auto() // Constructor del estado inicial. No recibe parametros, solo inicializa el objeto que lo llame
        {
            tapiceria = "tela";
            climatizador = "compresor";
        }

        public Auto(string infoTapiceria, string tipoClimatizador) // Sobrecarga de constructores
        {
            tapiceria = infoTapiceria;
            climatizador = tipoClimatizador;
        }

        // ------------------------------ Getters y Setters ---------------------

        public string GetTapiceria()
        {
            return "Tapiceria:" + tapiceria;
        }
        public string GetTipoClimatizador()
        {
            return "Climatizador:" + climatizador;
        }
        public void SetTapiceria(string infoTapiceria)
        {
            this.tapiceria = infoTapiceria;
        }

        public void SetTipoClimatizador(string tipoClimatizador)
        {
            this.climatizador = tipoClimatizador;
        }

    }
}
