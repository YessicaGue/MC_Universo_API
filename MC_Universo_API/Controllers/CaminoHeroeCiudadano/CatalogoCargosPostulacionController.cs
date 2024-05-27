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
    public class CatalogoCargosPostulacionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoCargosPostulacionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoCargosPostulacionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoCargosPostulacion>>> Get()
        {
            return await _context.CatalogoCargosPostulacion.ToListAsync();
        }

        // GET api/<CatalogoCargosPostulacionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoCargosPostulacion>> Get(int id)
        {
            var catalogoTiposEtapasCHC = await _context.CatalogoCargosPostulacion.FindAsync(id);

            return catalogoTiposEtapasCHC == null ? NotFound() : catalogoTiposEtapasCHC;
        }
        // POST api/<CatalogoCargosPostulacionController>
        [HttpPost]
        public async Task<ActionResult<CatalogoCargosPostulacion>> Post(CatalogoCargosPostulacionViewModel request)
        {
            CatalogoCargosPostulacion catalogoTiposEtapasCHC = _mapper.Map<CatalogoCargosPostulacion>(request);
            _context.CatalogoCargosPostulacion.Add(catalogoTiposEtapasCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTiposEtapasCHC.Id }, catalogoTiposEtapasCHC);
        }

        // PUT api/<CatalogoCargosPostulacionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoCargosPostulacionViewModel request)
        {
            var catalogoTiposEtapasCHC = await _context.CatalogoCargosPostulacion.FindAsync(id);
            _mapper.Map(request, catalogoTiposEtapasCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTiposEtapasCHC.Id }, catalogoTiposEtapasCHC);
        }

        // DELETE api/<CatalogoCargosPostulacionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
