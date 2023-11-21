using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio2023Prog2
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public bool verClientes { get; set; }
        public bool verUsuario { get; set; }
        public bool verVentas { get; set; }
        public bool verVehiculos { get; set; }
        public bool verAlquileres { get; set; }

        public Usuario()
        {
            
        }
        public Usuario(string nombre, string contraseña, bool verClientes, bool verUsuario, bool verVentas, bool verVehiculos, bool verAlquileres)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.verClientes = verClientes;
            this.verUsuario = verUsuario;
            this.verVentas = verVentas;
            this.verVehiculos = verVehiculos;
            this.verAlquileres = verAlquileres;
        }
        public string getNombre() { return nombre; }
        public string getContraseña() { return contraseña; }
        public bool getVerClientes() { return verClientes; }
        public bool getVerVentas() { return verVentas; }
        public bool getVerAlquileres() { return verAlquileres; }
        public bool getVerUsuarios() { return verUsuario; }
        public bool getVerVehiculos() { return verVehiculos; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setContraseña(string contraseña) { this.contraseña = contraseña; }
        public void setVerClientes(bool verClientes) { this.verClientes = verClientes; }
        public void setVerVentas(bool verVentas) { this.verVentas = verVentas; }
        public void setVerAlquileres(bool verAlquileres) { this.verAlquileres = verAlquileres; }
        public void setVerUsuarios(bool verUsuario) { this.verUsuario = verUsuario; }
        public void setVerVehiculos(bool verVehiculos) { this.verVehiculos = verVehiculos; }
    }
}