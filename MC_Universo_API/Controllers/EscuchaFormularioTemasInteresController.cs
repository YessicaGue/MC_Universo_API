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
    public class EscuchaFormularioTemasInteresController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public EscuchaFormularioTemasInteresController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<EscuchaFormularioTemasInteresController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EscuchaFormularioTemasInteres>>> Get()
        {
            return await _context.EscuchaFormularioTemasInteres.ToListAsync();
        }

        // GET api/<EscuchaFormularioTemasInteresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EscuchaFormularioTemasInteres>> Get(int id)
        {
            var escuchaFormularioTemasInteres = await _context.EscuchaFormularioTemasInteres.FindAsync(id);

            return escuchaFormularioTemasInteres == null ? NotFound() : escuchaFormularioTemasInteres;
        }

        // POST api/<EscuchaFormularioTemasInteresController>
        [HttpPost]
        public async Task<ActionResult<EscuchaFormularioTemasInteres>> Post(EscuchaFormularioTemasInteresViewModel request)
        {
            EscuchaFormularioTemasInteres escuchaFormularioTemasInteres = _mapper.Map<EscuchaFormularioTemasInteres>(request);
            _context.EscuchaFormularioTemasInteres.Add(escuchaFormularioTemasInteres);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = escuchaFormularioTemasInteres.Id }, escuchaFormularioTemasInteres);
        }

        // PUT api/<EscuchaFormularioTemasInteresController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, EscuchaFormularioTemasInteresViewModel request)
        {
            var escuchaFormularioTemasInteres = await _context.EscuchaFormularioTemasInteres.FindAsync(id);
            _mapper.Map(request, escuchaFormularioTemasInteres);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = escuchaFormularioTemasInteres.Id }, escuchaFormularioTemasInteres);
        }
    }
}
