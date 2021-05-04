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
                MainMenu.MenuPrincipal();
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
                MainMenu.MainMenuDate();
                int optionFecha = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Recuerda que para salir del programa debes pulsar cero");
                switch (optionFecha)
                {
                    case 0:
                        break;
                    case 1: Utils.AskUser(ListaFecha);
                        break;
                    case 2: Utils.SortList(ListaFecha);//ordena la lista
                        break;
                    case 3:
                        Utils.GotoList(ListaFecha);//imprime la lista ya ordenada y recorrerla
                        break;
                    default: Console.WriteLine("Ninguna de las opciones a eleguir ha sido seleccionada");
                        break;
                }
            }
            while(true)
            {
                MainMenu.Mainemployees();
                int Option = Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1: 
                }
            }
        }
    }
}
/*Ejercicio 6:
 class alumno{
    int edad;
    string nombre;
    List<float> listanotas;
}

 public void SetLista(float nota)
{
    listanotas.Add(nota);
}
recibir nota y que la devuela
public void BorraNota(int pos)
{
    listanotas.Remove(pos);
}

 MAIN()
{
    listaumno[i].Borranota(pos);
}

//imprimir las notas de un alumno
//método de la clase
for(int i = 0; i < listaAlum,no.Count; i++)
{
    if(nombre == ListaAlumno[i].ListaAlumnos.GetNombre())
        ListaAlumno[i].ImrpimeNotas()
}

 ordenar
List<tlista>
if(Lista[i].Getnombre()...)
if(cod1.CompareTo(cad2))*/
