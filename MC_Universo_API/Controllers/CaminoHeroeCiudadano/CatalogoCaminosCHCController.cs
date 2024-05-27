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
    public class CatalogoCaminosCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoCaminosCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoCaminosCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoCaminosCHC>>> Get()
        {
            return await _context.CatalogoCaminosCHC.ToListAsync();
        }

        // GET api/<CatalogoCaminosCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoCaminosCHC>> Get(int id)
        {
            var catalogoCaminosCHC = await _context.CatalogoCaminosCHC.FindAsync(id);

            return catalogoCaminosCHC == null ? NotFound() : catalogoCaminosCHC;
        }
        // POST api/<CatalogoCaminosCHCController>
        [HttpPost]
        public async Task<ActionResult<CatalogoCaminosCHC>> Post(CatalogoCaminosCHCViewModel request)
        {
            CatalogoCaminosCHC catalogoCaminosCHC = _mapper.Map<CatalogoCaminosCHC>(request);
            _context.CatalogoCaminosCHC.Add(catalogoCaminosCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoCaminosCHC.Id }, catalogoCaminosCHC);
        }

        // PUT api/<CatalogoCaminosCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoCaminosCHCViewModel request)
        {
            var catalogoCaminosCHC = await _context.CatalogoCaminosCHC.FindAsync(id);
            _mapper.Map(request, catalogoCaminosCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoCaminosCHC.Id }, catalogoCaminosCHC);
        }

        // DELETE api/<CatalogoCaminosCHCController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
