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
    public class PerfilSiguePerfilGrupalController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilSiguePerfilGrupalController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PerfilSiguePerfilGrupalController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilSiguePerfilGrupal>>> Get()
        {
            return await _context.PerfilSiguePerfilGrupal.ToListAsync();
        }

        // GET: api/<PerfilSiguePerfilGrupalController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilSiguePerfilGrupal>> Get(int id)
        {
            var perfilSiguePerfilGrupal = await _context.PerfilSiguePerfilGrupal.FindAsync(id);

            return perfilSiguePerfilGrupal == null ? NotFound() : perfilSiguePerfilGrupal;
        }

        // POST: api/<PerfilSiguePerfilGrupalController>
        [HttpPost]
        public async Task<ActionResult<PerfilSiguePerfilGrupal>> Post(PerfilSiguePerfilGrupalViewModel request)
        {
            PerfilSiguePerfilGrupal perfilSiguePerfilGrupal = _mapper.Map<PerfilSiguePerfilGrupal>(request);
            _context.PerfilSiguePerfilGrupal.Add(perfilSiguePerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilSiguePerfilGrupal.Id }, perfilSiguePerfilGrupal);
        }

        // PUT: api/<PerfilSiguePerfilGrupalController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilSiguePerfilGrupalViewModel request)
        {
            var perfilSiguePerfilGrupal = await _context.PerfilSiguePerfilGrupal.FindAsync(id);

            if (perfilSiguePerfilGrupal == null)
            {
                return NotFound();
            }

            _mapper.Map(request, perfilSiguePerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilSiguePerfilGrupal.Id }, perfilSiguePerfilGrupal);
        }

        // DELETE: api/<PerfilSiguePerfilGrupalController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var perfilSiguePerfilGrupal = await _context.PerfilSiguePerfilGrupal.FindAsync(id);

            if (perfilSiguePerfilGrupal == null)
            {
                return NotFound();
            }

            _context.PerfilSiguePerfilGrupal.Remove(perfilSiguePerfilGrupal);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<PerfilSiguePerfilGrupalController>/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var perfilSiguePerfilGrupal = await _context.PerfilSiguePerfilGrupal.FindAsync(id);

            if (perfilSiguePerfilGrupal == null)
            {
                return NotFound();
            }

            perfilSiguePerfilGrupal.Activo = false;
            perfilSiguePerfilGrupal.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET api/<PerfilSiguePerfilGrupalController>/5
        [HttpGet("seguido={idSeguido}/seguidor={idSeguidor}")]
        public bool Get(int idSeguido, int idSeguidor)
        {
            var perfilSiguePerfil = _context.PerfilSiguePerfilGrupal
                .Where(psp => psp.PerfilGrupalSeguidoId == idSeguido && psp.PerfilSeguidorId == idSeguidor)
                .FirstOrDefault();

            return perfilSiguePerfil == null ? false : true;
        }
    }
}
