using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Prestamo
    {
        public int id { get; set; }
        public CopiaLibro copiaPrestada { get; set; }
        public int duracionDias { get; set; }
        
    }
}
