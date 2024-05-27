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
    public class CatalogoTipoSesionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoTipoSesionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoTipoSesionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoTipoSesion>>> Get()
        {
            return await _context.CatalogoTipoSesion.ToListAsync();
        }

        // GET: api/<CatalogoTipoSesionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoTipoSesion>> Get(int id)
        {
            var catalogoTipoSesion = await _context.CatalogoTipoSesion.FindAsync(id);

            return catalogoTipoSesion == null ? NotFound() : catalogoTipoSesion;
        }

        // POST: api/<CatalogoTipoSesionController>
        [HttpPost]
        public async Task<ActionResult<CatalogoTipoSesion>> Post(CatalogoTipoSesionViewModel request)
        {
            CatalogoTipoSesion catalogoTipoSesion = _mapper.Map<CatalogoTipoSesion>(request);
            _context.CatalogoTipoSesion.Add(catalogoTipoSesion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTipoSesion.Id }, catalogoTipoSesion);
        }

        // PUT: api/<CatalogoTipoSesionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoTipoSesionViewModel request)
        {
            var catalogoTipoSesion = await _context.CatalogoTipoSesion.FindAsync(id);

            if (catalogoTipoSesion == null)
            {
                return NotFound();
            }

            _mapper.Map(request, catalogoTipoSesion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTipoSesion.Id }, catalogoTipoSesion);
        }

        // DELETE: api/<CatalogoTipoSesionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var catalogoTipoSesion = await _context.CatalogoTipoSesion.FindAsync(id);

            if (catalogoTipoSesion == null)
            {
                return NotFound();
            }

            _context.CatalogoTipoSesion.Remove(catalogoTipoSesion);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<CatalogoTipoSesionController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var catalogoTipoSesion = await _context.CatalogoTipoSesion.FindAsync(id);

            if (catalogoTipoSesion == null)
            {
                return NotFound();
            }

            catalogoTipoSesion.Activo = false;
            catalogoTipoSesion.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
