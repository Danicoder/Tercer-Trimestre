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

            while (true)
            {
                Utils.MenuPrincipal();
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Recuerda que si quieres salir del programa debes pulsar 0");
                if (option == 0)
                    break;
                switch (option)
                {
                    case 1:
                        Utils.SolicitarDatos(ListaEmpleados);
                        break;
                    case 2:
                        Utils.PrintSaveData(ListaEmpleados);//recorre la lista
                        break;
                    case 3: break;
                    default:
                        System.Console.WriteLine("Valor  incorrecto");
                        break;
                }
            }

            while (true)
            {
                Utils.MainMenuDate();
                int optionFecha = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Recuerda que para salir del programa debes pulsar cero");
                switch (optionFecha)
                {
                    case 0:
                        break;
                    case 1: Utils.AskUser(ListaFecha);
                        break;
                    case 2: Utils.SortList(ListaFecha);//ordena la lista
                            Utils.GotoList(ListaFecha);//recorre la lista
                        break;
                    case 3:
                        Utils.GotoList(ListaFecha);//imprime la lista ya ordenada y recorrerla
                        break;
                    default: Console.WriteLine("Ninguna de las opciones a eleguir ha sido seleccionada");
                        break;
                }
            }
        }
    }
}
