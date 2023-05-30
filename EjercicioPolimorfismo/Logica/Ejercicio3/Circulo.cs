using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Ejercicio3
{
    public class Circulo : Figura
    {
        public double radio { get; set; }


        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
