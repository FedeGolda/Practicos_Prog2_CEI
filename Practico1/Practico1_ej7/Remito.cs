namespace Practico1_ej7
{
    internal class Remito : Impresora
    {
        private int cantBultos;
        private int fecha;
        private int numero;


        public Remito()
        {
            cantBultos = 10;
            fecha = 20223;
            numero = 2;
        }


        public int GetCantBultos()
        {
            return cantBultos;
        }

        public int GetFecha()
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

        public void SetFecha(int fecha)
        {
            this.fecha = fecha;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }
    }
}
