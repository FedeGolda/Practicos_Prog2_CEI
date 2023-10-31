using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Sucursal
    {
        private int numero;
        private string direccion;
        private List<Vehiculo> colVehiculos; // Relacion de Asociacion. Tengo una lista de Vehiculos 1 ---> 1..*

        public Sucursal(int numero, string direccion, List<Vehiculo> colVehiculos)
        {
            this.numero = numero;
            this.direccion = direccion;
            this.colVehiculos = colVehiculos;
        }

        public int getNumero() => this.numero;
        public void setNumero(int numero) => this.numero = numero;
        public string getDireccion() => this.direccion;
        public void setDireccion(string direccion) => this.direccion = direccion;
        public List<Vehiculo> getVehiculos() => this.colVehiculos;
        public void setColVehiculos(List<Vehiculo> colVehiculos) => this.colVehiculos = colVehiculos;

    }
}
