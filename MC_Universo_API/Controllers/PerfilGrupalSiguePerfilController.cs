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
    public class PerfilGrupalSiguePerfilController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilGrupalSiguePerfilController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PerfilGrupalSiguePerfilController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilGrupalSiguePerfil>>> Get()
        {
            return await _context.PerfilGrupalSiguePerfil.ToListAsync();
        }

        // GET: api/<PerfilGrupalSiguePerfilController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilGrupalSiguePerfil>> Get(int id)
        {
            var perfilGrupalSiguePerfil = await _context.PerfilGrupalSiguePerfil.FindAsync(id);

            return perfilGrupalSiguePerfil == null ? NotFound() : perfilGrupalSiguePerfil;
        }

        // POST: api/<PerfilGrupalSiguePerfilController>
        [HttpPost]
        public async Task<ActionResult<PerfilGrupalSiguePerfil>> Post(PerfilGrupalSiguePerfilViewModel request)
        {
            PerfilGrupalSiguePerfil perfilGrupalSiguePerfil = _mapper.Map<PerfilGrupalSiguePerfil>(request);
            _context.PerfilGrupalSiguePerfil.Add(perfilGrupalSiguePerfil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilGrupalSiguePerfil.Id }, perfilGrupalSiguePerfil);
        }

        // PUT: api/<PerfilGrupalSiguePerfilController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilGrupalSiguePerfilViewModel request)
        {
            var perfilGrupalSiguePerfil = await _context.PerfilGrupalSiguePerfil.FindAsync(id);

            if (perfilGrupalSiguePerfil == null)
            {
                return NotFound();
            }

            _mapper.Map(request, perfilGrupalSiguePerfil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilGrupalSiguePerfil.Id }, perfilGrupalSiguePerfil);
        }

        // DELETE: api/<PerfilGrupalSiguePerfilController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var perfilGrupalSiguePerfil = await _context.PerfilGrupalSiguePerfil.FindAsync(id);

            if (perfilGrupalSiguePerfil == null)
            {
                return NotFound();
            }

            _context.PerfilGrupalSiguePerfil.Remove(perfilGrupalSiguePerfil);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<PerfilGrupalSiguePerfilController>/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var perfilGrupalSiguePerfil = await _context.PerfilGrupalSiguePerfil.FindAsync(id);

            if (perfilGrupalSiguePerfil == null)
            {
                return NotFound();
            }

            perfilGrupalSiguePerfil.Activo = false;
            perfilGrupalSiguePerfil.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET api/<PerfilGrupalSiguePerfilController>/5
        [HttpGet("seguido={idSeguido}/seguidor={idSeguidor}")]
        public bool Get(int idSeguido, int idSeguidor)
        {
            var perfilSiguePerfil = _context.PerfilGrupalSiguePerfil
                .Where(psp => psp.PerfilSeguidoId == idSeguido && psp.PerfilGrupalSeguidorId == idSeguidor)
                .FirstOrDefault();

            return perfilSiguePerfil == null ? false : true;
        }
    }
}
