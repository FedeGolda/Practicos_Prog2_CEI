using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCasa
{
    internal class Dormitorio : Casa
    {
        protected int numeroCamas;
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
        /*
        public override void Descripcion()
        {
            Console.WriteLine("Tiene " + numeroCamas + "camas en el dormitorio.");
        }
        */
        public override void Descripcion()
        {
            base.Descripcion(); // Llama al método Descripcion de la clase base para imprimir los datos comunes
            Console.WriteLine($"\nCantidad camas Dormitorio: {numeroCamas}");
        }


    }
}
