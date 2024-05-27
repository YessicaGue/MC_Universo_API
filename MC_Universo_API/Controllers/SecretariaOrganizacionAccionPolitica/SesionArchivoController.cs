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
    public class SesionArchivoController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public SesionArchivoController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<SesionArchivoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SesionArchivo>>> Get()
        {
            return await _context.SesionArchivo.ToListAsync();
        }

        // GET: api/<SesionArchivoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SesionArchivo>> Get(int id)
        {
            var sesionArchivo = await _context.SesionArchivo.FindAsync(id);

            return sesionArchivo == null ? NotFound() : sesionArchivo;
        }

        // POST: api/<SesionArchivoController>
        [HttpPost]
        public async Task<ActionResult<SesionArchivo>> Post(SesionArchivoViewModel request)
        {
            SesionArchivo sesionArchivo = _mapper.Map<SesionArchivo>(request);
            _context.SesionArchivo.Add(sesionArchivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = sesionArchivo.Id }, sesionArchivo);
        }

        // PUT: api/<SesionArchivoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, SesionArchivoViewModel request)
        {
            var sesionArchivo = await _context.SesionArchivo.FindAsync(id);

            if (sesionArchivo == null)
            {
                return NotFound();
            }

            _mapper.Map(request, sesionArchivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = sesionArchivo.Id }, sesionArchivo);
        }

        // DELETE: api/<SesionArchivoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var sesionArchivo = await _context.SesionArchivo.FindAsync(id);

            if (sesionArchivo == null)
            {
                return NotFound();
            }

            _context.SesionArchivo.Remove(sesionArchivo);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<SesionArchivoController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var sesionArchivo = await _context.SesionArchivo.FindAsync(id);

            if (sesionArchivo == null)
            {
                return NotFound();
            }

            sesionArchivo.Activo = false;
            sesionArchivo.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
