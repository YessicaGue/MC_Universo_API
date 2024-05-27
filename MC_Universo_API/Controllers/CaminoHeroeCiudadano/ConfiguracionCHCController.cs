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
    public class ConfiguracionCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ConfiguracionCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ConfiguracionCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConfiguracionCHC>>> Get()
        {
            return await _context.ConfiguracionCHC.ToListAsync();
        }

        // GET api/<ConfiguracionCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConfiguracionCHC>> Get(int id)
        {
            var configuracionCHC = await _context.ConfiguracionCHC.FindAsync(id);

            return configuracionCHC == null ? NotFound() : configuracionCHC;
        }
        // POST api/<ConfiguracionCHCController>
        [HttpPost]
        public async Task<ActionResult<ConfiguracionCHC>> Post(ConfiguracionCHCViewModel request)
        {
            ConfiguracionCHC configuracionCHC = _mapper.Map<ConfiguracionCHC>(request);
            _context.ConfiguracionCHC.Add(configuracionCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = configuracionCHC.Id }, configuracionCHC);
        }

        // PUT api/<ConfiguracionCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ConfiguracionCHCViewModel request)
        {
            var configuracionCHC = await _context.ConfiguracionCHC.FindAsync(id);
            _mapper.Map(request, configuracionCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = configuracionCHC.Id }, configuracionCHC);
        }

        // DELETE api/<ConfiguracionCHCController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
