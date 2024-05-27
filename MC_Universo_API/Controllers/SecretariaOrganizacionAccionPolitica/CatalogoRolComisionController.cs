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
    public class CatalogoRolComisionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoRolComisionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoRolComisionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoRolComision>>> Get()
        {
            return await _context.CatalogoRolComision.ToListAsync();
        }

        // GET: api/<CatalogoRolComisionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoRolComision>> Get(int id)
        {
            var catalogoRolComision = await _context.CatalogoRolComision.FindAsync(id);

            return catalogoRolComision == null ? NotFound() : catalogoRolComision;
        }

        // POST: api/<CatalogoRolComisionController>
        [HttpPost]
        public async Task<ActionResult<CatalogoRolComision>> Post(CatalogoRolComisionViewModel request)
        {
            CatalogoRolComision catalogoRolComision = _mapper.Map<CatalogoRolComision>(request);
            _context.CatalogoRolComision.Add(catalogoRolComision);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoRolComision.Id }, catalogoRolComision);
        }

        // PUT: api/<CatalogoRolComisionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoRolComisionViewModel request)
        {
            var catalogoRolComision = await _context.CatalogoRolComision.FindAsync(id);

            if (catalogoRolComision == null)
            {
                return NotFound();
            }

            _mapper.Map(request, catalogoRolComision);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoRolComision.Id }, catalogoRolComision);
        }

        // DELETE: api/<CatalogoRolComisionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var catalogoRolComision = await _context.CatalogoRolComision.FindAsync(id);

            if (catalogoRolComision == null)
            {
                return NotFound();
            }

            _context.CatalogoRolComision.Remove(catalogoRolComision);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<CatalogoRolComisionController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var catalogoRolComision = await _context.CatalogoRolComision.FindAsync(id);

            if (catalogoRolComision == null)
            {
                return NotFound();
            }

            catalogoRolComision.Activo = false;
            catalogoRolComision.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
