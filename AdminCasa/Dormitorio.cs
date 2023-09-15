using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCasa
{
    internal class Dormitorio : Casa
    {
        private int numeroCamas;
        public Dormitorio(int numeroCamas, int numero, int metros) : base(numero, metros)
        {
            this.numeroCamas = numeroCamas;
        }

        public int getNumeroCamas() 
        {  
            return numeroCamas; 
        }

        public void setNumeroCamas(int numeroCamas)
        {
            this.numeroCamas = numeroCamas;
        }

        public override void Descripcion()
        {
            Console.WriteLine("Tiene {0} camas en el dormitorio.", numeroCamas);
        }

    }
}
