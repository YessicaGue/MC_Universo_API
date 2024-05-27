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
    public class ComisionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ComisionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ComisionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comision>>> Get()
        {
            return await _context.Comision.ToListAsync();
        }

        // GET: api/<ComisionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comision>> Get(int id)
        {
            var comision = await _context.Comision.FindAsync(id);

            return comision == null ? NotFound() : comision;
        }

        // POST: api/<ComisionController>
        [HttpPost]
        public async Task<ActionResult<Comision>> Post(ComisionViewModel request)
        {
            Comision comision = _mapper.Map<Comision>(request);
            _context.Comision.Add(comision);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = comision.Id }, comision);
        }

        // PUT: api/<ComisionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ComisionViewModel request)
        {
            var comision = await _context.Comision.FindAsync(id);

            if (comision == null)
            {
                return NotFound();
            }

            _mapper.Map(request, comision);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = comision.Id }, comision);
        }

        // DELETE: api/<ComisionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var comision = await _context.Comision.FindAsync(id);

            if (comision == null)
            {
                return NotFound();
            }

            _context.Comision.Remove(comision);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<ComisionController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var comision = await _context.Comision.FindAsync(id);

            if (comision == null)
            {
                return NotFound();
            }

            comision.Activo = false;
            comision.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
