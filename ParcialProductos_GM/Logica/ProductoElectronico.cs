using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProductoElectronico : Producto
    {
        public string marca { get; set; }
        public int garantiaMeses { get; set; }
    }
}
