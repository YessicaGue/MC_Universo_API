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
    public class CatalogoEstadoValidacionArchivoController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoEstadoValidacionArchivoController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoEstadoValidacionArchivoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoEstadoValidacionArchivo>>> Get()
        {
            return await _context.CatalogoEstadoValidacionArchivo.ToListAsync();
        }

        // GET: api/<CatalogoEstadoValidacionArchivoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoEstadoValidacionArchivo>> Get(int id)
        {
            var catalogoEstadoValidacionArchivo = await _context.CatalogoEstadoValidacionArchivo.FindAsync(id);

            return catalogoEstadoValidacionArchivo == null ? NotFound() : catalogoEstadoValidacionArchivo;
        }

        // POST: api/<CatalogoEstadoValidacionArchivoController>
        [HttpPost]
        public async Task<ActionResult<CatalogoEstadoValidacionArchivo>> Post(CatalogoEstadoValidacionArchivoViewModel request)
        {
            CatalogoEstadoValidacionArchivo catalogoEstadoValidacionArchivo = _mapper.Map<CatalogoEstadoValidacionArchivo>(request);
            _context.CatalogoEstadoValidacionArchivo.Add(catalogoEstadoValidacionArchivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoEstadoValidacionArchivo.Id }, catalogoEstadoValidacionArchivo);
        }

        // PUT: api/<CatalogoEstadoValidacionArchivoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoEstadoValidacionArchivoViewModel request)
        {
            var catalogoEstadoValidacionArchivo = await _context.CatalogoEstadoValidacionArchivo.FindAsync(id);

            if (catalogoEstadoValidacionArchivo == null)
            {
                return NotFound();
            }

            _mapper.Map(request, catalogoEstadoValidacionArchivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoEstadoValidacionArchivo.Id }, catalogoEstadoValidacionArchivo);
        }

        // DELETE: api/<CatalogoEstadoValidacionArchivoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var catalogoEstadoValidacionArchivo = await _context.CatalogoEstadoValidacionArchivo.FindAsync(id);

            if (catalogoEstadoValidacionArchivo == null)
            {
                return NotFound();
            }

            _context.CatalogoEstadoValidacionArchivo.Remove(catalogoEstadoValidacionArchivo);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<CatalogoEstadoValidacionArchivoController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var catalogoEstadoValidacionArchivo = await _context.CatalogoEstadoValidacionArchivo.FindAsync(id);

            if (catalogoEstadoValidacionArchivo == null)
            {
                return NotFound();
            }

            catalogoEstadoValidacionArchivo.Activo = false;
            catalogoEstadoValidacionArchivo.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
