using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LibroDigital : Libro
    {
        public int tamanoArchivo { get; set; }

        public string formato { get; set; }

        public override string ObtenerInformacion()
        {
            return $"Título: {titulo}\nAutor: {autor}\nAño de Publicación: {anioPublicacion}\nTamaño del Archivo: {tamanoArchivo} MB\nFormato: {formato}\nDisponible: {(disponible ? "Sí" : "No")}";
        }
    }
}
