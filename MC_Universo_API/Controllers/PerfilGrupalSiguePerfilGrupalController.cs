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
    public class PerfilGrupalSiguePerfilGrupalController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilGrupalSiguePerfilGrupalController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PerfilGrupalSiguePerfilGrupalController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilGrupalSiguePerfilGrupal>>> Get()
        {
            return await _context.PerfilGrupalSiguePerfilGrupal.ToListAsync();
        }

        // GET: api/<PerfilGrupalSiguePerfilGrupalController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilGrupalSiguePerfilGrupal>> Get(int id)
        {
            var perfilGrupalSiguePerfilGrupal = await _context.PerfilGrupalSiguePerfilGrupal.FindAsync(id);

            return perfilGrupalSiguePerfilGrupal == null ? NotFound() : perfilGrupalSiguePerfilGrupal;
        }

        // POST: api/<PerfilGrupalSiguePerfilGrupalController>
        [HttpPost]
        public async Task<ActionResult<PerfilGrupalSiguePerfilGrupal>> Post(PerfilGrupalSiguePerfilGrupalViewModel request)
        {
            PerfilGrupalSiguePerfilGrupal perfilGrupalSiguePerfilGrupal = _mapper.Map<PerfilGrupalSiguePerfilGrupal>(request);
            _context.PerfilGrupalSiguePerfilGrupal.Add(perfilGrupalSiguePerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilGrupalSiguePerfilGrupal.Id }, perfilGrupalSiguePerfilGrupal);
        }

        // PUT: api/<PerfilGrupalSiguePerfilGrupalController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilGrupalSiguePerfilGrupalViewModel request)
        {
            var perfilGrupalSiguePerfilGrupal = await _context.PerfilGrupalSiguePerfilGrupal.FindAsync(id);

            if (perfilGrupalSiguePerfilGrupal == null)
            {
                return NotFound();
            }

            _mapper.Map(request, perfilGrupalSiguePerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilGrupalSiguePerfilGrupal.Id }, perfilGrupalSiguePerfilGrupal);
        }

        // DELETE: api/<PerfilGrupalSiguePerfilGrupalController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var perfilGrupalSiguePerfilGrupal = await _context.PerfilGrupalSiguePerfilGrupal.FindAsync(id);

            if (perfilGrupalSiguePerfilGrupal == null)
            {
                return NotFound();
            }

            _context.PerfilGrupalSiguePerfilGrupal.Remove(perfilGrupalSiguePerfilGrupal);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<PerfilGrupalSiguePerfilGrupalController>/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var perfilGrupalSiguePerfilGrupal = await _context.PerfilGrupalSiguePerfilGrupal.FindAsync(id);

            if (perfilGrupalSiguePerfilGrupal == null)
            {
                return NotFound();
            }

            perfilGrupalSiguePerfilGrupal.Activo = false;
            perfilGrupalSiguePerfilGrupal.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET api/<PerfilGrupalSiguePerfilGrupalController>/5
        [HttpGet("seguido={idSeguido}/seguidor={idSeguidor}")]
        public bool Get(int idSeguido, int idSeguidor)
        {
            var perfilSiguePerfil = _context.PerfilGrupalSiguePerfilGrupal
                .Where(psp => psp.PerfilGrupalSeguidoId == idSeguido && psp.PerfilGrupalSeguidorId == idSeguidor)
                .FirstOrDefault();

            return perfilSiguePerfil == null ? false : true;
        }
    }
}
