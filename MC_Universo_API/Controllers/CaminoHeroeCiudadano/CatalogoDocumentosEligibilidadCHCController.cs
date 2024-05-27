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
    public class CatalogoDocumentosEligibilidadCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoDocumentosEligibilidadCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoDocumentosEligibilidadCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoDocumentosEligibilidadCHC>>> Get()
        {
            return await _context.CatalogoDocumentosEligibilidadCHC.ToListAsync();
        }

        // GET api/<CatalogoDocumentosEligibilidadCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoDocumentosEligibilidadCHC>> Get(int id)
        {
            var catalogoDocumentosEligibilidadCHC = await _context.CatalogoDocumentosEligibilidadCHC.FindAsync(id);

            return catalogoDocumentosEligibilidadCHC == null ? NotFound() : catalogoDocumentosEligibilidadCHC;
        }
        // POST api/<CatalogoDocumentosEligibilidadCHCController>
        [HttpPost]
        public async Task<ActionResult<CatalogoDocumentosEligibilidadCHC>> Post(CatalogoDocumentosEligibilidadCHCViewModel request)
        {
            CatalogoDocumentosEligibilidadCHC catalogoDocumentosEligibilidadCHC = _mapper.Map<CatalogoDocumentosEligibilidadCHC>(request);
            _context.CatalogoDocumentosEligibilidadCHC.Add(catalogoDocumentosEligibilidadCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoDocumentosEligibilidadCHC.Id }, catalogoDocumentosEligibilidadCHC);
        }

        // PUT api/<CatalogoDocumentosEligibilidadCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoDocumentosEligibilidadCHCViewModel request)
        {
            var catalogoDocumentosEligibilidadCHC = await _context.CatalogoDocumentosEligibilidadCHC.FindAsync(id);
            _mapper.Map(request, catalogoDocumentosEligibilidadCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoDocumentosEligibilidadCHC.Id }, catalogoDocumentosEligibilidadCHC);
        }

        // DELETE api/<CatalogoDocumentosEligibilidadCHCController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
