using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitco1_ej2
{
    internal class Alumno
    {
        private string? nombre;
        private int edad;
/*
        public Alumno()
        {
            nombre = "Fede";
            edad = 30;
        }
*/
        public Alumno(string infoNombre, int infoEdad)
        {
            nombre = infoNombre;
            edad = infoEdad;
        }


        public string imprimirNombre()
        {
            return "* Nombre: " + nombre;
        }

        public string imprimirNombreEdad()
        {
            return "* Nombre y edad: " + nombre + ", " + edad;
        }

        public void setNombre(string infoNombre)
        {
            this.nombre = infoNombre;
        }

        public void setEdad(int infoEdad)
        { 
            this.edad = infoEdad;
        }

    }
}