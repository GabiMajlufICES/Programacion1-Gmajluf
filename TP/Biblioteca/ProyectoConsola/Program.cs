using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaClases;


namespace ProyectoConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Principal principal = new Principal();           
            
            Cliente clienteAgregado = new Cliente();
            Console.WriteLine("Agregar un cliente");

            Console.WriteLine("Inserte el DNI");
            clienteAgregado.dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el Nombre");
            clienteAgregado.nombre = Console.ReadLine();
            Console.WriteLine("Inserte el Apellido");
            clienteAgregado.apellido = Console.ReadLine();
            Console.WriteLine("Inserte la Fecha de Nacimiento");
            clienteAgregado.fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Inserte la contrasenia");
            clienteAgregado.usuarioCliente.contrasenia = Console.ReadLine();


            principal.AltaCliente(clienteAgregado.dni, clienteAgregado.nombre,
                clienteAgregado.apellido, clienteAgregado.fechaNacimiento, 
                clienteAgregado.usuarioCliente.contrasenia);







        }
    }
}
