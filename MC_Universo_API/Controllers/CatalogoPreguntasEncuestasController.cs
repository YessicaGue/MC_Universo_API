using AutoMapper;
using Azure.Core;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoPreguntasEncuestasController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoPreguntasEncuestasController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoPreguntasEncuestasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoPreguntasEncuestas>>> Get()
        {
            return await _context.CatalogoPreguntasEncuestas.ToListAsync();
        }

        // GET api/<CatalogoPreguntasEncuestasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoPreguntasEncuestas>> Get(int id)
        {
            var catalogoPreguntasEncuestas = await _context.CatalogoPreguntasEncuestas.FindAsync(id);

            if (catalogoPreguntasEncuestas == null)
                return NotFound();

            return catalogoPreguntasEncuestas;
        }

        // POST api/<CatalogoPreguntasEncuestasController>
        [HttpPost]
        public async Task<ActionResult<CatalogoPreguntasEncuestas>> Post(CatalogoPreguntasEncuestasViewModel request)
        {
            CatalogoPreguntasEncuestas catalogoPreguntasEncuestas = _mapper.Map<CatalogoPreguntasEncuestas>(request);
            _context.CatalogoPreguntasEncuestas.Add(catalogoPreguntasEncuestas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoPreguntasEncuestas.Id }, catalogoPreguntasEncuestas);
        }

        // PUT api/<CatalogoPreguntasEncuestasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoPreguntasEncuestasViewModel request)
        {
            CatalogoPreguntasEncuestas catalogoPreguntasEncuestas = _mapper.Map<CatalogoPreguntasEncuestas>(request);
            if (id != catalogoPreguntasEncuestas.Id)
                return BadRequest();

            _context.Entry(catalogoPreguntasEncuestas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var catalogoPreguntasEncuestasExists = await _context.CatalogoPreguntasEncuestas.FindAsync(id);
                if (catalogoPreguntasEncuestasExists == null)
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

        // DELETE api/<CatalogoPreguntasEncuestasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
