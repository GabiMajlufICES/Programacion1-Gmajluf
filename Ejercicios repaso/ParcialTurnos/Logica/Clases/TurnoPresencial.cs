using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class TurnoPresencial : Turnos
    {
        public string lugar { get; set; }
        public override string MostrarInformacion()
        {
            return $"El turno fue sacado desde el lugar {lugar}";
        }
    }
}
