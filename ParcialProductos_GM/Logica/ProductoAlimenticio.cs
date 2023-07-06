using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProductoAlimenticio : Producto
    {
        public DateTime fechaVencimiento { get; set; }
        public int cantidad { get; set; }
    }
}
