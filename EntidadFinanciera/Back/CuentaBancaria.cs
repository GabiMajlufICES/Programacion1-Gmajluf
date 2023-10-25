using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class CuentaBancaria
    {
        public int id { get; set; }
        public long numeroCuenta { get; set; }
        public float saldo { get; set; }
        public string tipo { get; set; }
        public Cliente clienteCB { get; set; } //Objeto que mapea EF para pasar la foranea
        public string nombreCliente { get; set; } //Para poder usarlo en el FRONT  
    }
}
