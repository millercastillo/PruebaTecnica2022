using PruebaTecnica2022.Shared.Entidades;
using System.Text;
using System.Text.Json;


namespace PruebaTecnica2022.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly HttpClient httpClient;
        public Repositorio(HttpClient httpClient) 
        {
            this.httpClient = httpClient;
        }

        public  async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
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
