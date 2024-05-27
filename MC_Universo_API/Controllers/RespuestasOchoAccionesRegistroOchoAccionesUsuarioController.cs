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
    public class RespuestasOchoAccionesRegistroOchoAccionesUsuarioController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RespuestasOchoAccionesRegistroOchoAccionesUsuarioController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<RespuestasOchoAccionesRegistroOchoAccionesUsuarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RespuestasOchoAccionesRegistroOchoAccionesUsuario>>> Get()
        {
            return await _context.RespuestasOchoAccionesRegistroOchoAccionesUsuario.ToListAsync();
        }

        // GET api/<RespuestasOchoAccionesRegistroOchoAccionesUsuarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RespuestasOchoAccionesRegistroOchoAccionesUsuario>> Get(int id)
        {
            var respuestasOchoAccionesRegistroOchoAccionesUsuario = await _context.RespuestasOchoAccionesRegistroOchoAccionesUsuario.FindAsync(id);

            if (respuestasOchoAccionesRegistroOchoAccionesUsuario == null)
                return NotFound();

            return respuestasOchoAccionesRegistroOchoAccionesUsuario;
        }

        // GET api/<RespuestasOchoAccionesRegistroOchoAccionesUsuarioController>/registro-ocho-acciones-usuario=5
        [HttpGet("registro-ocho-acciones-usuario={id}")]
        public async Task<ActionResult<IEnumerable<RespuestasOchoAccionesRegistroOchoAccionesUsuario>>> GetByRegistro(int id)
        {
            var respuestasOchoAccionesRegistroOchoAccionesUsuario = await _context.RespuestasOchoAccionesRegistroOchoAccionesUsuario.Where(acc => acc.RegistroOchoAccionesUsuarioId == id).ToListAsync();

            return respuestasOchoAccionesRegistroOchoAccionesUsuario == null ? NotFound() : respuestasOchoAccionesRegistroOchoAccionesUsuario;
        }

        // POST api/<RespuestasOchoAccionesRegistroOchoAccionesUsuarioController>
        [HttpPost]
        public async Task<ActionResult<RespuestasOchoAccionesRegistroOchoAccionesUsuario>> Post(RespuestasOchoAccionesRegistroOchoAccionesUsuarioViewModel request)
        {
            RespuestasOchoAccionesRegistroOchoAccionesUsuario respuestasOchoAccionesRegistroOchoAccionesUsuario = _mapper.Map<RespuestasOchoAccionesRegistroOchoAccionesUsuario>(request);
            _context.RespuestasOchoAccionesRegistroOchoAccionesUsuario.Add(respuestasOchoAccionesRegistroOchoAccionesUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = respuestasOchoAccionesRegistroOchoAccionesUsuario.Id }, respuestasOchoAccionesRegistroOchoAccionesUsuario);
        }

    }
}
