using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class tpersona
    {
        /*Crear la clase (Orientado a Objetos) necesaria para almacenar los datos de una persona.
        Los datos que se quieren almacenar serán su nombre, edad, teléfono, sexo y si está
        casado. Tendremos un botón desde el que leeremos los datos y otro botón desde el que
        los mostraremos. (Ejercicio Resuelto).*/

        string nombre;
        int edad;
        string telefono;
        string sexo;
        bool casado;

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public int Getedad()
        {
            return this.edad;
        }
        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string Getnombre()
        {
            return this.nombre;
        }
        public void Settelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public string Gettelefono()
        {
            return telefono;
        }
        public void Setsexo(string sexo)
        {
            this.sexo = sexo;
        }
        public string Getsexo()
        {
            return this.sexo;
        }
        public void Setcasado(bool casado)
        {
            this.casado = casado;
        }
        public bool Getcasado()
        {
            return this.casado;
        }
        /*Apoyándoos en el ejercicio anterior, realizar un programa que trabaje con una lista de
        personas. Realizar un botón para leer los datos de una persona y otro para imprimir los
        datos de todas las personas.*/
    }
}
