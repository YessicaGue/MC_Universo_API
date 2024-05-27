using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoOchoAccionesController : ControllerBase
    {
        private readonly UniversoContext _context;

        public CatalogoOchoAccionesController(UniversoContext context)
        {
            _context = context;
        }

        // GET: api/<CatalogoOchoAccionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoOchoAcciones>>> Get()
        {
            return await _context.CatalogoOchoAcciones.ToListAsync();
        }

        // GET api/<CatalogoOchoAccionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoOchoAcciones>> Get(int id)
        {
            var catalogoOchoAcciones = await _context.CatalogoOchoAcciones.FindAsync(id);

            if (catalogoOchoAcciones == null)
                return NotFound();

            return catalogoOchoAcciones;
        }

        // POST api/<CatalogoOchoAccionesController>
        [HttpPost]
        public async Task<ActionResult<CatalogoOchoAcciones>> Post(CatalogoOchoAcciones catalogoOchoAcciones)
        {
            _context.CatalogoOchoAcciones.Add(catalogoOchoAcciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoOchoAcciones.Id }, catalogoOchoAcciones);
        }

        // PUT api/<CatalogoOchoAccionesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoOchoAcciones catalogoOchoAcciones)
        {
            if (id != catalogoOchoAcciones.Id)
                return BadRequest();

            _context.Entry(catalogoOchoAcciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var catalogoOchoAccionesExists = await _context.CatalogoOchoAcciones.FindAsync(id);
                if (catalogoOchoAccionesExists == null)
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

        // DELETE api/<CatalogoOchoAccionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
