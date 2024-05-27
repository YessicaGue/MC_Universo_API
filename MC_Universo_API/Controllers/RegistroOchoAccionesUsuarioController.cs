using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroOchoAccionesUsuarioController : ControllerBase
    {
        private readonly UniversoContext _context;

        public RegistroOchoAccionesUsuarioController(UniversoContext context)
        {
            _context = context;
        }

        // GET: api/<RegistroOchoAccionesUsuarioUsuarioController>/related
        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from registroOchoAccionesUsuario in _context.Set<RegistroOchoAccionesUsuario>()

                        let registroOchoAccionesUsuarioCatalogoOchoAccionesUsuario = _context.RegistroOchoAccionesUsuarioCatalogoOchoAcciones
                            .Where(roacoa => registroOchoAccionesUsuario.Id == roacoa.RegistroOchoAccionesUsuarioId)
                            .DefaultIfEmpty()
                            .ToList()

                        let respuestasOchoAccionesUsuario = _context.RespuestasOchoAccionesRegistroOchoAccionesUsuario
                            .Where(roa => registroOchoAccionesUsuario.Id == roa.RegistroOchoAccionesUsuarioId)
                            .DefaultIfEmpty()
                            .ToList()

                        select new
                        {
                            registroOchoAccionesUsuario.Id,
                            registroOchoAccionesUsuario.UsuarioId,
                            registroOchoAccionesUsuario.FechaCreacion,
                            acciones = registroOchoAccionesUsuarioCatalogoOchoAccionesUsuario
                                .Select(roaucoau => 
                                    _context.CatalogoOchoAcciones
                                        .Where(coa => roaucoau.CatalogoOchoAccionesId == coa.Id)
                                        .FirstOrDefault()
                                ),
                            respuestas = respuestasOchoAccionesUsuario
                                .Select(roau => 
                                    new { 
                                        pregunta = _context.CatalogoPreguntasOchoAcciones
                                            .Where(cpoa => roau.PreguntaId == cpoa.Id)
                                            .FirstOrDefault(),
                                        respuesta = roau.Respuesta 
                                    }
                                ),
                        };

            return query.ToList();
        }

        // GET: api/<RegistroOchoAccionesUsuarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroOchoAccionesUsuario>>> Get()
        {
            return await _context.RegistroOchoAccionesUsuario.ToListAsync();
        }

        // GET api/<RegistroOchoAccionesUsuarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroOchoAccionesUsuario>> Get(int id)
        {
            var registroOchoAccionesUsuario = await _context.RegistroOchoAccionesUsuario.FindAsync(id);

            if (registroOchoAccionesUsuario == null)
                return NotFound();

            return registroOchoAccionesUsuario;
        }

        // POST api/<RegistroOchoAccionesUsuarioController>
        [HttpPost]
        public async Task<ActionResult<RegistroOchoAccionesUsuario>> Post(RegistroOchoAccionesUsuario registroOchoAccionesUsuario)
        {
            _context.RegistroOchoAccionesUsuario.Add(registroOchoAccionesUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroOchoAccionesUsuario.Id }, registroOchoAccionesUsuario);
        }

        // PUT api/<RegistroOchoAccionesUsuarioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RegistroOchoAccionesUsuario registroOchoAccionesUsuario)
        {
            if (id != registroOchoAccionesUsuario.Id)
                return BadRequest();

            _context.Entry(registroOchoAccionesUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var registroOchoAccionesUsuarioExists = await _context.RegistroOchoAccionesUsuario.FindAsync(id);
                if (registroOchoAccionesUsuarioExists == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
    }
}
