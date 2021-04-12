using System;

namespace Clase
{
    class Program
    {
        static void Main()
        {
            tEmpleado Empleado1 = new tEmpleado();
            directivo Persona1 = new directivo();

            Console.WriteLine("Introduzca la edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            Empleado1.setEdad(edad);
            Empleado1.Imprime();
            Empleado1.MayorMenor();

            Console.WriteLine("¿Cúal es tu cargo en la empresa?");
            string cargo = Console.ReadLine();

            Persona1.SetCargo(cargo);
        }
    }
}
