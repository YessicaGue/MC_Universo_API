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
    public class UsuarioPerfilController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public UsuarioPerfilController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<UsuarioPerfilController>/related
        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from usuarioPerfil in _context.Set<UsuarioPerfil>()

                        let perfil = _context.Perfil
                            .Where(p => usuarioPerfil.PerfilId == p.Id)
                            .FirstOrDefault()

                        select new
                        {
                            usuarioPerfil.Id,
                            usuarioPerfil.UsuarioId,
                            usuarioPerfil.FechaCreacion,
                            perfil
                        };

            return query.ToList();
        }

        [HttpGet("u={id}")]
        public async Task<ActionResult<IEnumerable<UsuarioPerfil>>> GetByUsuario(int id)
        {
            var usuarioPerfil = await _context.UsuarioPerfil.Where(up => up.UsuarioId == id).DefaultIfEmpty().ToListAsync();

            return usuarioPerfil == null ? NotFound() : usuarioPerfil;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioPerfil>>> Get([FromQuery]UsuarioPerfilViewModel queryParams)
        {
            if (queryParams.UsuarioId > 0 && queryParams.PerfilId > 0)
            {
                return await _context.UsuarioPerfil.Where(up => up.UsuarioId == queryParams.UsuarioId && up.PerfilId == queryParams.PerfilId).ToListAsync();
            }

            if (queryParams.UsuarioId > 0)
            {
                return await _context.UsuarioPerfil.Where(up => up.UsuarioId == queryParams.UsuarioId).ToListAsync();
            }

            if (queryParams.PerfilId > 0)
            {
                return await _context.UsuarioPerfil.Where(up => up.PerfilId == queryParams.PerfilId).ToListAsync();
            }

            return await _context.UsuarioPerfil.ToListAsync();
        }

        // GET api/<UsuarioPerfilController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioPerfil>> Get(int id)
        {
            var usuarioPerfil = await _context.UsuarioPerfil.FindAsync(id);

            return usuarioPerfil == null ? NotFound() : usuarioPerfil;
        }

        // POST api/<UsuarioPerfilController>
        [HttpPost]
        public async Task<ActionResult<UsuarioPerfil>> Post(UsuarioPerfilViewModel request)
        {
            UsuarioPerfil usuarioPerfil = _mapper.Map<UsuarioPerfil>(request);
            _context.UsuarioPerfil.Add(usuarioPerfil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = usuarioPerfil.Id }, usuarioPerfil);
        }

        // PUT api/<UsuarioPerfilController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UsuarioPerfilViewModel request)
        {
            var usuarioPerfil = await _context.UsuarioPerfil.FindAsync(id);
            _mapper.Map(request, usuarioPerfil);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = usuarioPerfil.Id }, usuarioPerfil);
        }
    }
}
