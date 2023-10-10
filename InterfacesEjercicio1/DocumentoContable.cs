using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace InterfacesEjercicio1
{
    internal  abstract class DocumentoContable : Iimprimible
    {
        private DateTime fecha;
        private double importe;
        private int numero;
        private string sigla;

        public DocumentoContable(string sigla, int numero, double importe)
        {
            fecha = DateTime.Now;
            this.sigla = sigla;
            this.numero = numero;
            this.importe = importe;
        }
        public DateTime getFecha() { return fecha; }
        public void setFecha(DateTime fecha) { this.fecha = fecha; }
        
        public double getImporte() { return importe; }
        public void setImporte(double importe) { this.importe = importe; }
        
        public int getNumero() { return numero; }
        public void setNumero(int numero) { this.numero = numero; }
        
        public string getSigla() { return sigla; }
        public void setSigla(string sigla) { this.sigla = sigla; }

        //Metodos obligatorios
        public  void Imprimir() // NotaCredito y Factura, imprimen de la misma forma. Entonces puedo desarrollar
                                // todo en la clase Padre. Pero este no es el caso de los impuestos del ejercicio 6.
                                // Es conveniente desarrollar un metodo abstracto en la clase Impuesto, para ser desarrollado
                                // en las clases FacturaLuz y Municipal
        {
            Console.WriteLine($"Impresion de {sigla} de ${total()} del dia {fecha}");
        }
        public abstract double total();
        
    }
}
