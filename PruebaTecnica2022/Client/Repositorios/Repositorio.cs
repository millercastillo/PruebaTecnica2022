using PruebaTecnica2022.Shared.Entidades;

namespace PruebaTecnica2022.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula> 
            { 
                new Pelicula() {Titulo = "Spiderman 1", Lanzamiento = new DateTime(2019,7,2)},
                new Pelicula() {Titulo = "Spiderman 2", Lanzamiento = new DateTime(2020,5,4)},
                new Pelicula() {Titulo = "Spiderman 3", Lanzamiento = new DateTime(2021,7,2)}
            };
        }
    }
}
