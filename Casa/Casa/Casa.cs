using System;

namespace Casa
{
    internal class Casa
    {
        // Atributos de la clase Casa
        protected double ancho;
        protected double largo;
        protected double alto;
        protected string color;

        // Constructor sin parámetros
        public Casa()
        {
            // Valores predeterminados
            this.ancho = 2;
            this.largo = 2;
            this.alto = 3;
            this.color = "blanco";
        }

        // Constructor con parámetros personalizables
        public Casa(double ancho, double largo, double alto, string color)
        {
            this.ancho = ancho;
            this.largo = largo;
            this.alto = alto;
            this.color = color;
        }

        // Métodos para obtener los atributos (getters)
        public double getAncho() => this.ancho; // Expresión lambda

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

        // Métodos para establecer los atributos (setters)
        public void setAncho(double ancho) => this.ancho = ancho; // Expresión lambda

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

        // Método polimórfico para obtener información sobre la pintura
        public virtual void infoPintura()
        {
            Console.WriteLine("Esta habitación se pintó con productos de primer nivel");
        }

        // Método polimórfico para calcular la cantidad de pintura requerida en metros cuadrados
        public virtual double metrosPintura()
        {
            double metrosPi = metrosCuadradosTecho() + metrosCuadradosPared();
            return metrosPi;
        }

        // Métodos para calcular áreas en metros cuadrados
        public double metrosCuadradosTecho()
        {
            double metrosT = getAncho() * getLargo();
            return metrosT;
        }

        public double metrosCuadradosPared()
        {
            double metrosP = (getAncho() * getAlto()) * 2 + (getLargo() * getAlto()) * 2;
            return metrosP;
        }
    }
}
