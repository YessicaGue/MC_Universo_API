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
    public class VoluntarioInteresController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public VoluntarioInteresController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<VoluntarioInteresController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoluntarioInteres>>> Get()
        {
            return await _context.VoluntarioInteres.ToListAsync();
        }

        // GET api/<VoluntarioInteresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoluntarioInteres>> Get(int id)
        {
            var voluntarioInteres = await _context.VoluntarioInteres.FindAsync(id);

            return voluntarioInteres == null ? NotFound() : voluntarioInteres;
        }

        // GET api/<VoluntarioInteresController>/voluntario=5
        [HttpGet("voluntario={id}")]
        public async Task<ActionResult<IEnumerable<VoluntarioInteres>>> GetByVoluntario(int id)
        {
            var voluntarioInteres = await _context.VoluntarioInteres.Where(acc => acc.VoluntarioId == id).ToListAsync();

            return voluntarioInteres == null ? NotFound() : voluntarioInteres;
        }

        // GET api/<VoluntarioInteresController>/interes=5
        [HttpGet("interes={id}")]
        public async Task<ActionResult<IEnumerable<VoluntarioInteres>>> GetByInteres(int id)
        {
            var voluntarioInteres = await _context.VoluntarioInteres.Where(acc => acc.InteresId == id).ToListAsync();

            return voluntarioInteres == null ? NotFound() : voluntarioInteres;
        }

        // POST api/<VoluntarioInteresController>
        [HttpPost]
        public async Task<ActionResult<VoluntarioInteres>> Post(VoluntarioInteresViewModel request)
        {
            VoluntarioInteres voluntarioInteres = _mapper.Map<VoluntarioInteres>(request);
            _context.VoluntarioInteres.Add(voluntarioInteres);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntarioInteres.Id }, voluntarioInteres);
        }

        // PUT api/<VoluntarioInteresController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, VoluntarioInteresViewModel request)
        {
            var voluntarioInteres = await _context.VoluntarioInteres.FindAsync(id);
            _mapper.Map(request, voluntarioInteres);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntarioInteres.Id }, voluntarioInteres);
        }

        // DELETE api/<VoluntarioInteresController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var voluntarioInteres = await _context.VoluntarioInteres.FindAsync(id);
            if (voluntarioInteres == null)
                return NotFound();

            _context.VoluntarioInteres.Remove(voluntarioInteres);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
