using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Administrador : Persona
    {
        public int Id { get; set; }
        public Usuario UsuarioAdministrador { get; set; }
    }
}
