using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepciones1
{
    internal class ConControl
    {
        double resultado = 0;
        int[] numeros = { 1, 2, 3 };
        string texto = null;

        public void DivideByZeroException(int dividendo, int divisor)
        {
            try
            {
                this.resultado = dividendo / divisor;
                Console.WriteLine($"Con un dividendo: {dividendo} y un divisor: {divisor}," +
                    $" el resultado de la division es: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Intento de división por cero.");
                Console.WriteLine(ex.Message);
            }          
        }
        public void IndexOutOfRangeException(int indice)
        {
            try
            {
                Console.WriteLine($"Para el indice {indice}, el arreglo contiene un: {numeros[indice]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Índice fuera de rango.");
                Console.WriteLine(ex.Message);
            }
        }
        public void NullReferenceException(string texto)
        {         
            try
            {
                this.texto = texto;
                int longitud = texto.Length;
                Console.WriteLine($"La longitud del texto es: {longitud}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: Referencia nula.");
                Console.WriteLine(ex.Message);
            }
        }
        public void FormatException(string texto)
        {            
            try
            {
                int numero = int.Parse(texto);
                Console.WriteLine($"El numero es: {numero}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Formato incorrecto.");
                Console.WriteLine(ex.Message);
            }
        }
        public void IOException(string rutaArchivo)//Dejar el archivo en ..bin/Debug
        {
            try
            {
                string contenido = File.ReadAllText(rutaArchivo);
                Console.Write("Contenido del archivo es: ");
                Console.WriteLine(contenido);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error de E/S.");
                Console.WriteLine(ex.Message);
            }
        }

        public void OverFlowException(int numero)
        {
            try
            {
                Console.WriteLine($"El numero {numero} mas 1 es: {numero + 1}");//Rendimiento
                Console.Write("Vuelvo a imprimir con cheked: ");
                checked
                {
                    Console.WriteLine(numero + 1);
                }
                //Console.WriteLine(checked(numero + 1));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error de E/S.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
