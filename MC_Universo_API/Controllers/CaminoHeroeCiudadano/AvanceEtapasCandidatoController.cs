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
    public class AvanceEtapasCandidatoController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public AvanceEtapasCandidatoController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<AvanceEtapasCandidatoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AvanceEtapasCandidato>>> Get()
        {
            return await _context.AvanceEtapasCandidato.ToListAsync();
        }

        // GET api/<AvanceEtapasCandidatoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AvanceEtapasCandidato>> Get(int id)
        {
            var catalogoNivelesCargos = await _context.AvanceEtapasCandidato.FindAsync(id);

            return catalogoNivelesCargos == null ? NotFound() : catalogoNivelesCargos;
        }

        // POST api/<AvanceEtapasCandidatoController>
        [HttpPost]
        public async Task<ActionResult<AvanceEtapasCandidato>> Post(AvanceEtapasCandidatoViewModel request)
        {
            AvanceEtapasCandidato catalogoNivelesCargos = _mapper.Map<AvanceEtapasCandidato>(request);
            _context.AvanceEtapasCandidato.Add(catalogoNivelesCargos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoNivelesCargos.Id }, catalogoNivelesCargos);
        }

        // PUT api/<AvanceEtapasCandidatoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, AvanceEtapasCandidatoViewModel request)
        {
            var catalogoNivelesCargos = await _context.AvanceEtapasCandidato.FindAsync(id);

            if (catalogoNivelesCargos == null)
            { 
                return NotFound();
            }

            _mapper.Map(request, catalogoNivelesCargos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoNivelesCargos.Id }, catalogoNivelesCargos);
        }

        // DELETE api/<AvanceEtapasCandidatoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
