namespace Practico1_ej7
{
    internal class Remito
    {
        private int CantBultos;
        private int fecha;
        private int numero;

        public int GetCantBultos()
        {
            return CantBultos;
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
            CantBultos = cantBultos;
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
