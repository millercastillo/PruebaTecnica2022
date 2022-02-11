using PruebaTecnica2022.Shared.Entidades;
using System.Text;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaTecnica2022.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly HttpClient httpClient;
        public Repositorio(HttpClient httpClient) 
        {
            this.httpClient = httpClient;
        }
        private JsonSerializerOptions OpcionesPorDefectoJSON =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public  async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);

            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }

        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
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

        public Task<HttpResponseWrapper<object>> Delete(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            throw new NotImplementedException();
        }
    }
}
