using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.SecretariaOrganizacionAccionPolitica
{
    [Route("api/[controller]")]
    [ApiController]
    public class SesionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public SesionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<SesionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sesion>>> Get()
        {
            return await _context.Sesion.ToListAsync();
        }

        // GET: api/<SesionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sesion>> Get(int id)
        {
            var sesion = await _context.Sesion.FindAsync(id);

            return sesion == null ? NotFound() : sesion;
        }

        // POST: api/<SesionController>
        [HttpPost]
        public async Task<ActionResult<Sesion>> Post(SesionViewModel request)
        {
            Sesion sesion = _mapper.Map<Sesion>(request);
            _context.Sesion.Add(sesion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = sesion.Id }, sesion);
        }

        // PUT: api/<SesionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, SesionViewModel request)
        {
            var sesion = await _context.Sesion.FindAsync(id);

            if (sesion == null)
            {
                return NotFound();
            }

            _mapper.Map(request, sesion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = sesion.Id }, sesion);
        }

        // DELETE: api/<SesionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var sesion = await _context.Sesion.FindAsync(id);

            if (sesion == null)
            {
                return NotFound();
            }

            _context.Sesion.Remove(sesion);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<SesionController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var sesion = await _context.Sesion.FindAsync(id);

            if (sesion == null)
            {
                return NotFound();
            }

            sesion.Activo = false;
            sesion.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
