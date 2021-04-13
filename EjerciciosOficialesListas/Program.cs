using System;

namespace EjerciciosOficialesListas
{
    class Program
    {
        static void Main()
        {
            tpersona Person1 = new tpersona();
            PeopleDataBase datos = new PeopleDataBase();

            Person1.SetEdad(25);
            Person1.Setnombre("Manuel");
            Person1.Settelefono("6428567892");
            Person1.Setsexo("Masculino");
            Person1.Setcasado(true);

            datos.AddDatosPersona(SetEdad);

            Console.WriteLine("La edad es:{0} ",Person1.Getedad());
            Console.WriteLine("El nombre es:{0} ", Person1.Getnombre());
            Console.WriteLine("El teléfono es:{0} ", Person1.Gettelefono());
            Console.WriteLine("El Sexo es:{0} ", Person1.Getsexo());
            if(Person1.Getcasado() == true)
            {
                Console.WriteLine("Es casado ");
            }
            else Console.WriteLine("No es casado ");
        }
    }
}
