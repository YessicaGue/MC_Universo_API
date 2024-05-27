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
    public class RespuestasEncuestaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RespuestasEncuestaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from encuesta in _context.Set<Encuesta>()

                        let respuestas = _context.RespuestasEncuesta
                            .Where(re => encuesta.Id == re.EncuestaId)
                            .DefaultIfEmpty()
                            .ToList()
                        
                        select new {
                            encuesta.Id,
                            encuesta.UsuarioId,
                            encuesta.FechaCreacion,
                            respuestas = respuestas
                                .Select(r =>
                                    new {
                                        pregunta = _context.CatalogoPreguntasEncuestas
                                            .Where(cpe => r.PreguntaId == cpe.Id)
                                            .FirstOrDefault(),
                                        respuesta = r.Respuesta
                                    }
                                )
                        };

            return query.ToList();
        }

        // GET: api/<RespuestasEncuestasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RespuestasEncuesta>>> Get()
        {
            return await _context.RespuestasEncuesta.ToListAsync();
        }

        // GET api/<RespuestasEncuestasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RespuestasEncuesta>> Get(int id)
        {
            var respuestasEncuestas = await _context.RespuestasEncuesta.FindAsync(id);

            if (respuestasEncuestas == null)
                return NotFound();

            return respuestasEncuestas;
        }

        // POST api/<RespuestasEncuestasController>
        [HttpPost]
        public async Task<ActionResult<RespuestasEncuesta>> Post(RespuestasEncuestaViewModel request)
        {
            RespuestasEncuesta respuestasEncuestas = _mapper.Map<RespuestasEncuesta>(request);
            _context.RespuestasEncuesta.Add(respuestasEncuestas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = respuestasEncuestas.Id }, respuestasEncuestas);
        }

        // PUT api/<RespuestasEncuestasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RespuestasEncuestaViewModel request)
        {
            RespuestasEncuesta respuestasEncuestas = _mapper.Map<RespuestasEncuesta>(request);
            if (id != respuestasEncuestas.Id)
                return BadRequest();

            _context.Entry(respuestasEncuestas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var respuestasEncuestasExists = await _context.RespuestasEncuesta.FindAsync(id);
                if (respuestasEncuestasExists == null)
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

        // DELETE api/<RespuestasEncuestasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
