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
        Task<HttpResponseWrapper<object>> Delete(string url);
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
    }
}
