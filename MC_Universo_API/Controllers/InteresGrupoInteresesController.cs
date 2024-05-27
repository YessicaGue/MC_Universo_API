using AutoMapper;
using Azure.Core;
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
    public class InteresGrupoInteresesController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public InteresGrupoInteresesController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<InteresGrupoInteresesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InteresGrupoIntereses>>> Get()
        {
            return await _context.InteresGrupoIntereses.ToListAsync();
        }

        // GET api/<InteresGrupoInteresesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InteresGrupoIntereses>> Get(int id)
        {
            var interesGrupoIntereses = await _context.InteresGrupoIntereses.FindAsync(id);

            return interesGrupoIntereses == null ? NotFound() : interesGrupoIntereses;
        }

        // GET api/<InteresGrupoInteresesController>/interes=5
        [HttpGet("interes={id}")]
        public async Task<ActionResult<IEnumerable<InteresGrupoIntereses>>> GetByInteres(int id)
        {
            var interesGrupoIntereses = await _context.InteresGrupoIntereses.Where(acc => acc.InteresId == id).ToListAsync();

            return interesGrupoIntereses == null ? NotFound() : interesGrupoIntereses;
        }

        // GET api/<InteresGrupoInteresesController>/grupo-interes=5
        [HttpGet("grupo-interes={id}")]
        public async Task<ActionResult<IEnumerable<InteresGrupoIntereses>>> GetByGrupoInteres(int id)
        {
            var interesGrupoIntereses = await _context.InteresGrupoIntereses.Where(acc => acc.GrupoInteresesId == id).ToListAsync();

            return interesGrupoIntereses == null ? NotFound() : interesGrupoIntereses;
        }

        // POST api/<InteresGrupoInteresesController>
        [HttpPost]
        public async Task<ActionResult<InteresGrupoIntereses>> Post(InteresGrupoInteresesViewModel request)
        {
            InteresGrupoIntereses interesGrupoIntereses = _mapper.Map<InteresGrupoIntereses>(request);
            _context.InteresGrupoIntereses.Add(interesGrupoIntereses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = interesGrupoIntereses.Id }, interesGrupoIntereses);
        }

    }
}
