using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Back
{
    public class VehiculoCamioneta : Vehiculo
    {
        public int cantidadCarga { get; set; }
        public string VC
        {
            get { return "Patente: " + patente + ", Marca: " + marca + ", Modelo: " + modelo + ", Precio Por Día: " + precioXDia + ", Capacidad de Carga: " + cantidadCarga; }

        }
    }
}
