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
    public class RegistroOchoAccionesCatalogoOchoAccionesController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RegistroOchoAccionesCatalogoOchoAccionesController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<RegistroOchoAccionesCatalogoOchoAccionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesCatalogoOchoAcciones>>> Get()
        {
            return await _context.RegistroOchoAccionesCatalogoOchoAcciones.ToListAsync();
        }

        // GET api/<RegistroOchoAccionesCatalogoOchoAccionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroOchoAccionesCatalogoOchoAcciones>> Get(int id)
        {
            var registroOchoAccionesCatalogoOchoAcciones = await _context.RegistroOchoAccionesCatalogoOchoAcciones.FindAsync(id);

            return registroOchoAccionesCatalogoOchoAcciones == null ? NotFound() : registroOchoAccionesCatalogoOchoAcciones;
        }

        // GET api/<RegistroOchoAccionesCatalogoOchoAccionesController>/registro-ocho-acciones=5
        [HttpGet("registro-ocho-acciones={id}")]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesCatalogoOchoAcciones>>> GetByRegistro(int id)
        {
            var registroOchoAccionesCatalogoOchoAcciones = await _context.RegistroOchoAccionesCatalogoOchoAcciones.Where(acc => acc.RegistroOchoAccionesId == id).ToListAsync();

            return registroOchoAccionesCatalogoOchoAcciones == null ? NotFound() : registroOchoAccionesCatalogoOchoAcciones;
        }

        // GET api/<RegistroOchoAccionesCatalogoOchoAccionesController>/catalogo-ocho-acciones=5
        [HttpGet("catalogo-ocho-acciones={id}")]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesCatalogoOchoAcciones>>> GetByCatalogo(int id)
        {
            var registroOchoAccionesCatalogoOchoAcciones = await _context.RegistroOchoAccionesCatalogoOchoAcciones.Where(acc => acc.CatalogoOchoAccionesId == id).ToListAsync();

            return registroOchoAccionesCatalogoOchoAcciones == null ? NotFound() : registroOchoAccionesCatalogoOchoAcciones;
        }

        // POST api/<RegistroOchoAccionesCatalogoOchoAccionesController>
        [HttpPost]
        public async Task<ActionResult<RegistroOchoAccionesCatalogoOchoAcciones>> Post(RegistroOchoAccionesCatalogoOchoAccionesViewModel request)
        {
            RegistroOchoAccionesCatalogoOchoAcciones registroOchoAccionesCatalogoOchoAcciones = _mapper.Map<RegistroOchoAccionesCatalogoOchoAcciones>(request);
            _context.RegistroOchoAccionesCatalogoOchoAcciones.Add(registroOchoAccionesCatalogoOchoAcciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroOchoAccionesCatalogoOchoAcciones.Id }, registroOchoAccionesCatalogoOchoAcciones);
        }

        // PUT api/<RegistroOchoAccionesCatalogoOchoAccionesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RegistroOchoAccionesCatalogoOchoAccionesViewModel request)
        {
            var registroOchoAccionesCatalogoOchoAcciones = await _context.RegistroOchoAccionesCatalogoOchoAcciones.FindAsync(id);
            _mapper.Map(request, registroOchoAccionesCatalogoOchoAcciones);

            await _context.SaveChangesAsync();

            if (registroOchoAccionesCatalogoOchoAcciones == null)
                return NotFound();

            return CreatedAtAction("Get", new { id = registroOchoAccionesCatalogoOchoAcciones.Id }, registroOchoAccionesCatalogoOchoAcciones);
        }

        // DELETE api/<RegistroOchoAccionesCatalogoOchoAccionesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var registroOchoAccionesCatalogoOchoAcciones = await _context.RegistroOchoAccionesCatalogoOchoAcciones.FindAsync(id);
            if (registroOchoAccionesCatalogoOchoAcciones == null)
                return NotFound();

            _context.RegistroOchoAccionesCatalogoOchoAcciones.Remove(registroOchoAccionesCatalogoOchoAcciones);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
