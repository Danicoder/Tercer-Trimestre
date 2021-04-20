using System;
using System.Collections.Generic;
namespace EjerciciosOficialesListas
{
    class Program
    {
        static void Main()
        {
            List<tpersona> ListaEmpleados = new List<tpersona>();
            List<tpersona> LeerDatos = new List<tpersona>();
            
            //creo una persona
            tpersona Person1 = new tpersona();

            Person1.SetEdad(25);
            Person1.Setnombre("Manuel");
            Person1.Settelefono("6428567892");
            Person1.Setsexo("Masculino");
            Person1.Setcasado(true);
        }
    }
}
