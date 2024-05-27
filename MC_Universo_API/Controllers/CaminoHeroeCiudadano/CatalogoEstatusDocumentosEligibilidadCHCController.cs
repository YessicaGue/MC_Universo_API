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
    public class CatalogoEstatusDocumentosEligibilidadCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoEstatusDocumentosEligibilidadCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoEstatusDocumentosEligibilidadCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoEstatusDocumentosEligibilidadCHC>>> Get()
        {
            return await _context.CatalogoEstatusDocumentosEligibilidadCHC.ToListAsync();
        }

        // GET api/<CatalogoEstatusDocumentosEligibilidadCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoEstatusDocumentosEligibilidadCHC>> Get(int id)
        {
            var catalogoEstatusDocumentosEligibilidadCHC = await _context.CatalogoEstatusDocumentosEligibilidadCHC.FindAsync(id);

            return catalogoEstatusDocumentosEligibilidadCHC == null ? NotFound() : catalogoEstatusDocumentosEligibilidadCHC;
        }
        // POST api/<CatalogoEstatusDocumentosEligibilidadCHCController>
        [HttpPost]
        public async Task<ActionResult<CatalogoEstatusDocumentosEligibilidadCHC>> Post(CatalogoEstatusDocumentosEligibilidadCHCViewModel request)
        {
            CatalogoEstatusDocumentosEligibilidadCHC catalogoEstatusDocumentosEligibilidadCHC = _mapper.Map<CatalogoEstatusDocumentosEligibilidadCHC>(request);
            _context.CatalogoEstatusDocumentosEligibilidadCHC.Add(catalogoEstatusDocumentosEligibilidadCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoEstatusDocumentosEligibilidadCHC.Id }, catalogoEstatusDocumentosEligibilidadCHC);
        }

        // PUT api/<CatalogoEstatusDocumentosEligibilidadCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoEstatusDocumentosEligibilidadCHCViewModel request)
        {
            var catalogoEstatusDocumentosEligibilidadCHC = await _context.CatalogoEstatusDocumentosEligibilidadCHC.FindAsync(id);
            _mapper.Map(request, catalogoEstatusDocumentosEligibilidadCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoEstatusDocumentosEligibilidadCHC.Id }, catalogoEstatusDocumentosEligibilidadCHC);
        }

        // DELETE api/<CatalogoEstatusDocumentosEligibilidadCHCController>/5
       // [HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
