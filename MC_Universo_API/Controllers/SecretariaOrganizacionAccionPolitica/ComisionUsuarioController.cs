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
    public class ComisionUsuarioController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ComisionUsuarioController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ComisionUsuarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComisionUsuario>>> Get()
        {
            return await _context.ComisionUsuario.ToListAsync();
        }

        // GET: api/<ComisionUsuarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComisionUsuario>> Get(int id)
        {
            var comisionUsuario = await _context.ComisionUsuario.FindAsync(id);

            return comisionUsuario == null ? NotFound() : comisionUsuario;
        }

        // POST: api/<ComisionUsuarioController>
        [HttpPost]
        public async Task<ActionResult<ComisionUsuario>> Post(ComisionUsuarioViewModel request)
        {
            ComisionUsuario comisionUsuario = _mapper.Map<ComisionUsuario>(request);
            _context.ComisionUsuario.Add(comisionUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = comisionUsuario.Id }, comisionUsuario);
        }

        // PUT: api/<ComisionUsuarioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ComisionUsuarioViewModel request)
        {
            var comisionUsuario = await _context.ComisionUsuario.FindAsync(id);

            if (comisionUsuario == null)
            {
                return NotFound();
            }

            _mapper.Map(request, comisionUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = comisionUsuario.Id }, comisionUsuario);
        }

        // DELETE: api/<ComisionUsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var comisionUsuario = await _context.ComisionUsuario.FindAsync(id);

            if (comisionUsuario == null)
            {
                return NotFound();
            }

            _context.ComisionUsuario.Remove(comisionUsuario);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<ComisionUsuarioController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var comisionUsuario = await _context.ComisionUsuario.FindAsync(id);

            if (comisionUsuario == null)
            {
                return NotFound();
            }

            comisionUsuario.Activo = false;
            comisionUsuario.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
