using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepciones1
{
    internal class SinControl
    {
        double resultado = 0;
        int[] numeros = { 1, 2, 3 };
        string texto = null;

        public void DivideByZeroException(int dividendo, int divisor)
        {
            this.resultado = dividendo / divisor;
            Console.WriteLine($"Con un dividendo: {dividendo} y un divisor: {divisor}, " +
                $"el resultado de la division es: {resultado}");
        }
        public void IndexOutOfRangeException(int indice)
        {
            Console.WriteLine($"Para el indice {indice}, el arreglo contiene un: {numeros[indice]}"); 
        }      
        public void NullReferenceException(string texto)
        {
            this.texto = texto;
            int longitud = texto.Length;
            Console.WriteLine($"La longitud del texto es: {longitud}");
        }
        public void FormatException(string texto)
        {
            int numero = int.Parse(texto);
            Console.WriteLine($"El numero es: {numero}");
        }
        public void IOException(string rutaArchivo)//Dejar el archivo en ..bin/Debug
        {
            string contenido = File.ReadAllText(rutaArchivo);
            Console.Write("Contenido del archivo es: ");
            Console.WriteLine(contenido);
        }
        public void OverFlowException(int numero)
        {
            Console.WriteLine($"El numero {numero} mas 1 es: {numero+1}");//Rendimiento
            Console.Write("Vuelvo a imprimir con cheked: ");
            checked
            {
                Console.WriteLine(numero + 1);
            }
        }
    }
}
