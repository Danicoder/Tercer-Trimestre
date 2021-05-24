using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesDatos
{
    class tlistaClientes
    {
        List<Cliente> ListaCliente;

        public tlistaClientes()
        {
            ListaCliente = new List<Cliente>();
        }
        //ordenar la lista que se inserte
        public void OrdenarCliente(Cliente cliente)
        {
            string aux;
            if (ListaCliente.Count == 0) //Si esta vacía que añada el cliente
            {
                ListaCliente.Add(cliente);
            }
            else //recorrerla
            {
                //for (int i = 0; i < ListaCliente.Count - 1; i++)
                //{
                //    for (int j = i+1; j < ListaCliente.Count; j++)
                //    {
                //        if(ListaCliente[i].Getdni().CompareTo(ListaCliente[j].Getdni())==1)
                //        {
                //            aux = ListaCliente[i].Getdni();
                //            ListaCliente[i].Getdni() = ListaCliente[j].Getdni();
                //            aux = ListaCliente[j].Getdni()
                //        }

                //    }
                //}
                for (int i = 0; i < ListaCliente.Count; i++)
                {
                    if(ListaCliente[i].Getdni().CompareTo(cliente.Getdni()) == 0)
                    {
                        Console.WriteLine("El cliente ya existe");
                    }
                    else if(ListaCliente[i].Getdni().CompareTo(cliente.Getdni()) == 1)
                    {
                        ListaCliente.Insert(i, cliente);
                    }
                    else if (ListaCliente[i].Getdni().CompareTo(cliente.Getdni()) == 1 && i == ListaCliente.Count-1)
                    {
                        ListaCliente.Add(cliente);
                    }
                }
            }
        }
        //public void InsertarOrdenado()
        //{
        //    if (ListaCliente.Count == 0 || Comparable(ListaCliente.Count - 1, Cliente) == 1)
        //        ListaCliente.Add(Cliente);
        //    else
        //    {
        //        for (int i = 0; i < length; i++)
        //        {
        //            if (comparar(i, Cliente) == 0)
        //                Console.WriteLine("ya esta");
        //            break;
        //            else if (Comparer(i, clase) == 1)
        //                ListaCliente.Insert(i, Cliente);
        //            break;

        //        }
        //    }
        //}
    }
}
//lista.Insert(2,5)  cada ves que insertemos un nuevo usuario lo inserte en su lugar
//2 = posición donde quiero que el dato se ubique
//5 = valor a insertar

/* o hacerlo mediante métodos
    public int comparar(int i, tcliente cliente)
{
    return ListaCliente[i].GetDNI().CompareTo(cliente.Getdni())
}
public void metodo 
if(compara(i,cliente) == 0)

 */
