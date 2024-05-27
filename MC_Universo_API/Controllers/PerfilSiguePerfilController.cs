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
    public class PerfilSiguePerfilController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilSiguePerfilController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PerfilSiguePerfilController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilSiguePerfil>>> Get()
        {
            return await _context.PerfilSiguePerfil.ToListAsync();
        }

        // GET: api/<PerfilSiguePerfilController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilSiguePerfil>> Get(int id)
        {
            var perfilSiguePerfil = await _context.PerfilSiguePerfil.FindAsync(id);

            return perfilSiguePerfil == null ? NotFound() : perfilSiguePerfil;
        }

        // POST: api/<PerfilSiguePerfilController>
        [HttpPost]
        public async Task<ActionResult<PerfilSiguePerfil>> Post(PerfilSiguePerfilViewModel request)
        {
            PerfilSiguePerfil perfilSiguePerfil = _mapper.Map<PerfilSiguePerfil>(request);
            _context.PerfilSiguePerfil.Add(perfilSiguePerfil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilSiguePerfil.Id }, perfilSiguePerfil);
        }

        // PUT: api/<PerfilSiguePerfilController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilSiguePerfilViewModel request)
        {
            var perfilSiguePerfil = await _context.PerfilSiguePerfil.FindAsync(id);

            if (perfilSiguePerfil == null)
            {
                return NotFound();
            }

            _mapper.Map(request, perfilSiguePerfil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilSiguePerfil.Id }, perfilSiguePerfil);
        }

        // DELETE: api/<PerfilSiguePerfilController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var perfilSiguePerfil = await _context.PerfilSiguePerfil.FindAsync(id);

            if (perfilSiguePerfil == null)
            {
                return NotFound();
            }

            _context.PerfilSiguePerfil.Remove(perfilSiguePerfil);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<PerfilSiguePerfilController>/5
        [HttpPut("disable/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            var perfilSiguePerfil = await _context.PerfilSiguePerfil.FindAsync(id);

            if (perfilSiguePerfil == null)
            {
                return NotFound();
            }

            perfilSiguePerfil.Activo = false;
            perfilSiguePerfil.FechaActualizacion = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET api/<PerfilSiguePerfilController>/5
        [HttpGet("seguido={idSeguido}/seguidor={idSeguidor}")]
        public bool Get(int idSeguido, int idSeguidor)
        {
            var perfilSiguePerfil = _context.PerfilSiguePerfil
                .Where(psp => psp.PerfilSeguidoId == idSeguido && psp.PerfilSeguidorId == idSeguidor)
                .FirstOrDefault();

            return perfilSiguePerfil == null ? false : true;
        }
    }
}
