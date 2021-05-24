using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesDatos
{
    class Cliente
    {
        string nombre;
        string dni;
        string direccion;

        public void SetNombre(string nombre) { this.nombre = nombre; }
        public void SetDni(string DNI) { this.dni = DNI; }
        public void SetDirección(string direccion) { this.direccion = direccion; }

        public string Getnombre() { return nombre; }
        public string Getdni() { return dni; }
        public string Getdireccion() { return direccion; }
    }
}
