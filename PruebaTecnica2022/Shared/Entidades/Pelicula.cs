using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica2022.Shared.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime Lanzamiento { get; set; }
        /// <summary>
        /// Fotografia de la pelicula
        /// </summary>
        public string? Foto { get; set; }
        public int  Precio { get; set; } = 0;
        public List<GeneroPelicula> GeneroPelicula { get; set; } = new List<GeneroPelicula>();
    }
}
