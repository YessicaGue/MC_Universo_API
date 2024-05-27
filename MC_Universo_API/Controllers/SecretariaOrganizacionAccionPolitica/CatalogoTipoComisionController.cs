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
    public class CatalogoTipoComisionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoTipoComisionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoTipoComisionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoTipoComision>>> Get()
        {
            return await _context.CatalogoTipoComision.ToListAsync();
        }

        // GET: api/<CatalogoTipoComisionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoTipoComision>> Get(int id)
        {
            var catalogoTipoComision = await _context.CatalogoTipoComision.FindAsync(id);

            return catalogoTipoComision == null ? NotFound() : catalogoTipoComision;
        }

        // POST: api/<CatalogoTipoComisionController>
        [HttpPost]
        public async Task<ActionResult<CatalogoTipoComision>> Post(CatalogoTipoComisionViewModel request)
        {
            CatalogoTipoComision catalogoTipoComision = _mapper.Map<CatalogoTipoComision>(request);
            _context.CatalogoTipoComision.Add(catalogoTipoComision);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTipoComision.Id }, catalogoTipoComision);
        }

        // PUT: api/<CatalogoTipoComisionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoTipoComisionViewModel request)
        {
            var catalogoTipoComision = await _context.CatalogoTipoComision.FindAsync(id);

            if (catalogoTipoComision == null)
            {
                return NotFound();
            }

            _mapper.Map(request, catalogoTipoComision);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTipoComision.Id }, catalogoTipoComision);
        }

        // DELETE: api/<CatalogoTipoComisionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var catalogoTipoComision = await _context.CatalogoTipoComision.FindAsync(id);

            if (catalogoTipoComision == null)
            {
                return NotFound();
            }

            _context.CatalogoTipoComision.Remove(catalogoTipoComision);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<CatalogoTipoComisionController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var catalogoTipoComision = await _context.CatalogoTipoComision.FindAsync(id);

            if (catalogoTipoComision == null)
            {
                return NotFound();
            }

            catalogoTipoComision.Activo = false;
            catalogoTipoComision.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
