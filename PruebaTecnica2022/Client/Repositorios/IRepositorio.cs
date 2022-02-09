using PruebaTecnica2022.Shared.Entidades;

namespace PruebaTecnica2022.Client.Repositorios
{
    public interface IRepositorio
    {
        /// <summary>
        /// Listado de peliculas que se encuentran registradas
        /// </summary>
        /// <returns></returns>
        List<Pelicula> ObtenerPeliculas();
    }
}
