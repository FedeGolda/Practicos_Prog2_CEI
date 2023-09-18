using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCasa
{
    internal class Cocina : Casa
    {
        protected string tieneHorno;

        public Cocina(string tieneHorno, int numero, int metros) : base(numero, metros)
        {
            this.tieneHorno = tieneHorno;
        }

        public string getTieneHorno()
        {
            return tieneHorno;
        }

        public void setTieneHorno(string tieneHorno)
        {
            this.tieneHorno = tieneHorno;
        }

        public override void Descripcion()
        {
            base.Descripcion();
            Console.WriteLine($"\n¿Cocina con horno?: " + tieneHorno);
        }
    }
}
