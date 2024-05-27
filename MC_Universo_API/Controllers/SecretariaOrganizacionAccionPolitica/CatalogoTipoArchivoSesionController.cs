using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.SecretariaOrganizacionAccionPolitica
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoTipoArchivoSesionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoTipoArchivoSesionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoTipoArchivoSesionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoTipoArchivoSesion>>> Get()
        {
            return await _context.CatalogoTipoArchivoSesion.ToListAsync();
        }

        // GET: api/<CatalogoTipoArchivoSesionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoTipoArchivoSesion>> Get(int id)
        {
            var catalogoTipoArchivoSesion = await _context.CatalogoTipoArchivoSesion.FindAsync(id);

            return catalogoTipoArchivoSesion == null ? NotFound() : catalogoTipoArchivoSesion;
        }

        // POST: api/<CatalogoTipoArchivoSesionController>
        [HttpPost]
        public async Task<ActionResult<CatalogoTipoArchivoSesion>> Post(CatalogoTipoArchivoSesionViewModel request)
        {
            CatalogoTipoArchivoSesion catalogoTipoArchivoSesion = _mapper.Map<CatalogoTipoArchivoSesion>(request);
            _context.CatalogoTipoArchivoSesion.Add(catalogoTipoArchivoSesion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTipoArchivoSesion.Id }, catalogoTipoArchivoSesion);
        }

        // PUT: api/<CatalogoTipoArchivoSesionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoTipoArchivoSesionViewModel request)
        {
            var catalogoTipoArchivoSesion = await _context.CatalogoTipoArchivoSesion.FindAsync(id);

            if (catalogoTipoArchivoSesion == null)
            {
                return NotFound();
            }

            _mapper.Map(request, catalogoTipoArchivoSesion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTipoArchivoSesion.Id }, catalogoTipoArchivoSesion);
        }

        // DELETE: api/<CatalogoTipoArchivoSesionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var catalogoTipoArchivoSesion = await _context.CatalogoTipoArchivoSesion.FindAsync(id);

            if (catalogoTipoArchivoSesion == null)
            {
                return NotFound();
            }

            _context.CatalogoTipoArchivoSesion.Remove(catalogoTipoArchivoSesion);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<CatalogoTipoArchivoSesionController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var catalogoTipoArchivoSesion = await _context.CatalogoTipoArchivoSesion.FindAsync(id);

            if (catalogoTipoArchivoSesion == null)
            {
                return NotFound();
            }

            catalogoTipoArchivoSesion.Activo = false;
            catalogoTipoArchivoSesion.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
