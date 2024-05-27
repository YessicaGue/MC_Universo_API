using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoPublicacionesController : ControllerBase
    {
        private readonly UniversoContext _context;

        public CatalogoPublicacionesController(UniversoContext context)
        {
            _context = context;
        }

        // GET: api/<CatalogoPublicacionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoPublicaciones>>> Get()
        {
            return await _context.CatalogoPublicaciones.ToListAsync();
        }

        // GET api/<CatalogoPublicacionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoPublicaciones>> Get(int id)
        {
            var catalogoPublicaciones = await _context.CatalogoPublicaciones.FindAsync(id);

            if (catalogoPublicaciones == null)
                return NotFound();

            return catalogoPublicaciones;
        }

        // POST api/<CatalogoPublicacionesController>
        [HttpPost]
        public async Task<ActionResult<CatalogoPublicaciones>> Post(CatalogoPublicaciones catalogoPublicaciones)
        {
            _context.CatalogoPublicaciones.Add(catalogoPublicaciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoPublicaciones.Id }, catalogoPublicaciones);
        }

        // PUT api/<CatalogoPublicacionesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoPublicaciones catalogoPublicaciones)
        {
            if (id != catalogoPublicaciones.Id)
                return BadRequest();

            _context.Entry(catalogoPublicaciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var catalogoPublicacionesExists = await _context.CatalogoPublicaciones.FindAsync(id);
                if (catalogoPublicacionesExists == null)
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

        // DELETE api/<CatalogoPublicacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
