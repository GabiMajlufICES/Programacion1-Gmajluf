using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Cliente : Persona
    {
        public int id { get; set; }
        public Usuario usuarioCliente { get; set; }

        public bool Estado { get; set; } //Si esta en true esta activo y sino esta dado de baja



    }
}
