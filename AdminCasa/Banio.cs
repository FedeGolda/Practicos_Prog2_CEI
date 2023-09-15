using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCasa
{
    internal class Banio : Casa
    {
        private bool tieneDucha;

        public Banio(bool tieneDucha, int numero, int metros) : base(numero, metros)
        {
            this.tieneDucha = tieneDucha;
        }

        public bool getTieneDucha()
        {
            return tieneDucha;
        }

        public void setTieneDucha(bool tieneDucha)
        {
            this.tieneDucha = tieneDucha;
        }

        public override void Descripcion()
        {
            Console.WriteLine("Tiene un baño con ducha: {0}", tieneDucha ? "Sí" : "No");
        }
    }
}
