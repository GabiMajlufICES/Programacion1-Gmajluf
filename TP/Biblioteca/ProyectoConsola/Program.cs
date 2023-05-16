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
            Console.WriteLine("Agrega una persona");

            Console.WriteLine("Arranca con el dni");
            clienteAgregado.dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Segui con el nombre");
            clienteAgregado.nombre = Console.ReadLine();
            Console.WriteLine("Segui con el Apellido");
            clienteAgregado.apellido = Console.ReadLine();
            Console.WriteLine("Termina con la fecha de nacimiento");
            clienteAgregado.fechaNacimiento = DateTime.Parse(Console.ReadLine());

            principal.AltaCliente(clienteAgregado.dni, clienteAgregado.nombre,
                clienteAgregado.apellido, clienteAgregado.fechaNacimiento);







        }
    }
}
