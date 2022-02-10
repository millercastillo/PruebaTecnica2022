using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica2022.Shared.Entidades
{
    /// <summary>
    /// Clase relacion muchos a muchos de genero y pelicula
    /// </summary>
    public class GeneroPelicula
    {
        /// <summary>
        /// Id asociado a la pelicula
        /// </summary>
        public int PeliculaId { get; set; }
        /// <summary>
        /// Id asociado al genero
        /// </summary>
        public int GeneroId { get; set; }
        /// <summary>
        /// Propiedad de navegacion que va hacia genero
        /// </summary>
        public Genero? Genero { get; set; }
        /// <summary>
        /// Propiedad de navegacion que va hacia pelicula
        /// </summary>
        public Pelicula? Pelicula { get; set; }
    }
}
