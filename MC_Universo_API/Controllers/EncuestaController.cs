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
    public class EncuestaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public EncuestaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<EncuestasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Encuesta>>> Get()
        {
            return await _context.Encuesta.ToListAsync();
        }

        // GET api/<EncuestasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Encuesta>> Get(int id)
        {
            var encuestas = await _context.Encuesta.FindAsync(id);

            if (encuestas == null)
                return NotFound();

            return encuestas;
        }

        // POST api/<EncuestasController>
        [HttpPost]
        public async Task<ActionResult<Encuesta>> Post(EncuestaViewModel request)
        {
            Encuesta encuesta = _mapper.Map<Encuesta>(request);
            _context.Encuesta.Add(encuesta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = encuesta.Id }, encuesta);
        }

        // PUT api/<EncuestasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, EncuestaViewModel request)
        {
            Encuesta encuesta = _mapper.Map<Encuesta>(request);
            if (id != encuesta.Id)
                return BadRequest();

            _context.Entry(encuesta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var encuestasExists = await _context.Encuesta.FindAsync(id);
                if (encuestasExists == null)
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

        // DELETE api/<EncuestasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
