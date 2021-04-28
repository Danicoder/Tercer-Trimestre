using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class Utils
    {

        // Creamos la lista
        List<tpersona> LeerDatos = new List<tpersona>();
        List<fecha> LeerFecha = new List<fecha>();

        /*al ser una funcion de la propia clase tengo que poner static, de lo 
        contario me exigiría en el program colocar un objeto como referencia del mismo.*/
        public static void MenuPrincipal()
        {
            Console.WriteLine("¿Qué opción quieres?");
            Console.WriteLine("1) Deseas insertar datos de un empleado");
            Console.WriteLine("2) Deseas imprimir los datos del empleado");
            Console.WriteLine("3) Deseas salir del menu");
        }
        //solicitar datos
        public static void SolicitarDatos(List<tpersona> Lalista)
        {
            //creo un objeto persona
            tpersona datosPersona = new tpersona();
            char respuesta;
            do
            {
                Console.WriteLine("Escribe el nombre");
                datosPersona.Setnombre(Console.ReadLine());
                Console.WriteLine("Escribe el edad");
                datosPersona.SetEdad(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Escribe el teléfono");
                datosPersona.Settelefono(Console.ReadLine());
                Console.WriteLine("Escribe el sexo");
                datosPersona.Setsexo(Console.ReadLine());
                Console.WriteLine("Estado Civil (casado/soltero): ");
                if (Console.ReadLine() == "casado")
                    datosPersona.Setcasado(true);
                else datosPersona.Setcasado(false);
                Console.WriteLine("¿Deseas seguir insertando más empleados? (s/n)");
                respuesta = Convert.ToChar(Console.ReadLine());

                Lalista.Add(datosPersona); 
            }
            while(respuesta == 's');
        }
        public static void PrintSaveData(List<tpersona> Lalista)
        {
            if (Lalista.Count == 0)
                Console.WriteLine("No hay empleados disponibles.");
            else
            {
                for (int i = 0; i < Lalista.Count; i++)
                    Lalista[i].imprimirpersona();
            }
        }
        public static void AskUser(List<fecha> Datadates)
        {
            fecha SaveDatas = new fecha();

            Console.WriteLine("Dime el mes");
            SaveDatas.Setmes(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Dime el día");
            SaveDatas.Setdia(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Dime el año");
            SaveDatas.Setyear(Convert.ToInt32(Console.ReadLine()));

            Datadates.Add(SaveDatas);
        }
        
    }
}
