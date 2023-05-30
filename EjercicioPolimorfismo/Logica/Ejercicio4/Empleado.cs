using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Ejercicio4
{
    public class Empleado
    {
        public string nombre { get; set; }
        public double salarioBase { get; set; }

        public virtual double CalcularSalario()
        {
            return salarioBase;
        }
    }
}
