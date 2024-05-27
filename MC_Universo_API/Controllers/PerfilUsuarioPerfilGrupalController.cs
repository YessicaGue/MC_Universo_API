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
    public class PerfilUsuarioPerfilGrupalController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilUsuarioPerfilGrupalController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PerfilUsuarioPerfilController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilUsuarioPerfilGrupal>>> Get()
        {
            return await _context.PerfilUsuarioPerfilGrupal.ToListAsync();
        }

        // GET api/<PerfilUsuarioPerfilController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilUsuarioPerfilGrupal>> Get(int id)
        {
            var perfilUsuarioPerfilGrupal = await _context.PerfilUsuarioPerfilGrupal.FindAsync(id);

            return perfilUsuarioPerfilGrupal == null ? NotFound() : perfilUsuarioPerfilGrupal;
        }

        // POST api/<PerfilUsuarioPerfilController>
        [HttpPost]
        public async Task<ActionResult<PerfilUsuarioPerfilGrupal>> Post(PerfilUsuarioPerfilGrupalViewModel request)
        {
            PerfilUsuarioPerfilGrupal perfilUsuarioPerfilGrupal = _mapper.Map<PerfilUsuarioPerfilGrupal>(request);
            _context.PerfilUsuarioPerfilGrupal.Add(perfilUsuarioPerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilUsuarioPerfilGrupal.Id }, perfilUsuarioPerfilGrupal);
        }

        // PUT api/<PerfilUsuarioPerfilController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilUsuarioPerfilGrupalViewModel request)
        {
            var perfilUsuarioPerfilGrupal = await _context.PerfilUsuarioPerfilGrupal.FindAsync(id);

            if (perfilUsuarioPerfilGrupal == null)
                return NotFound();

            _mapper.Map(request, perfilUsuarioPerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilUsuarioPerfilGrupal.Id }, perfilUsuarioPerfilGrupal);
        }

        [HttpGet("pu={id}")]
        public async Task<ActionResult<IEnumerable<PerfilUsuarioPerfilGrupal>>> GetByPerfilUsuario(int id)
        {
            var perfilUsuarioPerfilGrupal = await _context.PerfilUsuarioPerfilGrupal.Where(up => up.PerfilUsuarioId == id).DefaultIfEmpty().ToListAsync();

            return perfilUsuarioPerfilGrupal;
        }
    }
}
