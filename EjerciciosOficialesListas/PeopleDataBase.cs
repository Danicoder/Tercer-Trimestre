using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class PeopleDataBase
    {
        /*Lee los datos de una persona y otro para imprimir los datos de todas las personas.*/
        List<tpersona> LeerDatos = new List<tpersona>();
        //preguntar los datos e introducirlos

        public void AddDatosPersona(tpersona tipoPersona) //guarda los atibutos de dicha clase
        {
            LeerDatos.Add(tipoPersona);
        }
    }
}
