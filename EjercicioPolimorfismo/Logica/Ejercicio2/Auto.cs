using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Ejercicio2
{
    public class Auto : IVehiculo
    {
        public int velocidad { get; set; }

        public void Acelerar()
        {
            velocidad += 10;
            Console.WriteLine("El auto acelero. Velocidad actual: " + velocidad + " km/h");
        }
    }
}
