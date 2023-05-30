using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Ejercicio3
{
    public class Rectangulo : Figura
    {
        public double baseRectangulo { get; set; }
        public double altura { get; set; }


        public override double CalcularArea()
        {
            return baseRectangulo * altura;
        }
    }
}
