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
    public class PreguntasExamenCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PreguntasExamenCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PreguntasExamenCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PreguntasExamenCHC>>> Get()
        {
            return await _context.PreguntasExamenCHC.ToListAsync();
        }

        // GET api/<PreguntasExamenCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PreguntasExamenCHC>> Get(int id)
        {
            var preguntasExamenCHC = await _context.PreguntasExamenCHC.FindAsync(id);

            return preguntasExamenCHC == null ? NotFound() : preguntasExamenCHC;
        }
        // POST api/<PreguntasExamenCHCController>
        [HttpPost]
        public async Task<ActionResult<PreguntasExamenCHC>> Post(PreguntasExamenCHCViewModel request)
        {
            PreguntasExamenCHC preguntasExamenCHC = _mapper.Map<PreguntasExamenCHC>(request);
            _context.PreguntasExamenCHC.Add(preguntasExamenCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = preguntasExamenCHC.Id }, preguntasExamenCHC);
        }

        // PUT api/<PreguntasExamenCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PreguntasExamenCHCViewModel request)
        {
            var preguntasExamenCHC = await _context.PreguntasExamenCHC.FindAsync(id);
            _mapper.Map(request, preguntasExamenCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = preguntasExamenCHC.Id }, preguntasExamenCHC);
        }

        // DELETE api/<PreguntasExamenCHCController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
