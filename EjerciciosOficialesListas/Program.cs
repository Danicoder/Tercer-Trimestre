using System;
using System.Collections.Generic;
namespace EjerciciosOficialesListas
{
    class Program
    {
        static void Main()
        {
            List<tpersona> ListaEmpleados = new List<tpersona>();

            funciones.MenuPrincipal();
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1: funciones.SolicitarDatos(ListaEmpleados);
                        break;
                case 2: tpersona.imprimirpersona();
            }
        }
    }
}
