using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.AccionesAfirmativas;
using MC_Universo_API.ViewModels.AccionesAfirmativas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.AccionesAfirmativas
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoCircuinscripcionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoCircuinscripcionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoCircunscripcionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoCircunscripcion>>> Get()
        {
            return await _context.CatalogoCircunscripcion.ToListAsync();
        }

        // GET api/<CatalogoCircunscripcionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoCircunscripcion>> Get(int id)
        {
            var CatalogoCircunscripcion = await _context.CatalogoCircunscripcion.FindAsync(id);

            return CatalogoCircunscripcion == null ? NotFound() : CatalogoCircunscripcion;
        }
        // POST api/<CatalogoCircunscripcionController>
        [HttpPost]
        public async Task<ActionResult<CatalogoCircunscripcion>> Post(CatalogoCircunscripcion request)
        {
            CatalogoCircunscripcion CatalogoCircunscripcion = _mapper.Map<CatalogoCircunscripcion>(request);
            _context.CatalogoCircunscripcion.Add(CatalogoCircunscripcion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = CatalogoCircunscripcion.Id }, CatalogoCircunscripcion);
        }

        // PUT api/<CatalogoCircunscripcionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoCircuinscripcionViewModel request)
        {
            var CatalogoCircunscripcion = await _context.CatalogoCircunscripcion.FindAsync(id);
            _mapper.Map(request, CatalogoCircunscripcion);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = CatalogoCircunscripcion.Id }, CatalogoCircunscripcion);
        }

        // DELETE api/<CatalogoCircunscripcionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
        

        //Get api/<CatalogoCicunscripcionControlle>
        [HttpGet("GetCircunscripcion")]
        public async Task<IActionResult> GetCircunscripcion()
        {
            var detalle = await _context.DetalleRequisitoDiputaciones.ToListAsync();
            return Ok(detalle);
        }
        
        //GET api/<CatalogoCircunscripcionController>/5
        [HttpGet("detalleEstado")]
        public async Task<IActionResult> GetDetalleDashboard()
        {
            var circuinscripcionEstado = await _context.EstadoCircunscripcion
                .Include(ec  => ec.EntidadFederativa)
                .Include(ec => ec.CatalogoCircunscripcion)
                .GroupBy(ec => ec.CatalogoCircunscripcion.Circunscripcion)
                .Select( group => new
                    {
                         Circuinscripcion = group.Key,
                         Estados = group.Select(ec => ec.EntidadFederativa),
                         CatalogoCircunscripcion = group.Select(ec=>ec.CatalogoCircunscripcion) 
                    }
                )
                .ToListAsync();
            return Ok(circuinscripcionEstado);
        }
        
    }
}
