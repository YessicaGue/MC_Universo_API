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
    public class RegistroOchoAccionesHabilidadController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RegistroOchoAccionesHabilidadController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<RegistroOchoAccionesHabilidadController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesHabilidad>>> Get()
        {
            return await _context.RegistroOchoAccionesHabilidad.ToListAsync();
        }

        // GET api/<RegistroOchoAccionesHabilidadController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroOchoAccionesHabilidad>> Get(int id)
        {
            var registroOchoAccionesHabilidad = await _context.RegistroOchoAccionesHabilidad.FindAsync(id);

            return registroOchoAccionesHabilidad == null ? NotFound() : registroOchoAccionesHabilidad;
        }

        // GET api/<RegistroOchoAccionesHabilidadController>/registro-ocho-acciones=5
        [HttpGet("registro-ocho-acciones={id}")]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesHabilidad>>> GetByRegistro(int id)
        {
            var registroOchoAccionesHabilidad = await _context.RegistroOchoAccionesHabilidad.Where(acc => acc.RegistroOchoAccionesId == id).ToListAsync();

            return registroOchoAccionesHabilidad == null ? NotFound() : registroOchoAccionesHabilidad;
        }

        // GET api/<RegistroOchoAccionesHabilidadController>/habilidad=5
        [HttpGet("habilidad={id}")]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesHabilidad>>> GetByHabilidad(int id)
        {
            var registroOchoAccionesHabilidad = await _context.RegistroOchoAccionesHabilidad.Where(acc => acc.HabilidadId == id).ToListAsync();

            return registroOchoAccionesHabilidad == null ? NotFound() : registroOchoAccionesHabilidad;
        }

        // POST api/<RegistroOchoAccionesHabilidadController>
        [HttpPost]
        public async Task<ActionResult<RegistroOchoAccionesHabilidad>> Post(RegistroOchoAccionesHabilidadViewModel request)
        {
            RegistroOchoAccionesHabilidad registroOchoAccionesHabilidad = _mapper.Map<RegistroOchoAccionesHabilidad>(request);
            _context.RegistroOchoAccionesHabilidad.Add(registroOchoAccionesHabilidad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroOchoAccionesHabilidad.Id }, registroOchoAccionesHabilidad);
        }

        // PUT api/<RegistroOchoAccionesHabilidadController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RegistroOchoAccionesHabilidadViewModel request)
        {
            var registroOchoAccionesHabilidad = await _context.RegistroOchoAccionesHabilidad.FindAsync(id);
            _mapper.Map(request, registroOchoAccionesHabilidad);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroOchoAccionesHabilidad.Id }, registroOchoAccionesHabilidad);
        }

        // DELETE api/<RegistroOchoAccionesHabilidadController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var registroOchoAccionesHabilidad = await _context.RegistroOchoAccionesHabilidad.FindAsync(id);
            if (registroOchoAccionesHabilidad == null)
                return NotFound();

            _context.RegistroOchoAccionesHabilidad.Remove(registroOchoAccionesHabilidad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
