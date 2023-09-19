// Clase Baño que hereda de Casa
using System;

namespace Casa
{
    internal class Baño : Casa
    {
        // Sobrescribir el método infoPintura para el baño
        public override void infoPintura()
        {
            Console.WriteLine("* Esta habitación tiene azulejos");
        }

        // Sobrescribir el método metrosPintura para el baño
        public override double metrosPintura()
        {
            Console.WriteLine("* NO PINTAR BAÑO PORQUE TIENE AZULEJOS");
            return 0;
        }
    }
}
