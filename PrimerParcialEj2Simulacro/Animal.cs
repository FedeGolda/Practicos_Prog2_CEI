using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialEj2Simulacro
{
    internal class Animal
    {

        private string _nombre;
        private string _color;

        public Animal(string nombre, string color)
        {
            _nombre = nombre;
            _color = color;
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public void SetNombre(string nombre)
        {
            this._nombre = nombre;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {

            this._color = color;
        }

        public virtual void VozAnimal()
        {
            Console.WriteLine("Sonido genérico de animal.");
        }

        public virtual void Moverse()
        {
            Console.WriteLine("El animal se está moviendo.");
        }
    }

}
