using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Ejercicio2
{
    public class Bicicleta : IVehiculo
    {
        public int velocidad { get; set; }

        public void Acelerar()
        {
            velocidad += 5;
            Console.WriteLine("La bicicleta acelero. Velocidad actual: " + velocidad + " km/h");
        }
    }
}
