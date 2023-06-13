using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LibroFisico : Libro
    {
        public int numeroPaginas { get; set; }

        public override string ObtenerInformacion()
        {
            return $"Título: {titulo}\nAutor: {autor}\nAño de Publicación: {anioPublicacion}\nNúmero de Páginas: {numeroPaginas}\nDisponible: {(disponible ? "Sí" : "No")}";
        }
    }
}
