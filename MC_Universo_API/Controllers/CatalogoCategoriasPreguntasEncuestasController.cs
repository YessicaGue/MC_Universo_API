using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoCategoriasPreguntasEncuestasController : ControllerBase
    {
        private readonly UniversoContext _context;

        public CatalogoCategoriasPreguntasEncuestasController(UniversoContext context)
        {
            _context = context;
        }

        // GET: api/<CatalogoCategoriasPreguntasEncuestasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoCategoriasPreguntasEncuestas>>> Get()
        {
            return await _context.CatalogoCategoriasPreguntasEncuestas.ToListAsync();
        }

        // GET api/<CatalogoCategoriasPreguntasEncuestasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoCategoriasPreguntasEncuestas>> Get(int id)
        {
            var catalogoCategoriasPreguntasEncuestas = await _context.CatalogoCategoriasPreguntasEncuestas.FindAsync(id);

            if (catalogoCategoriasPreguntasEncuestas == null)
                return NotFound();

            return catalogoCategoriasPreguntasEncuestas;
        }

        // POST api/<CatalogoCategoriasPreguntasEncuestasController>
        [HttpPost]
        public async Task<ActionResult<CatalogoCategoriasPreguntasEncuestas>> Post(CatalogoCategoriasPreguntasEncuestas catalogoCategoriasPreguntasEncuestas)
        {
            _context.CatalogoCategoriasPreguntasEncuestas.Add(catalogoCategoriasPreguntasEncuestas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoCategoriasPreguntasEncuestas.Id }, catalogoCategoriasPreguntasEncuestas);
        }

        // PUT api/<CatalogoCategoriasPreguntasEncuestasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoCategoriasPreguntasEncuestas catalogoCategoriasPreguntasEncuestas)
        {
            if (id != catalogoCategoriasPreguntasEncuestas.Id)
                return BadRequest();

            _context.Entry(catalogoCategoriasPreguntasEncuestas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var catalogoCategoriasPreguntasEncuestasExists = await _context.CatalogoCategoriasPreguntasEncuestas.FindAsync(id);
                if (catalogoCategoriasPreguntasEncuestasExists == null)
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

        // DELETE api/<CatalogoCategoriasPreguntasEncuestasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
