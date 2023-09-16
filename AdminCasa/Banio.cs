using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCasa
{
    internal class Banio : Casa
    {
        protected string tieneDucha;

        public Banio(string tieneDucha, int numero, int metros) : base(numero, metros)
        {
            this.tieneDucha = tieneDucha;
        }

        public string getTieneDucha()
        {
            return tieneDucha;
        }

        public void setTieneDucha(string tieneDucha)
        {
            this.tieneDucha = tieneDucha;
        }

        public override void Descripcion()
        {
            base.Descripcion();
            Console.WriteLine($"\nTiene un baño con ducha: " + tieneDucha);
        }
    }

}
