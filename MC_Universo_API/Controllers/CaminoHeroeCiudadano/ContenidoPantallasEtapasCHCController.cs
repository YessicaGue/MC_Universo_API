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
    public class ContenidoPantallasEtapasCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ContenidoPantallasEtapasCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ContenidoPantallasEtapasCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContenidoPantallasEtapasCHC>>> Get()
        {
            return await _context.ContenidoPantallasEtapasCHC.ToListAsync();
        }

        // GET api/<ContenidoPantallasEtapasCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContenidoPantallasEtapasCHC>> Get(int id)
        {
            var contenidoPantallasEtapasCHC = await _context.ContenidoPantallasEtapasCHC.FindAsync(id);

            return contenidoPantallasEtapasCHC == null ? NotFound() : contenidoPantallasEtapasCHC;
        }

        // POST api/<ContenidoPantallasEtapasCHCController>
        [HttpPost]
        public async Task<ActionResult<ContenidoPantallasEtapasCHC>> Post(ContenidoPantallasEtapasCHCViewModel request)
        {
            ContenidoPantallasEtapasCHC contenidoPantallasEtapasCHC = _mapper.Map<ContenidoPantallasEtapasCHC>(request);
            _context.ContenidoPantallasEtapasCHC.Add(contenidoPantallasEtapasCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = contenidoPantallasEtapasCHC.Id }, contenidoPantallasEtapasCHC);
        }

        // PUT api/<ContenidoPantallasEtapasCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ContenidoPantallasEtapasCHCViewModel request)
        {
            var contenidoPantallasEtapasCHC = await _context.ContenidoPantallasEtapasCHC.FindAsync(id);
            _mapper.Map(request, contenidoPantallasEtapasCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = contenidoPantallasEtapasCHC.Id }, contenidoPantallasEtapasCHC);
        }

        // DELETE: api/CatalogoEtapasCHC/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var contenidoPantallasEtapasCHC = await _context.ContenidoPantallasEtapasCHC.FindAsync(id);

            if (contenidoPantallasEtapasCHC == null)
                return NotFound();

            _context.ContenidoPantallasEtapasCHC.Remove(contenidoPantallasEtapasCHC);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("related")]
        public object GetRelated ()
        {
            return from contenidoPantallasEtapasCHC in _context.Set<ContenidoPantallasEtapasCHC>()

                   let contenidoPantallasEtapasCHCCatalogoEtapasCHC = _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC
                       .Where(contenidoPantallasEtapasCHCCatalogoEtapasCHC =>
                           contenidoPantallasEtapasCHC.Id == contenidoPantallasEtapasCHCCatalogoEtapasCHC.ContenidoPantallasEtapasCHCId
                        )
                       .DefaultIfEmpty()
                       .ToList()

                   let catalogoEtapasCHC = contenidoPantallasEtapasCHCCatalogoEtapasCHC
                       .Select(cc =>
                           _context.CatalogoEtapasCHC
                               .Where(ce => cc.CatalogoEtapasCHCId == ce.Id)
                               .FirstOrDefault()
                       )

                   select new
                   {
                       id = contenidoPantallasEtapasCHC.Id,
                       contenido = contenidoPantallasEtapasCHC.Contenido,
                       activo = contenidoPantallasEtapasCHC.Activo,
                       fechaCreacion = contenidoPantallasEtapasCHC.FechaCreacion,
                       fechaActualizacion = contenidoPantallasEtapasCHC.FechaActualizacion,
                       catalogoEtapasCHC
                   };
        }

        [HttpGet("related/{id}")]
        public object GetRelated(int id)
        {
            return from contenidoPantallasEtapasCHC in _context.Set<ContenidoPantallasEtapasCHC>()

                   let contenidoPantallasEtapasCHCCatalogoEtapasCHC = _context.ContenidoPantallasEtapasCHCCatalogoEtapasCHC
                       .Where(contenidoPantallasEtapasCHCCatalogoEtapasCHC =>
                           contenidoPantallasEtapasCHC.Id == contenidoPantallasEtapasCHCCatalogoEtapasCHC.ContenidoPantallasEtapasCHCId
                        )
                       .DefaultIfEmpty()
                       .ToList()

                   let catalogoEtapasCHC = contenidoPantallasEtapasCHCCatalogoEtapasCHC
                       .Select(cc =>
                           _context.CatalogoEtapasCHC
                               .Where(ce => cc.CatalogoEtapasCHCId == ce.Id)
                               .FirstOrDefault()
                       )

                   where contenidoPantallasEtapasCHC.Id == id

                   select new
                   {
                       id = contenidoPantallasEtapasCHC.Id,
                       contenido = contenidoPantallasEtapasCHC.Contenido,
                       activo = contenidoPantallasEtapasCHC.Activo,
                       fechaCreacion = contenidoPantallasEtapasCHC.FechaCreacion,
                       fechaActualizacion = contenidoPantallasEtapasCHC.FechaActualizacion,
                       catalogoEtapasCHC
                   };
        }
    }
}
