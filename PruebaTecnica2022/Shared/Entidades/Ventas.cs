using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica2022.Shared.Entidades
{
    /// <summary>
    /// Clase ventas
    /// </summary>
    public class Ventas
    {
        /// <summary>
        /// Id de la venta
        /// </summary>
        public  int Id { get; set; }
        /// <summary>
        /// Codigo del producto comprado
        /// </summary>
        public int CodigoProducto { get; set; }
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Cantidad de peliculas compradas
        /// </summary>
        public int Cantidad { get; set; }
        /// <summary>
        /// Precio por unidad
        /// </summary>
        public int Precio { get; set; }
        /// <summary>
        /// Total de la venta
        /// </summary>
        public int Total { get; set; }
    }
}
