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
    public class InteresController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public InteresController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<InteresController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interes>>> Get()
        {
            return await _context.Interes.ToListAsync();
        }

        // GET api/<InteresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Interes>> Get(int id)
        {
            var interes = await _context.Interes.FindAsync(id);

            return interes == null ? NotFound() : interes;
        }

        // POST api/<InteresController>
        [HttpPost]
        public async Task<ActionResult<Interes>> Post(Interes interes)
        {
            _context.Interes.Add(interes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = interes.Id }, interes);
        }

    }
}
