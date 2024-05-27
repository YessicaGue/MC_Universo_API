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
    public class RegistroOchoAccionesUsuarioCatalogoOchoAccionesController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RegistroOchoAccionesUsuarioCatalogoOchoAccionesController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<RegistroOchoAccionesUsuarioCatalogoOchoAccionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesUsuarioCatalogoOchoAcciones>>> Get()
        {
            return await _context.RegistroOchoAccionesUsuarioCatalogoOchoAcciones.ToListAsync();
        }

        // GET api/<RegistroOchoAccionesUsuarioCatalogoOchoAccionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroOchoAccionesUsuarioCatalogoOchoAcciones>> Get(int id)
        {
            var registroOchoAccionesUsuarioCatalogoOchoAcciones = await _context.RegistroOchoAccionesUsuarioCatalogoOchoAcciones.FindAsync(id);

            return registroOchoAccionesUsuarioCatalogoOchoAcciones == null ? NotFound() : registroOchoAccionesUsuarioCatalogoOchoAcciones;
        }

        // GET api/<RegistroOchoAccionesUsuarioCatalogoOchoAccionesController>/registro-ocho-acciones-usuario=5
        [HttpGet("registro-ocho-acciones-usuario={id}")]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesUsuarioCatalogoOchoAcciones>>> GetByRegistro(int id)
        {
            var registroOchoAccionesUsuarioCatalogoOchoAcciones = await _context.RegistroOchoAccionesUsuarioCatalogoOchoAcciones.Where(acc => acc.RegistroOchoAccionesUsuarioId == id).ToListAsync();

            return registroOchoAccionesUsuarioCatalogoOchoAcciones == null ? NotFound() : registroOchoAccionesUsuarioCatalogoOchoAcciones;
        }

        // GET api/<RegistroOchoAccionesUsuarioCatalogoOchoAccionesController>/catalogo-ocho-acciones=5
        [HttpGet("catalogo-ocho-acciones={id}")]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesUsuarioCatalogoOchoAcciones>>> GetByCatalogo(int id)
        {
            var registroOchoAccionesUsuarioCatalogoOchoAcciones = await _context.RegistroOchoAccionesUsuarioCatalogoOchoAcciones.Where(acc => acc.CatalogoOchoAccionesId == id).ToListAsync();

            return registroOchoAccionesUsuarioCatalogoOchoAcciones == null ? NotFound() : registroOchoAccionesUsuarioCatalogoOchoAcciones;
        }

        // POST api/<RegistroOchoAccionesUsuarioCatalogoOchoAccionesController>
        [HttpPost]
        public async Task<ActionResult<RegistroOchoAccionesUsuarioCatalogoOchoAcciones>> Post(RegistroOchoAccionesUsuarioCatalogoOchoAccionesViewModel request)
        {
            RegistroOchoAccionesUsuarioCatalogoOchoAcciones registroOchoAccionesUsuarioCatalogoOchoAcciones = _mapper.Map<RegistroOchoAccionesUsuarioCatalogoOchoAcciones>(request);
            _context.RegistroOchoAccionesUsuarioCatalogoOchoAcciones.Add(registroOchoAccionesUsuarioCatalogoOchoAcciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroOchoAccionesUsuarioCatalogoOchoAcciones.Id }, registroOchoAccionesUsuarioCatalogoOchoAcciones);
        }

        // PUT api/<RegistroOchoAccionesUsuarioCatalogoOchoAccionesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RegistroOchoAccionesUsuarioCatalogoOchoAccionesViewModel request)
        {
            var registroOchoAccionesUsuarioCatalogoOchoAcciones = await _context.RegistroOchoAccionesUsuarioCatalogoOchoAcciones.FindAsync(id);
            _mapper.Map(request, registroOchoAccionesUsuarioCatalogoOchoAcciones);

            await _context.SaveChangesAsync();

            if (registroOchoAccionesUsuarioCatalogoOchoAcciones == null)
                return NotFound();

            return CreatedAtAction("Get", new { id = registroOchoAccionesUsuarioCatalogoOchoAcciones.Id }, registroOchoAccionesUsuarioCatalogoOchoAcciones);
        }

        // DELETE api/<RegistroOchoAccionesUsuarioCatalogoOchoAccionesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var registroOchoAccionesUsuarioCatalogoOchoAcciones = await _context.RegistroOchoAccionesUsuarioCatalogoOchoAcciones.FindAsync(id);
            if (registroOchoAccionesUsuarioCatalogoOchoAcciones == null)
                return NotFound();

            _context.RegistroOchoAccionesUsuarioCatalogoOchoAcciones.Remove(registroOchoAccionesUsuarioCatalogoOchoAcciones);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
