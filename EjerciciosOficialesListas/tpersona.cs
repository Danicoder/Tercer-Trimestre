﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class tpersona
    {
        /*Crear la clase para almacenar los datos de una persona.*/

        string nombre;
        int edad;
        string telefono;
        string sexo;
        bool casado;

        public void SetEdad(int edad){this.edad = edad;}
        public int Getedad(){ return this.edad;}
        public void Setnombre(string nombre){this.nombre = nombre;}
        public string Getnombre(){return this.nombre;}
        public void Settelefono(string telefono){this.telefono = telefono;}
        public string Gettelefono(){return telefono;}
        public void Setsexo(string sexo){this.sexo = sexo;}
        public string Getsexo(){return this.sexo;}
        public void Setcasado(bool casado){this.casado = casado;}
        public bool Getcasado(){return this.casado;}
        //imprimir los datos de todas las personas
        public void imprimirpersona()
        {
            Console.WriteLine("Nombre: ", nombre);
            Console.WriteLine("Edad: ", edad);
            Console.WriteLine("Teléfono: ", telefono);
            Console.WriteLine("Sexo: ", sexo);
            if (casado == true)
            {
                Console.WriteLine("Es casado ");
            }
            else Console.WriteLine("No es casado ");
        }
    }
}
