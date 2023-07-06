using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Back
{
    public class VehiculoAutomovil : Vehiculo
    {
        public int nroPuertas { get; set; }
        public int nroAsientos { get; set; }
        public string VA
        {
            get { return "Patente: " + patente + ", Marca: " + marca + ", Modelo: " + modelo + ", Precio Por Día: " + precioXDia + ", Numero de Puertas: " + nroPuertas + ", Numero de Asientos: " + nroAsientos; }

        }
    }
}
