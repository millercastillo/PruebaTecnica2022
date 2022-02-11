using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica2022.Shared.DTOs;
using PruebaTecnica2022.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica2022.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        //private readonly IAlmacenadorArchivos almacenadorDeArchivos;
        //private readonly IMapper mapper;

        public PeliculasController(ApplicationDbContext context)
        {
            this.context = context;
            //this.almacenadorDeArchivos = almacenadorDeArchivos;
            //this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Pelicula Pelicula)
        {
            context.Add(Pelicula);
            await context.SaveChangesAsync();
            return Pelicula.Id;
        }

        [HttpGet]
        public async Task<PeliculasDTO> Get()
        {
            var peliculas = await context.Peliculas.ToListAsync();

            var response = new PeliculasDTO()
            {
                Peliculas = peliculas
            };
            return response;
        }
    }
}
