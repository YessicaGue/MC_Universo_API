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
    public class RegistroOchoAccionesInteresController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RegistroOchoAccionesInteresController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<RegistroOchoAccionesInteresController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesInteres>>> Get()
        {
            return await _context.RegistroOchoAccionesInteres.ToListAsync();
        }

        // GET api/<RegistroOchoAccionesInteresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroOchoAccionesInteres>> Get(int id)
        {
            var registroOchoAccionesInteres = await _context.RegistroOchoAccionesInteres.FindAsync(id);

            return registroOchoAccionesInteres == null ? NotFound() : registroOchoAccionesInteres;
        }

        // GET api/<RegistroOchoAccionesInteresController>/RegistroOchoAcciones=5
        [HttpGet("registro-ocho-acciones={id}")]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesInteres>>> GetByRegistro(int id)
        {
            var registroOchoAccionesInteres = await _context.RegistroOchoAccionesInteres.Where(acc => acc.RegistroOchoAccionesId == id).ToListAsync();

            return registroOchoAccionesInteres == null ? NotFound() : registroOchoAccionesInteres;
        }

        // GET api/<RegistroOchoAccionesInteresController>/interes=5
        [HttpGet("interes={id}")]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesInteres>>> GetByInteres(int id)
        {
            var registroOchoAccionesInteres = await _context.RegistroOchoAccionesInteres.Where(acc => acc.InteresId == id).ToListAsync();

            return registroOchoAccionesInteres == null ? NotFound() : registroOchoAccionesInteres;
        }

        // POST api/<RegistroOchoAccionesInteresController>
        [HttpPost]
        public async Task<ActionResult<RegistroOchoAccionesInteres>> Post(RegistroOchoAccionesInteresViewModel request)
        {
            RegistroOchoAccionesInteres registroOchoAccionesInteres = _mapper.Map<RegistroOchoAccionesInteres>(request);
            _context.RegistroOchoAccionesInteres.Add(registroOchoAccionesInteres);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroOchoAccionesInteres.Id }, registroOchoAccionesInteres);
        }

        // PUT api/<RegistroOchoAccionesInteresController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RegistroOchoAccionesInteresViewModel request)
        {
            var registroOchoAccionesInteres = await _context.RegistroOchoAccionesInteres.FindAsync(id);
            _mapper.Map(request, registroOchoAccionesInteres);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroOchoAccionesInteres.Id }, registroOchoAccionesInteres);
        }

        // DELETE api/<RegistroOchoAccionesInteresController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var registroOchoAccionesInteres = await _context.RegistroOchoAccionesInteres.FindAsync(id);
            if (registroOchoAccionesInteres == null)
                return NotFound();

            _context.RegistroOchoAccionesInteres.Remove(registroOchoAccionesInteres);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
