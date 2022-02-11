using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica2022.Shared.Entidades;


namespace PruebaTecnica2022.Server
{
    /// <summary>
    /// Clase de entity que nos permite comunicarnos 
    /// con la base de datos y configuras las tablas
    /// de dicha base de datos
    /// </summary>
    public class ApplicationDbContext: IdentityDbContext
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        /// <summary>
        /// Configuracion de la llave primaria compuesta
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GeneroPelicula>().HasKey(p => new {p.GeneroId , p.PeliculaId});    
            base.OnModelCreating(modelBuilder); 
        }
        /// <summary>
        /// El Modelo del cual partimos para crear la base de datos con cada tabla
        /// </summary>
        public DbSet<GeneroPelicula> GeneroPeliculas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
    }
}
