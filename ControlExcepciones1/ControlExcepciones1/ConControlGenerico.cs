using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepciones1
{
    internal class ConControlGenerico
    {
        int dividendo;
        int divisor;
        int cociente;
        public void NumeroNatural(string dividendo,string divisor)
        {
            try
            {
                this.dividendo = int.Parse(dividendo);
                Console.WriteLine($"El dividendo ingrsado es {this.dividendo}");
                this.divisor = int.Parse(divisor);
                Console.WriteLine($"El divisor ingrsado es {this.divisor}");
                cociente=this.dividendo/this.divisor;
                Console.WriteLine($"El cociente es {cociente}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void IOExceptionDos(string rutaArchivo)
        {
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                int contador = 0;
                archivo = new System.IO.StreamReader(rutaArchivo); //consume recursos
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
            finally //asegura que el flujo pase por aqui y ejecuta lo que este dentro del finally
            {
                if(archivo!=null) archivo.Close();
                Console.WriteLine("conexion cerrada");
            }
        }
    }   
}
