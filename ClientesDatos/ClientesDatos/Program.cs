using System;

namespace ClientesDatos
{
    class Program
    {
        static void Main()
        {
            tlistaClientes ListaClientes = new tlistaClientes();
            Cliente cliente = new Cliente();

            ListaClientes.OrdenarCliente(cliente);
        }
    }
}
