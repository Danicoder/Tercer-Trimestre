using System;
using System.Collections.Generic;
namespace EjerciciosOficialesListas
{
    class Program
    {
        static void Main()
        {
            List<tpersona> ListaEmpleados = new List<tpersona>();
            List<fecha> ListaFecha = new List<fecha>();

                comienzo:
                funciones.MenuPrincipal();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        funciones.SolicitarDatos(ListaEmpleados);
                        goto comienzo;
                    case 2:
                        funciones.PrintSaveData(ListaEmpleados);
                        break;
                    case 3: break;
                }
        }
    }
}
