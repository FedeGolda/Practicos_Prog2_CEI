using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }

        public string getCedula()
        {
            return Cedula;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getApellido()
        {
            return Apellido;
        }

        public string getDireccion()
        {
            return Direccion;
        }

        public void setCedula(string cedula)
        {
            Cedula = cedula;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            Apellido = apellido;
        }

        public void setDireccion(string direccion)
        {
            Direccion = direccion;
        }


        // Función para verificar el último dígito de la cédula uruguaya
        public bool ValidarCedulaUruguaya()
        {
            // Verificar si la cédula tiene al menos 8 dígitos
            if (Cedula.Length != 8)
            {
                // Mensaje de depuración
                Console.WriteLine("Longitud de cédula incorrecta.");
                return false;
            }

            // Obtener los primeros 7 dígitos de la cédula
            string digitos = Cedula.Substring(0, 7);

            // Obtener el último dígito de la cédula
            int ultimoDigito = int.Parse(Cedula.Substring(7, 1));

            // Calcular el dígito verificador esperado
            int suma = digitos.Reverse()
                               .Select((c, i) => (c - '0') * (i % 2 == 0 ? 1 : 2))
                               .Sum(n => n / 10 + n % 10);

            int digitoVerificadorEsperado = (10 - (suma % 10)) % 10;

            // Mensajes de depuración
            Console.WriteLine("Último dígito: " + ultimoDigito);
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Dígito verificador esperado: " + digitoVerificadorEsperado);

            // Verificar si el último dígito coincide con el esperado
            return ultimoDigito == digitoVerificadorEsperado;
        }

    }
}