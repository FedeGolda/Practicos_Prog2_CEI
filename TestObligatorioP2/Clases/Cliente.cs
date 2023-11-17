using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestObligatorioP2.Clases
{
    public class Cliente
    {
        private string cedula;

        public Cliente (string cedula)
        {
            this.cedula = cedula;
        }

        public string getCedula() { return cedula; }
        public void setCedula(string cedula) { this.cedula = cedula; }

    }
}