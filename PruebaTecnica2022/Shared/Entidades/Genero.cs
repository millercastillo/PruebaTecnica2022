using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica2022.Shared.Entidades
{
    /// <summary>
    /// Clase genero
    /// </summary>
    public class Genero
    {
        /// <summary>
        /// Identificador del genero
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre del genero
        /// </summary>
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string? Nombre { get; set; }
        /// <summary>
        /// Relacion entre genero y generoPelicula
        /// </summary>
        public List<GeneroPelicula>? GeneroPeliculas { get; set; }
    }
}
