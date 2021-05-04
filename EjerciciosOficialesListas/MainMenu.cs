using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class MainMenu
    {
        /*al ser una funcion de la propia clase tengo que poner static, de lo 
        contario me exigiría en el program colocar un objeto como referencia del mismo.*/
        public static void MenuPrincipal()
        {
            Console.WriteLine("¿Qué opción quieres?");
            Console.WriteLine("1) Deseas insertar datos de un empleado");
            Console.WriteLine("2) Deseas imprimir los datos del empleado");
            Console.WriteLine("3) Deseas salir del menu");
        }
        public static void MainMenuDate()
        {
            Console.WriteLine("¿Qué opción quieres?");
            Console.WriteLine("------------------------");
            Console.WriteLine("1) Deseas introducir la fecha");
            Console.WriteLine("2) Deseas ordenar la lista");
            Console.WriteLine("3) Deseas imprimir la lista");
        }
        public static void Mainemployees()
        {
            Console.WriteLine("¿Qué opción quieres?");
            Console.WriteLine("------------------------");
            Console.WriteLine("1) Introducir un nuevo empleado");
            Console.WriteLine("2) Añadir venta");
            Console.WriteLine("3) Mostrar la lista de empleados");
            Console.WriteLine("4) Cumpleaños del empleado");
        }
    }
}
