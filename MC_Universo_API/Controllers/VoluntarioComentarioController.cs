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
    public class VoluntarioComentarioController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public VoluntarioComentarioController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<VoluntarioComentarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoluntarioComentario>>> Get()
        {
            return await _context.VoluntarioComentario.ToListAsync();
        }

        // GET api/<VoluntarioComentarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoluntarioComentario>> Get(int id)
        {
            var voluntarioComentario = await _context.VoluntarioComentario.FindAsync(id);

            return voluntarioComentario == null ? NotFound() : voluntarioComentario;
        }

        // GET api/<VoluntarioComentarioController>/voluntario=5
        [HttpGet("voluntario={id}")]
        public async Task<ActionResult<IEnumerable<VoluntarioComentario>>> GetByVoluntario(int id)
        {
            var voluntarioComentario = await _context.VoluntarioComentario.Where(acc => acc.VoluntarioId == id).ToListAsync();

            return voluntarioComentario == null ? NotFound() : voluntarioComentario;
        }


        // POST api/<VoluntarioComentarioController>
        [HttpPost]
        public async Task<ActionResult<VoluntarioComentario>> Post(VoluntarioComentarioViewModel request)
        {
            VoluntarioComentario voluntarioComentario = _mapper.Map<VoluntarioComentario>(request);
            _context.VoluntarioComentario.Add(voluntarioComentario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntarioComentario.Id }, voluntarioComentario);
        }

        // PUT api/<VoluntarioComentarioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, VoluntarioComentarioViewModel request)
        {
            var voluntarioComentario = await _context.VoluntarioComentario.FindAsync(id);
            _mapper.Map(request, voluntarioComentario);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntarioComentario.Id }, voluntarioComentario);
        }

        // DELETE api/<VoluntarioComentarioController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var voluntarioComentario = await _context.VoluntarioComentario.FindAsync(id);
            if (voluntarioComentario == null)
                return NotFound();

            _context.VoluntarioComentario.Remove(voluntarioComentario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
