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
    public class CatalogoTiposEtapasCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoTiposEtapasCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoTiposEtapasCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoTiposEtapasCHC>>> Get()
        {
            return await _context.CatalogoTiposEtapasCHC.ToListAsync();
        }

        // GET api/<CatalogoTiposEtapasCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoTiposEtapasCHC>> Get(int id)
        {
            var catalogoTiposEtapasCHC = await _context.CatalogoTiposEtapasCHC.FindAsync(id);

            return catalogoTiposEtapasCHC == null ? NotFound() : catalogoTiposEtapasCHC;
        }
        // POST api/<CatalogoTiposEtapasCHCController>
        [HttpPost]
        public async Task<ActionResult<CatalogoTiposEtapasCHC>> Post(CatalogoTiposEtapasCHCViewModel request)
        {
            CatalogoTiposEtapasCHC catalogoTiposEtapasCHC = _mapper.Map<CatalogoTiposEtapasCHC>(request);
            _context.CatalogoTiposEtapasCHC.Add(catalogoTiposEtapasCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTiposEtapasCHC.Id }, catalogoTiposEtapasCHC);
        }

        // PUT api/<CatalogoTiposEtapasCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoTiposEtapasCHCViewModel request)
        {
            var catalogoTiposEtapasCHC = await _context.CatalogoTiposEtapasCHC.FindAsync(id);
            _mapper.Map(request, catalogoTiposEtapasCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTiposEtapasCHC.Id }, catalogoTiposEtapasCHC);
        }

        // DELETE api/<CatalogoTiposEtapasCHCController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
