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
    public class DireccionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public DireccionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Direccion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Direccion>>> Get()
        {
            return await _context.Direccion.ToListAsync();
        }

        // GET: api/Direccion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Direccion>> Get(int id)
        {
            var direccion = await _context.Direccion.FindAsync(id);

            return direccion == null ? NotFound() : direccion;
        }

        // POST: api/Direccion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Direccion>> Post(DireccionViewModel request)
        {
            Direccion direccion = _mapper.Map<Direccion>(request);
            _context.Direccion.Add(direccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = direccion.Id }, direccion);
        }

        // PUT: api/Direccion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, DireccionViewModel request)
        {
            var direccion = await _context.Direccion.FindAsync(id);

            if (direccion == null)
                return NotFound();

            _mapper.Map(request, direccion);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = direccion.Id }, direccion);
        }

        // DELETE: api/Direccion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var direccion = await _context.Direccion.FindAsync(id);

            if (direccion == null)
                return NotFound();

            _context.Direccion.Remove(direccion);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET: api/Direccion/related
        [HttpGet("related")]
        public async Task<ActionResult<IEnumerable<Direccion>>> GetRelated()
        {
            return await _context.Direccion.ToListAsync();
        }

        // GET: api/Direccion/related/5
        [HttpGet("related/{id}")]
        public async Task<ActionResult<Direccion>> GetRelated(int id)
        {
            var direccion = await _context.Direccion.FindAsync(id);

            return direccion == null ? NotFound() : direccion;
        }
    }
}
