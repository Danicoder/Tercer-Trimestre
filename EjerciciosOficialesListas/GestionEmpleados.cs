using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class GestionEmpleados
    {
        List<tEmpleado> ReadEmployes = new List<tEmpleado>();

        //obtener datos del empleado
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
        public static void AddList(List<tEmpleado> Lista)
        {
            tEmpleado salesQuantity = new tEmpleado();
            Console.WriteLine("nombre del empleado");
            salesQuantity.SetnombreVendedor(Console.ReadLine());
            Console.WriteLine("¿Cúantas ventas ha hecho el empleado?");
            salesQuantity.SetcantidadVentas(Convert.ToInt64(Console.ReadLine()));

            Lista.Add(salesQuantity);
        }
        //Solicitar fecha de cumpleaños del empleado y guardarlo

    }
}
