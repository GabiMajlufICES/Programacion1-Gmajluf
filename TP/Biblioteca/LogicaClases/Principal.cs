using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Principal
    {
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Prestamo> ListaPrestamos = new List<Prestamo>();
        List<Libro> ListaLibros = new List<Libro>();

        public void AltaCliente(int dni, string nombre, string apellido, DateTime fechaNac, string contrasenia) 
        { 
            Cliente clienteNuevo = new Cliente();
            
            var cantidadRegistros = ListaClientes.Count(); //Obtengo cantidad de registros de la lista
            
            clienteNuevo.id = cantidadRegistros + 1; //Hago cantidad de registros de lista + 1
            clienteNuevo.dni = dni;
            clienteNuevo.nombre = nombre;
            clienteNuevo.apellido = apellido;
            clienteNuevo.fechaNacimiento = fechaNac;
            clienteNuevo.usuarioCliente.nombre = String.Concat(nombre,".",apellido);
            clienteNuevo.usuarioCliente.contrasenia = contrasenia;

            ListaClientes.Add(clienteNuevo);
        }

        public void AltaClienteSegundaForma(Cliente cliente)
        {
            Cliente clienteNuevo = new Cliente();
            var cantidadRegistros = ListaClientes.Count(); //Obtengo cantidad de registros de la lista

            clienteNuevo.id = cantidadRegistros + 1; //Hago cantidad de registros de lista + 1
            clienteNuevo.dni = cliente.dni;
            clienteNuevo.nombre = cliente.nombre;
            clienteNuevo.apellido = cliente.apellido;
            clienteNuevo.fechaNacimiento = cliente.fechaNacimiento;
            ListaClientes.Add(clienteNuevo);
        }

        public List<Cliente> MostrarLista() 
        {

            

            return ListaClientes; 
        }

        public bool ValidarUsuario(string nombre, string contrasenia) 
        {
            Usuario usuario = new Usuario();
            if (usuario.nombre == nombre)
            {
                if (usuario.contrasenia == contrasenia)
                {
                    return true;
                }
                else
                {
                    return false;//Contrasenia invalida
                }
            }
            return false;//Usuario invalido
        }

    }
}
