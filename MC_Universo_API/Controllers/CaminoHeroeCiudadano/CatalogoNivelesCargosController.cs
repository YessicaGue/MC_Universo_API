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
    public class CatalogoNivelesCargosController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoNivelesCargosController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoNivelesCargosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoNivelesCargos>>> Get()
        {
            return await _context.CatalogoNivelesCargos.ToListAsync();
        }


        // GET api/<CatalogoNivelesCargosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoNivelesCargos>> Get(int id)
        {
            var catalogoNivelesCargos = await _context.CatalogoNivelesCargos.FindAsync(id);

            return catalogoNivelesCargos == null ? NotFound() : catalogoNivelesCargos;
        }
        // POST api/<CatalogoNivelesCargosController>
        [HttpPost]
        public async Task<ActionResult<CatalogoNivelesCargos>> Post(CatalogoNivelesCargosViewModel request)
        {
            CatalogoNivelesCargos catalogoNivelesCargos = _mapper.Map<CatalogoNivelesCargos>(request);
            _context.CatalogoNivelesCargos.Add(catalogoNivelesCargos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoNivelesCargos.Id }, catalogoNivelesCargos);
        }

        // PUT api/<CatalogoNivelesCargosController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoNivelesCargosViewModel request)
        {
            var catalogoNivelesCargos = await _context.CatalogoNivelesCargos.FindAsync(id);
            _mapper.Map(request, catalogoNivelesCargos);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = catalogoNivelesCargos.Id }, catalogoNivelesCargos);
        }

        // DELETE api/<CatalogoNivelesCargosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}

    }
}
