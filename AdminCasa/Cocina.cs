using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCasa
{
    internal class Cocina : Casa
    {
        protected bool tieneHorno;

        public Cocina(bool tieneHorno, int numero, int metros) : base(numero, metros)
        {
            this.tieneHorno = tieneHorno;
        }

        public bool getTieneHorno()
        {
            return tieneHorno;
        }

        public void setTieneHorno(bool tieneHorno)
        {
            this.tieneHorno = tieneHorno;
        }

        public override void Descripcion()
        {
            base.Descripcion();
            Console.WriteLine("**********************************************");
            Console.WriteLine($"\nTiene una cocina con horno: {(tieneHorno ? "Sí" : "No")}");
            Console.WriteLine("**********************************************");
        }
    }
}
