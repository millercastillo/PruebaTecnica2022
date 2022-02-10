using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PruebaTecnica2022.Client;
using PruebaTecnica2022.Client.Helpers;
using PruebaTecnica2022.Client.Repositorios;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

ConfigureServices(builder.Services);
builder.Services.AddMudServices();

await builder.Build().RunAsync();

/// <summary>
/// Configuración de los servicios
/// </summary>
static void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<IRepositorio, Repositorio>();
    services.AddScoped<IMostrarMensajes, MostrarMensajes>();
}