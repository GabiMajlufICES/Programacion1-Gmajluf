using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        public List<Cliente> ListaClientes = new List<Cliente>();
        public List<Libro> ListaLibrosDisponibles = new List<Libro>();
        public List<Prestamo> ListaPrestamos = new List<Prestamo>();

        public void AgregarLibro(Libro libro)
        {
            ListaLibrosDisponibles.Add(libro);
        }

        public void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        public void RealizarPrestamo(Cliente cliente, Libro libro)
        {
            if (libro.disponible)
            {
                libro.disponible = false;
                var prestamo = new Prestamo
                {
                    clientePrestamo = cliente,
                    libroPrestamo = libro,
                    fechaPrestamo = DateTime.Now
                };
                ListaPrestamos.Add(prestamo);
            }
        }

        public void RegistrarDevolucion(Prestamo prestamo)
        {
            prestamo.libroPrestamo.disponible = true;
            prestamo.fechaDevolucion = DateTime.Now;
        }

        public List<Libro> ObtenerLibrosDisponibles()
        {
            return ListaLibrosDisponibles;
        }

        public List<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }

        public List<Prestamo> ObtenerPrestamosVigentes()
        {
            return ListaPrestamos.Where(p => p.fechaDevolucion == null).ToList();
        }
    }
}
