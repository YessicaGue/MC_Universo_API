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
    public class GeneroController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public GeneroController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<GeneroController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genero>>> Get()
        {
            return await _context.Genero.ToListAsync();
        }

        // GET api/<GeneroController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genero>> Get(int id)
        {
            var genero = await _context.Genero.FindAsync(id);

            return genero == null ? NotFound() : genero;
        }

        // POST api/<GeneroController>
        [HttpPost]
        public async Task<ActionResult<Genero>> Post(Genero genero)
        {
            _context.Genero.Add(genero);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = genero.Id }, genero);
        }

    }
}
