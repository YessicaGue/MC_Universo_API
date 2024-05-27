using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoPublicacionesPerfilGrupalController : ControllerBase
    {
        private readonly UniversoContext _context;

        public CatalogoPublicacionesPerfilGrupalController(UniversoContext context)
        {
            _context = context;
        }

        // GET: api/<CatalogoPublicacionesPerfilGrupalController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoPublicacionesPerfilGrupal>>> Get()
        {
            return await _context.CatalogoPublicacionesPerfilGrupal.ToListAsync();
        }

        // GET api/<CatalogoPublicacionesPerfilGrupalController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoPublicacionesPerfilGrupal>> Get(int id)
        {
            var catalogoPublicacionesPerfilGrupal = await _context.CatalogoPublicacionesPerfilGrupal.FindAsync(id);

            if (catalogoPublicacionesPerfilGrupal == null)
                return NotFound();

            return catalogoPublicacionesPerfilGrupal;
        }

        // POST api/<CatalogoPublicacionesPerfilGrupalController>
        [HttpPost]
        public async Task<ActionResult<CatalogoPublicacionesPerfilGrupal>> Post(CatalogoPublicacionesPerfilGrupal catalogoPublicacionesPerfilGrupal)
        {
            _context.CatalogoPublicacionesPerfilGrupal.Add(catalogoPublicacionesPerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoPublicacionesPerfilGrupal.Id }, catalogoPublicacionesPerfilGrupal);
        }

        // PUT api/<CatalogoPublicacionesPerfilGrupalController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoPublicacionesPerfilGrupal catalogoPublicacionesPerfilGrupal)
        {
            if (id != catalogoPublicacionesPerfilGrupal.Id)
                return BadRequest();

            _context.Entry(catalogoPublicacionesPerfilGrupal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var catalogoPublicacionesPerfilGrupalExists = await _context.CatalogoPublicacionesPerfilGrupal.FindAsync(id);
                if (catalogoPublicacionesPerfilGrupalExists == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE api/<CatalogoPublicacionesPerfilGrupalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
