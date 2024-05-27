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
    public class VoluntarioHabilidadController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public VoluntarioHabilidadController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<VoluntarioHabilidadController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoluntarioHabilidad>>> Get()
        {
            return await _context.VoluntarioHabilidad.ToListAsync();
        }

        // GET api/<VoluntarioHabilidadController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoluntarioHabilidad>> Get(int id)
        {
            var voluntarioHabilidad = await _context.VoluntarioHabilidad.FindAsync(id);

            return voluntarioHabilidad == null ? NotFound() : voluntarioHabilidad;
        }

        // GET api/<VoluntarioHabilidadController>/voluntario=5
        [HttpGet("voluntario={id}")]
        public async Task<ActionResult<IEnumerable<VoluntarioHabilidad>>> GetByVoluntario(int id)
        {
            var voluntarioHabilidad = await _context.VoluntarioHabilidad.Where(acc => acc.VoluntarioId == id).ToListAsync();

            return voluntarioHabilidad == null ? NotFound() : voluntarioHabilidad;
        }

        // GET api/<VoluntarioHabilidadController>/habilidad=5
        [HttpGet("habilidad={id}")]
        public async Task<ActionResult<IEnumerable<VoluntarioHabilidad>>> GetByHabilidad(int id)
        {
            var voluntarioHabilidad = await _context.VoluntarioHabilidad.Where(acc => acc.HabilidadId == id).ToListAsync();

            return voluntarioHabilidad == null ? NotFound() : voluntarioHabilidad;
        }

        // POST api/<VoluntarioHabilidadController>
        [HttpPost]
        public async Task<ActionResult<VoluntarioHabilidad>> Post(VoluntarioHabilidadViewModel request)
        {
            VoluntarioHabilidad voluntarioHabilidad = _mapper.Map<VoluntarioHabilidad>(request);
            _context.VoluntarioHabilidad.Add(voluntarioHabilidad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntarioHabilidad.Id }, voluntarioHabilidad);
        }

        // PUT api/<VoluntarioHabilidadController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, VoluntarioHabilidadViewModel request)
        {
            var voluntarioHabilidad = await _context.VoluntarioHabilidad.FindAsync(id);
            _mapper.Map(request, voluntarioHabilidad);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntarioHabilidad.Id }, voluntarioHabilidad);
        }

        // DELETE api/<VoluntarioHabilidadController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var voluntarioHabilidad = await _context.VoluntarioHabilidad.FindAsync(id);
            if (voluntarioHabilidad == null)
                return NotFound();

            _context.VoluntarioHabilidad.Remove(voluntarioHabilidad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
