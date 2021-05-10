using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class ListasEmpleados
    {
        List<tEmpleado> ReadEmployes = new List<tEmpleado>();

        //obtener datos del empleado nuevo
        public static void NewEmployee(List<tEmpleado> Lista)
        {
            tEmpleado Employee = new tEmpleado();

            char option;
            do
            {
                Console.WriteLine("Escribe el nombre");
                Employee.Setnombre(Console.ReadLine());
                Console.WriteLine("Escribe el edad");
                Employee.SetEdad(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Escribe el teléfono");
                Employee.Settelefono(Console.ReadLine());
                Console.WriteLine("Escribe el sexo");
                Employee.Setsexo(Console.ReadLine());
                Console.WriteLine("¿Deseas seguir insertando más empleados? (s/n)");
                option = Convert.ToChar(Console.ReadLine());

                Lista.Add(Employee);
            }
            while (option == 's');
        }
        //Opción de añadir venta
        public static void AddSale(List<tEmpleado> Lista)
        {
            tEmpleado salesQuantity = new tEmpleado();
            Console.WriteLine("nombre del empleado");
            salesQuantity.SetnombreVendedor(Console.ReadLine());
            Console.WriteLine("¿Cúantas ventas ha hecho el empleado?");
            salesQuantity.SetcantidadVentas(Convert.ToInt64(Console.ReadLine()));

            Lista.Add(salesQuantity);
        }
        //Solicitar fecha de cumpleaños del empleado y guardarlo
        /*El botón de Cumpleaños de Empleado pedirá el nombre del empleado y le
        sumarán un año llamando al método cumpleAnyos del objeto.*/
        public static void BirthdayDate(List<tEmpleado> Lista)
        {
            tEmpleado dateBirthday = new tEmpleado();
            Console.WriteLine("nombre del empleado");
            dateBirthday.Setnombre(Console.ReadLine());
            Console.WriteLine("teclea la fecha de cumpleaños");
            Console.WriteLine("Dime el día: ");
            Console.WriteLine("Dime el mes: ");
            Console.WriteLine("Dime el año: ");
            dateBirthday.SetBirtday(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            Lista.Add(dateBirthday);
        }
        public static void PrintEmployes(List<tEmpleado> ListEmployee)
        {
            for(int i = 0; i < ListEmployee.Count;i++)
            {
                ListEmployee[i].imprimirEmpleado();
            }
        }
    }
}
