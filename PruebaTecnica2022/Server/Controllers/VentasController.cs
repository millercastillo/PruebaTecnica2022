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
    public class VentasController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        //private readonly IAlmacenadorArchivos almacenadorDeArchivos;
        //private readonly IMapper mapper;

        public VentasController(ApplicationDbContext context)
        {
            this.context = context;
            //this.almacenadorDeArchivos = almacenadorDeArchivos;
            //this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Ventas Venta)
        {
            context.Add(Venta);
            await context.SaveChangesAsync();
            return Venta.Id;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ventas>>> Get()
        {
            var ventas = await context.Ventas.ToListAsync();
            return ventas;
        }
    }
}
