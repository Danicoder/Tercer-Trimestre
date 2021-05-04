using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosOficialesListas
{
    class fecha
    {
        int mes, year, dia;

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

        
        // imprimir lista
        public void PrintDateList()
        {
            Console.WriteLine("El día es: {0}", dia);
            Console.WriteLine("El mes es: {0}", mes);
            Console.WriteLine("El año es: {0}", year);
        }
    }
}
