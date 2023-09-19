using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa
{
    internal class Dormitorio:Casa
    {
        //atributos
        private string cama;
        
        //constructor 
        public Dormitorio(double ancho, double largo, double alto, string color, string cama):base( ancho,  largo,  alto, color)
        {
            this.cama = cama;
        } 
        
        public string getCama()
        {
            return this.cama; // no hace falta this
        }
        
    }
}
