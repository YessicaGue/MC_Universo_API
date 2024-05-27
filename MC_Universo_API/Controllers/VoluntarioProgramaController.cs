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
    public class VoluntarioProgramaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public VoluntarioProgramaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<VoluntarioProgramaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoluntarioPrograma>>> Get()
        {
            return await _context.VoluntarioPrograma.ToListAsync();
        }

        // GET api/<VoluntarioProgramaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoluntarioPrograma>> Get(int id)
        {
            var voluntarioPrograma = await _context.VoluntarioPrograma.FindAsync(id);

            return voluntarioPrograma == null ? NotFound() : voluntarioPrograma;
        }

        // GET api/<VoluntarioProgramaController>/voluntario=5
        [HttpGet("voluntario={id}")]
        public async Task<ActionResult<IEnumerable<VoluntarioPrograma>>> GetByVoluntario(int id)
        {
            var voluntarioPrograma = await _context.VoluntarioPrograma.Where(acc => acc.VoluntarioId == id).ToListAsync();

            return voluntarioPrograma == null ? NotFound() : voluntarioPrograma;
        }

        // GET api/<VoluntarioProgramaController>/programa=5
        [HttpGet("programa={id}")]
        public async Task<ActionResult<IEnumerable<VoluntarioPrograma>>> GetByPrograma(int id)
        {
            var voluntarioPrograma = await _context.VoluntarioPrograma.Where(acc => acc.ProgramaId == id).ToListAsync();

            return voluntarioPrograma == null ? NotFound() : voluntarioPrograma;
        }

        // POST api/<VoluntarioProgramaController>
        [HttpPost]
        public async Task<ActionResult<VoluntarioPrograma>> Post(VoluntarioProgramaViewModel request)
        {
            VoluntarioPrograma voluntarioPrograma = _mapper.Map<VoluntarioPrograma>(request);
            _context.VoluntarioPrograma.Add(voluntarioPrograma);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntarioPrograma.Id }, voluntarioPrograma);
        }

        // PUT api/<VoluntarioProgramaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, VoluntarioProgramaViewModel request)
        {
            var voluntarioPrograma = await _context.VoluntarioPrograma.FindAsync(id);
            _mapper.Map(request, voluntarioPrograma);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntarioPrograma.Id }, voluntarioPrograma);
        }

        // DELETE api/<VoluntarioProgramaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var voluntarioPrograma = await _context.VoluntarioPrograma.FindAsync(id);
            if (voluntarioPrograma == null)
                return NotFound();

            _context.VoluntarioPrograma.Remove(voluntarioPrograma);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
