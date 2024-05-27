using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CaminoHeroeCiudadano
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilPersonaCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilPersonaCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PersonaPerfilCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilPersonaCHC>>> Get()
        {
            return await _context.PerfilPersonaCHC.ToListAsync();
        }

        // GET api/<PersonaPerfilCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilPersonaCHC>> Get(int id)
        {
            var personaPerfilCHC = await _context.PerfilPersonaCHC.FindAsync(id);

            return personaPerfilCHC == null ? NotFound() : personaPerfilCHC;
        }

        // POST api/<PersonaPerfilCHCController>
        [HttpPost]
        public async Task<ActionResult<PerfilPersonaCHC>> Post(PersonaPerfilCHCViewModel request)
        {
            PerfilPersonaCHC personaPerfilCHC = _mapper.Map<PerfilPersonaCHC>(request);
            _context.PerfilPersonaCHC.Add(personaPerfilCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = personaPerfilCHC.Id }, personaPerfilCHC);
        }

        // PUT api/<PersonaPerfilCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilPersonaCHC request)
        {
            var personaPerfilCHC = await _context.ExamenesCHC.FindAsync(id);
            _mapper.Map(request, personaPerfilCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = personaPerfilCHC.Id }, personaPerfilCHC);
        }

        // DELETE api/<PersonaPerfilCCHController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
