using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.Precandidaturas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.Precandidaturas
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoTipoPrecandidaturaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoTipoPrecandidaturaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoTipoPrecandidaturaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoTipoPrecandidatura>>> Get()
        {
            return await _context.CatalogoTipoPrecandidatura.ToListAsync();
        }

        // GET: api/<CatalogoTipoPrecandidaturaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoTipoPrecandidatura>> Get(int id)
        {
            var catalogoTipoPrecandidatura = await _context.CatalogoTipoPrecandidatura.FindAsync(id);

            return catalogoTipoPrecandidatura == null ? NotFound() : catalogoTipoPrecandidatura;
        }

        // POST: api/<CatalogoTipoPrecandidaturaController>
        [HttpPost]
        public async Task<ActionResult<CatalogoTipoPrecandidatura>> Post(CatalogoTipoPrecandidaturaViewModel request)
        {
            CatalogoTipoPrecandidatura catalogoTipoPrecandidatura = _mapper.Map<CatalogoTipoPrecandidatura>(request);
            _context.CatalogoTipoPrecandidatura.Add(catalogoTipoPrecandidatura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTipoPrecandidatura.Id }, catalogoTipoPrecandidatura);
        }

        // PUT: api/<CatalogoTipoPrecandidaturaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoTipoPrecandidaturaViewModel request)
        {
            var catalogoTipoPrecandidatura = await _context.CatalogoTipoPrecandidatura.FindAsync(id);

            if (catalogoTipoPrecandidatura == null)
            {
                return NotFound();
            }

            _mapper.Map(request, catalogoTipoPrecandidatura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTipoPrecandidatura.Id }, catalogoTipoPrecandidatura);
        }

        // DELETE: api/<CatalogoTipoPrecandidaturaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var catalogoTipoPrecandidatura = await _context.CatalogoTipoPrecandidatura.FindAsync(id);

            if (catalogoTipoPrecandidatura == null)
            {
                return NotFound();
            }

            _context.CatalogoTipoPrecandidatura.Remove(catalogoTipoPrecandidatura);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<CatalogoTipoPrecandidaturaController>/disable/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var catalogoTipoPrecandidatura = await _context.CatalogoTipoPrecandidatura.FindAsync(id);

            if (catalogoTipoPrecandidatura == null)
            {
                return NotFound();
            }

            catalogoTipoPrecandidatura.Activo = false;
            catalogoTipoPrecandidatura.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
