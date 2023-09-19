using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa
{
    internal class Casa
    {

        //atributo
        protected double ancho;
        protected double largo;
        protected double alto;
        protected string color;
        protected double alquiler;

        //constructor se llaman igual que la clase
        public Casa()
        {
            this.ancho = 2;
            this.largo = 2;
            this.alto = 3;  
            this.color = "blanco";
            this.alquiler = 3000;
        }

        public Casa(double ancho, double largo, double alto, string color, double alquiler)
        {
            this.ancho = ancho;
            this.largo = largo;
            this.alto = alto;
            this.color = color;
            this.alquiler = alquiler;
        }

        //get y set
        public double getAncho()=>this.ancho; //expresion lamda
        
        public double getLargo()
        {
            return this.largo;
        }
        public double getAlto()
        {
            return this.alto;
        }
        public string getColor()
        {
            return this.color;
        }
        public double getAlquiler()
        {
            return this.alquiler;
        }
        public void setAncho(double ancho)=>this.ancho = ancho; //expresion lamda

        public void setLargo(double largo)
        {
            this.largo = largo;
        }
        public void setAlto(double alto)
        {
            this.alto = alto;
        }
        public void setColor(String color)
        {
            this.color = color;
        }
        public void setAlquiler(double alquiler)
        {
            this.alquiler = alquiler;
        }

        //metodo polimorfico
        public virtual void infoPintura()
        {
            Console.WriteLine("esta habitacion se pinto con productos de primer nivel");
        }
        public virtual double metrosPintura()
        {
            double metrosPi = metrosCuadradosTecho() + metrosCuadradosPared();
            return metrosPi;
        }

        //metodos de trabajos
        public double metrosCuadradosTecho()
        {
            double metrosT = getAncho()*getLargo();
            return metrosT;
        }

        public double metrosCuadradosPared()
        {
            double metrosP = (getAncho() * getAlto())*2 + (getLargo() * getAlto())*2;
            return metrosP;
        }

        
    }
}
