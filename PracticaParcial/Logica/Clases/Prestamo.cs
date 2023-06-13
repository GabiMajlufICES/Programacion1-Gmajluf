using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Prestamo
    {
        public int id { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public DateTime? fechaDevolucion { get; set; }
        public Cliente clientePrestamo { get; set; }
        public Libro libroPrestamo { get; set; }
    }
}
