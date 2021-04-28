using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class fecha
    {
        int mes, year, dia;
        List<fecha> ListaFecha = new List<fecha>();
        public int ObtenerFecha()
        {
            string y = Convert.ToString(year);
            string m = Convert.ToString(mes);
            if (mes < 10)
                m = "0" + m;
            string d = Convert.ToString(dia);
            if (dia < 10)
                d = "0" + d;

            return (Convert.ToInt32(y + m + d));
        }
        public void Setmes(int mes){ this.mes = mes; }
        public int Getmes(){return mes;}
        public void Setdia(int dia){ this.dia = dia; }
        public int Getdia() { return dia; }
        public void Setyear(int year){ this.year = year; }
        public int Getyear() { return year; }

        public void OrdenarLista(List<fecha> ListaFecha)
        {
            fecha aux;
            for(int i = 0; i < ListaFecha.Count-1; i++)
            {
                for(int j = 0; j < ListaFecha.Count; j++)
                {
                    if(ListaFecha[i].ObtenerFecha() < ListaFecha[j].ObtenerFecha())
                    {
                        aux = ListaFecha[i];
                        ListaFecha[i] = ListaFecha[j];
                        ListaFecha[j] = aux;
                    }
                }
            }
        }
        // imprimir lista
        public void PrintDateList()
        {
            Console.WriteLine("El día es: {0}", dia);
            Console.WriteLine("El mes es: {0}", mes);
            Console.WriteLine("El año es: {0}", year);
        }
    }
}
