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
    public class EscolaridadController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public EscolaridadController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<EscolaridadController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Escolaridad>>> Get()
        {
            return await _context.Escolaridad.ToListAsync();
        }

        // GET api/<EscolaridadController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Escolaridad>> Get(int id)
        {
            var escolaridad = await _context.Escolaridad.FindAsync(id);

            return escolaridad == null ? NotFound() : escolaridad;
        }

        // POST api/<EscolaridadController>
        [HttpPost]
        public async Task<ActionResult<Escolaridad>> Post(Escolaridad escolaridad)
        {
            _context.Escolaridad.Add(escolaridad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = escolaridad.Id }, escolaridad);
        }

    }
}
