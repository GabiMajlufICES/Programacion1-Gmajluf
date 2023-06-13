using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Libro
    {
        public string titulo { get; set; }

        public string autor { get; set; }
        public int anioPublicacion { get; set; }
        public bool disponible { get; set; }

        public abstract string ObtenerInformacion();
    }
}
