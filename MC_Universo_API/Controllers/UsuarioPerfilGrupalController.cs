using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioPerfilGrupalController : Controller
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public UsuarioPerfilGrupalController(UniversoContext context, IMapper mapper)
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
        public async Task<ActionResult<IEnumerable<UsuarioPerfilGrupal>>> GetByUsuario(int id)
        {
            var usuarioPerfilGrupal = await _context.UsuarioPerfilGrupal.Where(up => up.UsuarioId == id).DefaultIfEmpty().ToListAsync();

            return usuarioPerfilGrupal;
        }


        // GET: api/<UsuarioPerfilController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioPerfilGrupal>>> Get()
        {
            return await _context.UsuarioPerfilGrupal.ToListAsync();
        }

        // GET api/<UsuarioPerfilController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioPerfilGrupal>> Get(int id)
        {
            var usuarioPerfilGrupal = await _context.UsuarioPerfilGrupal.FindAsync(id);

            return usuarioPerfilGrupal == null ? NotFound() : usuarioPerfilGrupal;
        }

        // POST api/<UsuarioPerfilController>
        [HttpPost]
        public async Task<ActionResult<UsuarioPerfilGrupal>> Post(UsuarioPerfilGrupalViewModel request)
        {
            UsuarioPerfilGrupal usuarioPerfilGrupal = _mapper.Map<UsuarioPerfilGrupal>(request);
            _context.UsuarioPerfilGrupal.Add(usuarioPerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = usuarioPerfilGrupal.Id }, usuarioPerfilGrupal);
        }

        // PUT api/<UsuarioPerfilController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UsuarioPerfilGrupalViewModel request)
        {
            var usuarioPerfilGrupal = await _context.UsuarioPerfilGrupal.FindAsync(id);
            _mapper.Map(request, usuarioPerfilGrupal);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = usuarioPerfilGrupal.Id }, usuarioPerfilGrupal);
        }
    }
}
