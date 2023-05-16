using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Principal
    {
        List<Usuario> ListaUsuarios = new List<Usuario>();
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Prestamo> ListaPrestamos = new List<Prestamo>();
        List<Libro> ListaLibros = new List<Libro>();

        public void AltaCliente(int dni, string nombre, string apellido, DateTime fechaNac, string contrasenia) 
        { 
            Cliente clienteNuevo = new Cliente();
            
            var cantidadRegistrosCli = ListaClientes.Count(); //Obtengo cantidad de registros de la lista            
            clienteNuevo.id = cantidadRegistrosCli + 1; //Hago cantidad de registros de lista + 1
            clienteNuevo.dni = dni;
            clienteNuevo.nombre = nombre;
            clienteNuevo.apellido = apellido;
            clienteNuevo.fechaNacimiento = fechaNac;

            var cantidadRegistrosUsu = ListaUsuarios.Count();
            clienteNuevo.usuarioCliente.id = cantidadRegistrosUsu + 1;
            clienteNuevo.usuarioCliente.nombre = String.Concat(nombre,".",apellido);
            clienteNuevo.usuarioCliente.contrasenia = contrasenia;

            ListaClientes.Add(clienteNuevo);
            ListaUsuarios.Add(clienteNuevo.usuarioCliente);
        }

        public void modificarCliente(int id) 
        { 
            Cliente clienteModificado = new Cliente();
            
            var clienteEncontrado = ListaClientes.Find(x => x.id == id);
            
            if (clienteEncontrado != null) 
            {
                clienteModificado.id = clienteEncontrado.id;
                clienteModificado.Estado = false;
                //clienteModificado.dni = dni;
                //clienteModificado.nombre = clienteNuevo.nombre;
                //clienteModificado.apellido = clienteNuevo.apellido;
                //clienteModificado.fechaNacimiento = clienteNuevo.fechaNacimiento;

                ListaClientes.Add(clienteModificado);
                ListaClientes.Remove(clienteEncontrado);
            }
        }

        public void eliminarCliente(int id)
        {
            var clienteEncontrado = ListaClientes.Find(x => x.id == id);
            ListaClientes.Remove(clienteEncontrado);
            
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
