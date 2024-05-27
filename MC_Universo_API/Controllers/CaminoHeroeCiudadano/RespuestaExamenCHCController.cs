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
    public class RespuestaExamenCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RespuestaExamenCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PreguntasExamenCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RespuestaExamenCHC>>> Get()
        {
            return await _context.RespuestaExamenCHC.ToListAsync();
        }

        // GET api/<RespuestaExamenCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RespuestaExamenCHC>> Get(int id)
        {
            var respuestaExamenCHC = await _context.RespuestaExamenCHC.FindAsync(id);

            return respuestaExamenCHC == null ? NotFound() : respuestaExamenCHC;
        }
        // POST api/<RespuestaExamenCHCController>
        [HttpPost]
        public async Task<ActionResult<RespuestaExamenCHC>> Post(RespuestaExamenCHCViewModel request)
        {
            RespuestaExamenCHC respuestaExamenCHC = _mapper.Map<RespuestaExamenCHC>(request);
            _context.RespuestaExamenCHC.Add(respuestaExamenCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = respuestaExamenCHC.Id }, respuestaExamenCHC);
        }

        // PUT api/<RespuestaExamenCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RespuestaExamenCHCViewModel request)
        {
            var respuestaExamenCHC = await _context.RespuestaExamenCHC.FindAsync(id);
            _mapper.Map(request, respuestaExamenCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = respuestaExamenCHC.Id }, respuestaExamenCHC);
        }

        // DELETE api/<RespuestaExamenCHCController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
