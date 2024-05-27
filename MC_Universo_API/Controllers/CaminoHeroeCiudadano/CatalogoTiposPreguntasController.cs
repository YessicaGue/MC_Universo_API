using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CaminoHeroeCiudadano
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoTiposPreguntasController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoTiposPreguntasController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoTiposPreguntasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoTiposPreguntas>>> Get()
        {
            return await _context.CatalogoTiposPreguntas.ToListAsync();
        }

        // GET api/<CatalogoTiposPreguntasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoTiposPreguntas>> Get(int id)
        {
            var catalogoTiposPreguntas = await _context.CatalogoTiposPreguntas.FindAsync(id);

            return catalogoTiposPreguntas == null ? NotFound() : catalogoTiposPreguntas;
        }
        // POST api/<CatalogoTiposPreguntasController>
        [HttpPost]
        public async Task<ActionResult<CatalogoTiposPreguntas>> Post(CatalogoTiposPreguntasViewModel request)
        {
            CatalogoTiposPreguntas catalogoTiposPreguntas = _mapper.Map<CatalogoTiposPreguntas>(request);
            _context.CatalogoTiposPreguntas.Add(catalogoTiposPreguntas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTiposPreguntas.Id }, catalogoTiposPreguntas);
        }

        // PUT api/<CatalogoTiposPreguntasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoTiposPreguntasViewModel request)
        {
            var catalogoTiposPreguntas = await _context.CatalogoTiposPreguntas.FindAsync(id);
            _mapper.Map(request, catalogoTiposPreguntas);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoTiposPreguntas.Id }, catalogoTiposPreguntas);
        }

        // DELETE api/<CatalogoTiposPreguntasController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
