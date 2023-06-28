using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public abstract class Turnos
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int duracion { get; set; }
        public string estado { get; set; }

        public abstract string MostrarInformacion();


    }
}
