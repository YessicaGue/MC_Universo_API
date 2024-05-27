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
    public class PerfilUsuarioCodigoInvitacionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilUsuarioCodigoInvitacionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/PerfilUsuarioCodigoInvitacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilUsuarioCodigoInvitacion>>> Get()
        {
            return await _context.PerfilUsuarioCodigoInvitacion.ToListAsync();
        }

        // GET: api/PerfilUsuarioCodigoInvitacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilUsuarioCodigoInvitacion>> Get(int id)
        {
            var perfilUsuarioCodigoInvitacion = await _context.PerfilUsuarioCodigoInvitacion.FindAsync(id);

            return perfilUsuarioCodigoInvitacion == null ? NotFound() : perfilUsuarioCodigoInvitacion;
        }

        // POST: api/PerfilUsuarioCodigoInvitacion
        [HttpPost]
        public async Task<ActionResult<PerfilUsuarioCodigoInvitacion>> Post(PerfilUsuarioCodigoInvitacionViewModel request)
        {
            PerfilUsuarioCodigoInvitacion perfilUsuarioCodigoInvitacion = _mapper.Map<PerfilUsuarioCodigoInvitacion>(request);
            _context.PerfilUsuarioCodigoInvitacion.Add(perfilUsuarioCodigoInvitacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilUsuarioCodigoInvitacion.Id }, perfilUsuarioCodigoInvitacion);
        }

        // PUT: api/PerfilUsuarioCodigoInvitacion/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilUsuarioCodigoInvitacionViewModel request)
        {
            var perfilUsuarioCodigoInvitacion = await _context.PerfilUsuarioCodigoInvitacion.FindAsync(id);

            if (perfilUsuarioCodigoInvitacion == null)
                return NotFound();

            _mapper.Map(request, perfilUsuarioCodigoInvitacion);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilUsuarioCodigoInvitacion.Id }, perfilUsuarioCodigoInvitacion);
        }

        // DELETE: api/PerfilUsuarioCodigoInvitacion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var perfilUsuarioCodigoInvitacion = await _context.PerfilUsuarioCodigoInvitacion.FindAsync(id);

            if (perfilUsuarioCodigoInvitacion == null)
                return NotFound();

            _context.PerfilUsuarioCodigoInvitacion.Remove(perfilUsuarioCodigoInvitacion);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET: api/PerfilUsuarioCodigoInvitacion/related?queryParams
        [HttpGet("related")]
        public object GetRelated([FromQuery] int PerfilUsuarioId, [FromQuery] int CodigoInvitacionId)
        {
            var query = from perfilUsuarioCodigoInvitacion in _context.Set<PerfilUsuarioCodigoInvitacion>()

                let perfilUsuario = _context.PerfilUsuario
                    .Where(perfilUsuario =>
                        perfilUsuarioCodigoInvitacion.PerfilUsuarioId == perfilUsuario.Id
                    )
                    .FirstOrDefault()

                let perfil = _context.Perfil
                    .Where(perfil =>
                        perfilUsuario.PerfilId == perfil.Id
                    )
                    .FirstOrDefault()

                where PerfilUsuarioId > 0
                    ? perfilUsuarioCodigoInvitacion.PerfilUsuarioId == PerfilUsuarioId
                    : true

                where CodigoInvitacionId > 0
                    ? perfilUsuarioCodigoInvitacion.CodigoInvitacionId == CodigoInvitacionId
                    : true

                where perfilUsuarioCodigoInvitacion.Activo == true

                orderby perfilUsuarioCodigoInvitacion.Id

                select new
                {
                    id = perfilUsuarioCodigoInvitacion.Id,
                    codigoInvitacionId = perfilUsuarioCodigoInvitacion.CodigoInvitacionId,
                    activo = perfilUsuarioCodigoInvitacion.Activo,
                    fechaCreacion = perfilUsuarioCodigoInvitacion.FechaCreacion,
                    fechaActualizacion = perfilUsuarioCodigoInvitacion.FechaActualizacion,
                    perfilUsuario,
                    perfil
                };

            if ((PerfilUsuarioId > 0 || CodigoInvitacionId > 0) && !query.Any())
                return NotFound();

            if (PerfilUsuarioId > 0 || CodigoInvitacionId > 0)
                return query.First();

            return query;
        }
    }
}
