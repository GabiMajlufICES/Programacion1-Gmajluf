using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class TurnoVirtual : Turnos
    {
        public string plataforma { get; set; }
        public override string MostrarInformacion()
        {
            return $"El turno fue sacado desde la plataforma {plataforma}";
        }
    }
}
