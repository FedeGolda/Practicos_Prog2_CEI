using System.Globalization;

namespace Practico1_ej7
{
    internal class Remito : Impresora
    {
        private int cantBultos;
        private DateTime fecha;
        private int numero;


        public Remito()
        {
            cantBultos = 10;
            fecha = DateTime.ParseExact("24/09/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            numero = 2;
        }


        public int GetCantBultos()
        {
            return cantBultos;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }

        public int GetNumero()
        {
            return numero;
        }

        public void SetCantBultos(int cantBultos)
        {
            this.cantBultos = cantBultos;
        }

        public void SetFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }
    }
}
