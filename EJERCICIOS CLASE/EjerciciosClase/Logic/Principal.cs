using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Principal
    {
        List<Client> ListaClientes = new List<Client>();
        
        public void llenarClientes (Client newClient)
        {
            Client clienteNuevo = new Client();

            clienteNuevo.id = newClient.id;
            clienteNuevo.name = newClient.name;
            clienteNuevo.DNI= newClient.DNI;
            ListaClientes.Add(clienteNuevo);
        }

        public void buscarClientes (int id) 
        { 
            var clienteEncontrado = ListaClientes.FindAll(Client => Client.id == id);
            var clientePrueba = ListaClientes.Max();

            foreach (var cliente in ListaClientes)
            {
                if (cliente.id == id)
                {
                    var clienteEncontr = cliente;
                }
            }
        }
    }
}
