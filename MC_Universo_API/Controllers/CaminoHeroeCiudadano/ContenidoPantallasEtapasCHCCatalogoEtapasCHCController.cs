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
    public class ContenidoPantallasEtapasCHCCatalogoEtapasCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ContenidoPantallasEtapasCHCCatalogoEtapasCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ContenidoPantallasEtapasCHCCatalogoEtapasCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContenidoPantallasEtapasCHCCatalogoEtapasCHC>>> Get()
        {
            return await _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC.ToListAsync();
        }

        // GET api/<ContenidoPantallasEtapasCHCCatalogoEtapasCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContenidoPantallasEtapasCHCCatalogoEtapasCHC>> Get(int id)
        {
            var contenidoPantallasEtapasCHCCatalogoEtapasCHC = await _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC.FindAsync(id);

            return contenidoPantallasEtapasCHCCatalogoEtapasCHC == null ? NotFound() : contenidoPantallasEtapasCHCCatalogoEtapasCHC;
        }

        // POST api/<ContenidoPantallasEtapasCHCCatalogoEtapasCHCController>
        [HttpPost]
        public async Task<ActionResult<ContenidoPantallasEtapasCHCCatalogoEtapasCHC>> Post(ContenidoPantallasEtapasCHCCatalogoEtapasCHCViewModel request)
        {
            ContenidoPantallasEtapasCHCCatalogoEtapasCHC contenidoPantallasEtapasCHCCatalogoEtapasCHC = _mapper.Map<ContenidoPantallasEtapasCHCCatalogoEtapasCHC>(request);
            _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC.Add(contenidoPantallasEtapasCHCCatalogoEtapasCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = contenidoPantallasEtapasCHCCatalogoEtapasCHC.Id }, contenidoPantallasEtapasCHCCatalogoEtapasCHC);
        }

        // PUT api/<ContenidoPantallasEtapasCHCCatalogoEtapasCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ContenidoPantallasEtapasCHCCatalogoEtapasCHCViewModel request)
        {
            var contenidoPantallasEtapasCHCCatalogoEtapasCHC = await _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC.FindAsync(id);

            if (contenidoPantallasEtapasCHCCatalogoEtapasCHC == null)
                return NotFound();

            _mapper.Map(request, contenidoPantallasEtapasCHCCatalogoEtapasCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = contenidoPantallasEtapasCHCCatalogoEtapasCHC.Id }, contenidoPantallasEtapasCHCCatalogoEtapasCHC);
        }

        // DELETE: api/CatalogoEtapasCHC/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var contenidoPantallasEtapasCHCCatalogoEtapasCHC = await _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC.FindAsync(id);

            if (contenidoPantallasEtapasCHCCatalogoEtapasCHC == null)
                return NotFound();

            _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC.Remove(contenidoPantallasEtapasCHCCatalogoEtapasCHC);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET: api/ContenidoPantallasEtapasCHCCatalogoEtapasCHC/related?
        [HttpGet("related")]
        public object GetRelated([FromQuery] int CatalogoEtapasCHCId, [FromQuery] int ContenidoPantallasEtapasCHCId)
        {
            return from contenidoPantallasEtapasCHCCatalogoEtapasCHC in _context.Set<ContenidoPantallasEtapasCHCCatalogoEtapasCHC>()

                   let catalogoEtapasCHC = _context.CatalogoEtapasCHC
                       .Where(catalogoEtapasCHC =>
                            contenidoPantallasEtapasCHCCatalogoEtapasCHC.CatalogoEtapasCHCId == catalogoEtapasCHC.Id
                        )
                       .DefaultIfEmpty()
                       .ToList()

                   let contenidoPantallasEtapasCHC = _context.ContenidoPantallasEtapasCHC
                       .Where(contenidoPantallasEtapasCHC =>
                            contenidoPantallasEtapasCHCCatalogoEtapasCHC.ContenidoPantallasEtapasCHCId == contenidoPantallasEtapasCHC.Id
                        )
                       .DefaultIfEmpty()
                       .ToList()

                   where
                       CatalogoEtapasCHCId > 0
                           ? contenidoPantallasEtapasCHCCatalogoEtapasCHC.CatalogoEtapasCHCId == CatalogoEtapasCHCId
                           : true

                   where
                       ContenidoPantallasEtapasCHCId > 0
                           ? contenidoPantallasEtapasCHCCatalogoEtapasCHC.ContenidoPantallasEtapasCHCId == ContenidoPantallasEtapasCHCId
                           : true

                   where contenidoPantallasEtapasCHCCatalogoEtapasCHC.Activo == true

                   orderby contenidoPantallasEtapasCHCCatalogoEtapasCHC.Id

                   select new
                   {
                       id = contenidoPantallasEtapasCHCCatalogoEtapasCHC.Id,
                       activo = contenidoPantallasEtapasCHCCatalogoEtapasCHC.Activo,
                       fechaCreacion = contenidoPantallasEtapasCHCCatalogoEtapasCHC.FechaCreacion,
                       fechaActualizacion = contenidoPantallasEtapasCHCCatalogoEtapasCHC.FechaActualizacion,
                       catalogoEtapasCHC,
                       contenidoPantallasEtapasCHC
                   };
        }

        [HttpGet("related/{id}")]
        public object GetRelated(int id)
        {
            return from contenidoPantallasEtapasCHCCatalogoEtapasCHC in _context.Set<ContenidoPantallasEtapasCHCCatalogoEtapasCHC>()

                   let catalogoEtapasCHC = _context.CatalogoEtapasCHC
                       .Where(catalogoEtapasCHC =>
                            contenidoPantallasEtapasCHCCatalogoEtapasCHC.CatalogoEtapasCHCId == catalogoEtapasCHC.Id
                        )
                       .DefaultIfEmpty()
                       .ToList()

                   let contenidoPantallasEtapasCHC = _context.ContenidoPantallasEtapasCHC
                       .Where(contenidoPantallasEtapasCHC =>
                            contenidoPantallasEtapasCHCCatalogoEtapasCHC.ContenidoPantallasEtapasCHCId == contenidoPantallasEtapasCHC.Id
                        )
                       .DefaultIfEmpty()
                       .ToList()

                   where contenidoPantallasEtapasCHCCatalogoEtapasCHC.Id == id

                   where contenidoPantallasEtapasCHCCatalogoEtapasCHC.Activo == true

                   orderby contenidoPantallasEtapasCHCCatalogoEtapasCHC.Id

                   select new
                   {
                       id = contenidoPantallasEtapasCHCCatalogoEtapasCHC.Id,
                       activo = contenidoPantallasEtapasCHCCatalogoEtapasCHC.Activo,
                       fechaCreacion = contenidoPantallasEtapasCHCCatalogoEtapasCHC.FechaCreacion,
                       fechaActualizacion = contenidoPantallasEtapasCHCCatalogoEtapasCHC.FechaActualizacion,
                       catalogoEtapasCHC,
                       contenidoPantallasEtapasCHC
                   };
        }

        [HttpDelete("related")]
        public async Task<IActionResult> DeleteRelated([FromQuery] int CatalogoEtapasCHCId, [FromQuery] int ContenidoPantallasEtapasCHCId)
        {
            if (CatalogoEtapasCHCId <= 0 && ContenidoPantallasEtapasCHCId <= 0)
                return BadRequest();

            if (CatalogoEtapasCHCId > 0)
            {
                var contenidoPantallasEtapasCHCCatalogoEtapasCHC = await _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC
                    .Where(c => c.CatalogoEtapasCHCId == CatalogoEtapasCHCId)
                    .ToListAsync();

                foreach (var row in contenidoPantallasEtapasCHCCatalogoEtapasCHC)
                {
                    _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC.Remove(row);
                }
            }

            if (ContenidoPantallasEtapasCHCId > 0)
            {
                var contenidoPantallasEtapasCHCCatalogoEtapasCHC = await _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC
                    .Where(c => c.ContenidoPantallasEtapasCHCId == ContenidoPantallasEtapasCHCId)
                    .ToListAsync();

                foreach (var row in contenidoPantallasEtapasCHCCatalogoEtapasCHC)
                {
                    _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC.Remove(row);
                }
            }

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
