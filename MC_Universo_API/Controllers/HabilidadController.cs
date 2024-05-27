using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public HabilidadController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<HabilidadController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Habilidad>>> Get()
        {
            return await _context.Habilidad.ToListAsync();
        }

        // GET api/<HabilidadController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Habilidad>> Get(int id)
        {
            var habilidad = await _context.Habilidad.FindAsync(id);

            return habilidad == null ? NotFound() : habilidad;
        }

        // POST api/<HabilidadController>
        [HttpPost]
        public async Task<ActionResult<Habilidad>> Post(Habilidad habilidad)
        {
            _context.Habilidad.Add(habilidad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = habilidad.Id }, habilidad);
        }

    }
}
