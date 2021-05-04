using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class tEmpleado
    {
        string nombre;
        string nombreVendedor;
        int edad;
        string telefono;
        string sexo;
        float cantidadVentas;
        string FechaCumpleaños;

        public void SetEdad(int edad) { this.edad = edad; }
        public int Getedad() { return edad; }
        public void Setnombre(string nombre) { this.nombre = nombre; }
        public string Getnombre() { return nombre; }
        public void SetnombreVendedor(string nombreVendedor) { this.nombreVendedor = nombreVendedor; }
        public string GetnombreVendedor() { return nombreVendedor; }
        public void Settelefono(string telefono) { this.telefono = telefono; }
        public string Gettelefono() { return telefono; }
        public void Setsexo(string sexo) { this.sexo = sexo; }
        public string Getsexo() { return sexo; }
        public void SetcantidadVentas(float nVentas) { this.cantidadVentas = nVentas; }
        public bool GetcantidadVentas() { return cantidadVentas; }
        public void SetBirtday(string Cumpleaños) { FechaCumpleaños = Cumpleaños; }
        public bool GetBirtday() { return FechaCumpleaños; }

        public void imprimirpersona()
        {
            Console.WriteLine("Datos del Empelado: ");
            Console.WriteLine("___________________");
            Console.WriteLine("Nombre: {0} ", nombre);
            Console.WriteLine("Edad: {0}", edad);
            Console.WriteLine("Teléfono: {0}", telefono);
            Console.WriteLine("Número de ventas: {0}", cantidadVentas);
            if (cantidadVentas == true)
            {
                Console.WriteLine("Ha vendndido");
            }
            else Console.WriteLine("No tiene ningúna venta");
        }     
    }
}
