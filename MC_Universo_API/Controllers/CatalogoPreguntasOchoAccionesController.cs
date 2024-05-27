using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoPreguntasOchoAccionesController : ControllerBase
    {
        private readonly UniversoContext _context;

        public CatalogoPreguntasOchoAccionesController(UniversoContext context)
        {
            _context = context;
        }

        // GET: api/<CatalogoPreguntasOchoAccionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoPreguntasOchoAcciones>>> Get()
        {
            return await _context.CatalogoPreguntasOchoAcciones.ToListAsync();
        }

        // GET api/<CatalogoPreguntasOchoAccionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoPreguntasOchoAcciones>> Get(int id)
        {
            var catalogoPreguntasOchoAcciones = await _context.CatalogoPreguntasOchoAcciones.FindAsync(id);

            if (catalogoPreguntasOchoAcciones == null)
                return NotFound();

            return catalogoPreguntasOchoAcciones;
        }

        // POST api/<CatalogoPreguntasOchoAccionesController>
        [HttpPost]
        public async Task<ActionResult<CatalogoPreguntasOchoAcciones>> Post(CatalogoPreguntasOchoAcciones catalogoPreguntasOchoAcciones)
        {
            _context.CatalogoPreguntasOchoAcciones.Add(catalogoPreguntasOchoAcciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoPreguntasOchoAcciones.Id }, catalogoPreguntasOchoAcciones);
        }

        // PUT api/<CatalogoPreguntasOchoAccionesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoPreguntasOchoAcciones catalogoPreguntasOchoAcciones)
        {
            if (id != catalogoPreguntasOchoAcciones.Id)
                return BadRequest();

            _context.Entry(catalogoPreguntasOchoAcciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var catalogoPreguntasOchoAccionesExists = await _context.CatalogoPreguntasOchoAcciones.FindAsync(id);
                if (catalogoPreguntasOchoAccionesExists == null)
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

        // DELETE api/<CatalogoPreguntasOchoAccionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
