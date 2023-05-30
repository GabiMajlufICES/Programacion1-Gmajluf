using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EjercicioOpcional
{
    public class ProductoDigital : Producto
    {
        public int Tamaño { get; set; }

        public ProductoDigital(string nombre, decimal precio, int tamaño) : base(nombre, precio)
        {
            Tamaño = tamaño;
        }

        public override decimal CalcularImpuesto()
        {
            return Precio * 0.05m;
        }

        public override decimal CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }
    }
}
