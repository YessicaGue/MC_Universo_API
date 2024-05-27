using AutoMapper;
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
    public class RespuestasOchoAccionesController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RespuestasOchoAccionesController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<RespuestasOchoAccionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RespuestasOchoAcciones>>> Get()
        {
            return await _context.RespuestasOchoAcciones.ToListAsync();
        }

        // GET api/<RespuestasOchoAccionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RespuestasOchoAcciones>> Get(int id)
        {
            var respuestasOchoAcciones = await _context.RespuestasOchoAcciones.FindAsync(id);

            if (respuestasOchoAcciones == null)
                return NotFound();

            return respuestasOchoAcciones;
        }

        // GET api/<RespuestasOchoAccionesController>/registro-ocho-acciones=5
        [HttpGet("registro-ocho-acciones={id}")]
        public async Task<ActionResult<IEnumerable<RespuestasOchoAcciones>>> GetByRegistro(int id)
        {
            var respuestasOchoAcciones = await _context.RespuestasOchoAcciones.Where(acc => acc.RegistroOchoAccionesId == id).ToListAsync();

            return respuestasOchoAcciones == null ? NotFound() : respuestasOchoAcciones;
        }

        // POST api/<RespuestasOchoAccionesController>
        [HttpPost]
        public async Task<ActionResult<RespuestasOchoAcciones>> Post(RespuestasOchoAccionesViewModel request)
        {
            RespuestasOchoAcciones respuestasOchoAcciones = _mapper.Map<RespuestasOchoAcciones>(request);
            _context.RespuestasOchoAcciones.Add(respuestasOchoAcciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = respuestasOchoAcciones.Id }, respuestasOchoAcciones);
        }

    }
}
