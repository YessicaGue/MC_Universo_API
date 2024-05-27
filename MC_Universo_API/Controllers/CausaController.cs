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
    public class CausaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CausaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CausaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Causa>>> Get()
        {
            return await _context.Causa.ToListAsync();
        }

        // GET api/<CausaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Causa>> Get(int id)
        {
            var causa = await _context.Causa.FindAsync(id);

            return causa == null ? NotFound() : causa;
        }

        // POST api/<CausaController>
        [HttpPost]
        public async Task<ActionResult<Causa>> Post(Causa causa)
        {
            _context.Causa.Add(causa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = causa.Id }, causa);
        }

        // PUT api/<CausaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Causa causa)
        {
            if (id != causa.Id)
                return BadRequest();

            _context.Entry(causa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var causaExists = await _context.Causa.FindAsync(id);
                if (causaExists == null)
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
