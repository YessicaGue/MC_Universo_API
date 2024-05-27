using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using Microsoft.AspNetCore.Mvc;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CaminoHeroeCiudadano
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoEtapasCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoEtapasCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/CatalogoEtapasCHC
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoEtapasCHC>>> Get()
        {
            return await _context.CatalogoEtapasCHC.ToListAsync();
        }

        // GET: api/CatalogoEtapasCHC/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoEtapasCHC>> Get(int id)
        {
            var catalogoEtapasCHC = await _context.CatalogoEtapasCHC.FindAsync(id);

            return catalogoEtapasCHC == null ? NotFound() : catalogoEtapasCHC;
        }

        // POST: api/CatalogoEtapasCHC
        [HttpPost]
        public async Task<ActionResult<CatalogoEtapasCHC>> Post(CatalogoEtapasCHCViewModel request)
        {
            CatalogoEtapasCHC catalogoEtapasCHC = _mapper.Map<CatalogoEtapasCHC>(request);
            _context.CatalogoEtapasCHC.Add(catalogoEtapasCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoEtapasCHC.Id }, catalogoEtapasCHC);
        }

        // PUT: api/CatalogoEtapasCHC/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoEtapasCHCViewModel request)
        {
            var catalogoEtapasCHC = await _context.CatalogoEtapasCHC.FindAsync(id);

            if (catalogoEtapasCHC == null)
                return NotFound();

            _mapper.Map(request, catalogoEtapasCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoEtapasCHC.Id }, catalogoEtapasCHC);
        }

        // DELETE: api/CatalogoEtapasCHC/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var catalogoEtapasCHC = await _context.CatalogoEtapasCHC.FindAsync(id);

            if (catalogoEtapasCHC == null)
                return NotFound();

            _context.CatalogoEtapasCHC.Remove(catalogoEtapasCHC);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("related")]
        public object GetRelated()
        {
            return  from catalogoEtapasCHC in _context.Set<CatalogoEtapasCHC>()

                    let catalogoCaminosCHC = _context.CatalogoCaminosCHC
                        .Where(catalogoCaminosCHC => catalogoEtapasCHC.CaminoId == catalogoCaminosCHC.Id)
                        .FirstOrDefault()

                    let catalogoTiposEtapasCHC = _context.CatalogoTiposEtapasCHC
                        .Where(catalogoTiposEtapasCHC => catalogoEtapasCHC.TipoEtapaId == catalogoTiposEtapasCHC.Id)
                        .FirstOrDefault()

                    orderby catalogoEtapasCHC.Id

                    select new
                    {
                        id = catalogoEtapasCHC.Id,
                        nombre = catalogoEtapasCHC.Nombre,
                        descripcion = catalogoEtapasCHC.Descripcion,
                        activo = catalogoEtapasCHC.Activo,
                        fechaCreacion = catalogoEtapasCHC.FechaCreacion,
                        catalogoCaminosCHC,
                        catalogoTiposEtapasCHC
                    };
        }
    }
}
