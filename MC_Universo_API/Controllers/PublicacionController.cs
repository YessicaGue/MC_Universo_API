using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacionController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PublicacionController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from publicacion in _context.Set<Publicacion>()

                        let catalogoPublicacion = _context.CatalogoPublicaciones
                            .Where(cp => publicacion.CatalogoPublicacionId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfil = _context.UsuarioPerfil
                            .Where(up => publicacion.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfil = _context.Perfil
                            .Where(p => publicacion.PerfilId == p.Id)
                            .FirstOrDefault()

                        where publicacion.Activo == true

                        select new
                        {
                            publicacion.Id,
                            publicacion.UsuarioId,
                            publicacion.PerfilId,
                            publicacion.Titulo,
                            publicacion.Descripcion,
                            publicacion.Contenido,
                            publicacion.Activo,
                            publicacion.Url,
                            publicacion.ImagenPublicacion,
                            publicacion.FechaInicio,
                            publicacion.FechaFin,
                            publicacion.FechaCreacion,
                            catalogoPublicacion,
                            perfil
                        };

            return query.ToList();
        }

        // GET: api/<PublicacionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publicacion>>> Get()
        {
            return await _context.Publicacion.ToListAsync();
        }

        [HttpGet("related/{id}")]
        public object GetRelated(int id)
        {
            var query = from publicacion in _context.Set<Publicacion>()

                        let catalogoPublicacion = _context.CatalogoPublicaciones
                            .Where(cp => publicacion.CatalogoPublicacionId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfil = _context.UsuarioPerfil
                            .Where(up => publicacion.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfil = _context.Perfil
                            .Where(p => publicacion.PerfilId == p.Id)
                            .FirstOrDefault()

                        where publicacion.Id == id && publicacion.Activo == true

                        select new
                        {
                            publicacion.Id,
                            publicacion.UsuarioId,
                            publicacion.PerfilId,
                            publicacion.Titulo,
                            publicacion.Descripcion,
                            publicacion.Contenido,
                            publicacion.Activo,
                            publicacion.Url,
                            publicacion.ImagenPublicacion,
                            publicacion.FechaInicio,
                            publicacion.FechaFin,
                            publicacion.FechaCreacion,
                            catalogoPublicacion,
                            perfil
                        };

            return query.First();
        }

        [HttpGet("related/u={id}")]
        public object GetRelatedByUsuario(int id)
        {
            var query = from publicacion in _context.Set<Publicacion>()

                        let catalogoPublicacion = _context.CatalogoPublicaciones
                            .Where(cp => publicacion.CatalogoPublicacionId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfil = _context.UsuarioPerfil
                            .Where(up => publicacion.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfil = _context.Perfil
                            .Where(p => usuarioPerfil.PerfilId == p.Id)
                            .FirstOrDefault()

                        where publicacion.UsuarioId == id && publicacion.Activo == true

                        select new
                        {
                            publicacion.Id,
                            publicacion.UsuarioId,
                            publicacion.PerfilId,
                            publicacion.Titulo,
                            publicacion.Descripcion,
                            publicacion.Contenido,
                            publicacion.Activo,
                            publicacion.Url,
                            publicacion.ImagenPublicacion,
                            publicacion.FechaInicio,
                            publicacion.FechaFin,
                            publicacion.FechaCreacion,
                            catalogoPublicacion,
                            perfil
                        };

            return query.ToList();
        }

        [HttpGet("related/p={id}")]
        public object GetRelatedByPerfil(int id)
        {
            var query = from publicacion in _context.Set<Publicacion>()

                        let catalogoPublicacion = _context.CatalogoPublicaciones
                            .Where(cp => publicacion.CatalogoPublicacionId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfil = _context.UsuarioPerfil
                            .Where(up => publicacion.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfil = _context.Perfil
                            .Where(p => publicacion.PerfilId == p.Id)
                            .FirstOrDefault()

                        where publicacion.PerfilId == id && publicacion.Activo == true

                        select new
                        {
                            publicacion.Id,
                            publicacion.UsuarioId,
                            publicacion.PerfilId,
                            publicacion.Titulo,
                            publicacion.Descripcion,
                            publicacion.Contenido,
                            publicacion.Activo,
                            publicacion.Url,
                            publicacion.ImagenPublicacion,
                            publicacion.FechaInicio,
                            publicacion.FechaFin,
                            publicacion.FechaCreacion,
                            catalogoPublicacion,
                            perfil
                        };

            return query.ToList();
        }

        [HttpGet("related/url={url}")]
        public object GetRelatedByUrl(string url)
        {
            var query = from publicacion in _context.Set<Publicacion>()

                        let catalogoPublicacion = _context.CatalogoPublicaciones
                            .Where(cp => publicacion.CatalogoPublicacionId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfil = _context.UsuarioPerfil
                            .Where(up => publicacion.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfil = _context.Perfil
                            .Where(p => usuarioPerfil.PerfilId == p.Id)
                            .FirstOrDefault()

                        let siguiendoIds = _context.PerfilSiguePerfil
                            .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                            .DefaultIfEmpty()
                            .ToList()

                        let siguiendoPerfiles = siguiendoIds
                            .Select(s =>
                                _context.UsuarioPerfil
                                    .Where(up => s.PerfilSeguidoId == up.PerfilId)
                                    .FirstOrDefault()
                            )

                        let seguidoresIds = _context.PerfilSiguePerfil
                            .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                            .DefaultIfEmpty()
                            .ToList()

                        let seguidoresPerfiles = seguidoresIds
                            .Select(s =>
                                _context.UsuarioPerfil
                                    .Where(up => s.PerfilSeguidorId == up.PerfilId)
                                    .FirstOrDefault()
                            )

                        let programasResponsable = _context.ProgramaResponsable
                            .Where(p => usuarioPerfil.UsuarioId == p.ResponsableId)
                            .DefaultIfEmpty()
                            .ToList()

                        let voluntariosProgramas = programasResponsable
                            .Select(pr =>
                                _context.VoluntarioPrograma
                                    .Where(vp => pr.ProgramaId == vp.ProgramaId)
                                    .First()
                            )
                            .Where(pr => pr != null)
                            .DefaultIfEmpty()
                            .ToList()

                        where publicacion.Url == url && publicacion.Activo == true

                        select new
                        {
                            publicacion.Id,
                            publicacion.UsuarioId,
                            publicacion.PerfilId,
                            publicacion.Titulo,
                            publicacion.Descripcion,
                            publicacion.Contenido,
                            publicacion.Activo,
                            publicacion.Url,
                            publicacion.ImagenPublicacion,
                            publicacion.FechaInicio,
                            publicacion.FechaFin,
                            publicacion.FechaCreacion,
                            catalogoPublicacion,
                            perfil,
                            seguidores = seguidoresPerfiles
                                .Select(sp =>
                                    _context.Perfil
                                        .Where(p => sp.PerfilId == p.Id)
                                        .FirstOrDefault()
                                ),
                            siguiendo = siguiendoPerfiles
                                .Select(sp =>
                                    _context.Perfil
                                        .Where(p => sp.PerfilId == p.Id)
                                        .FirstOrDefault()
                                ),
                            voluntarios = voluntariosProgramas
                                .Select(vp =>
                                    _context.Voluntario
                                        .Where(p => vp.VoluntarioId == p.Id)
                                        .FirstOrDefault()
                                ),
                            voluntariosProgramas,
                            programas = programasResponsable
                                .Select(pr =>
                                    _context.Programa
                                        .Where(p => pr.ProgramaId == p.Id)
                                        .FirstOrDefault()
                                )
                        };

            return query.FirstOrDefault();
        }

        // GET api/<PublicacionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Publicacion>> Get(int id)
        {
            var publicacion = await _context.Publicacion.FindAsync(id);

            return publicacion == null ? NotFound() : publicacion;
        }

        // POST api/<PublicacionController>
        [HttpPost]
        public async Task<ActionResult<Publicacion>> Post(PublicacionViewModel request)
        {
            Publicacion publicacion = _mapper.Map<Publicacion>(request);

            Guid guid = Guid.NewGuid();
            publicacion.Guid = guid;
            publicacion.Url += "-" + guid
                .ToString()
                .Split("-")
                .First();

            _context.Publicacion.Add(publicacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = publicacion.Id }, publicacion);
        }

        // PUT api/<PublicacionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PublicacionViewModel request)
        {
            var publicacion = await _context.Publicacion.FindAsync(id);

            if (publicacion == null)
            {
                return NotFound();
            }

            Guid guid = publicacion.Guid ?? Guid.NewGuid();
            
            _mapper.Map(request, publicacion);

            publicacion.Guid = guid;
            publicacion.Url += "-" + guid
                .ToString()
                .Split("-")
                .First();

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = publicacion.Id }, publicacion);
        }

        [HttpGet("cron/dues")]
        public void CronDues([FromQuery] string uuid)
        {
            /* JG - 20230906 - Desactivar registros expirados */
            var publicacionesExpiradas = (
                from publicacion in _context.Set<Publicacion>()

                let perfil = _context.Perfil
                    .Where(perfil => publicacion.PerfilId == perfil.Id)
                    .FirstOrDefault()

                where perfil.Guid == new Guid(uuid)
                where publicacion.FechaFin < DateTime.UtcNow
                //where publicacion.Activo == true

                select publicacion
            ).ToList();

            publicacionesExpiradas = publicacionesExpiradas
                .Select(publicacion => deactivate(publicacion))
                .ToList();

            foreach (var publicacion in publicacionesExpiradas)
            {
                _context.Set<Publicacion>().Attach(publicacion);
            }

            _context.SaveChanges();

            /* JG - 20230906 - Activar registros vigentes */
            var publicacionesVigentes = (
                from publicacion in _context.Set<Publicacion>()

                let perfil = _context.Perfil
                    .Where(perfil => publicacion.PerfilId == perfil.Id)
                    .FirstOrDefault()

                where perfil.Guid == new Guid(uuid)
                where publicacion.FechaInicio < DateTime.UtcNow
                where publicacion.FechaFin > DateTime.UtcNow
                //where publicacion.Activo == false

                select publicacion
            ).ToList();

            publicacionesVigentes = publicacionesVigentes
                .Select(publicacion => activate(publicacion))
                .ToList();

            foreach (var publicacion in publicacionesVigentes)
            {
                _context.Set<Publicacion>().Attach(publicacion);
            }

            _context.SaveChanges();
        }

        [HttpGet("search_by")]
        public object SearchBy(
            [FromQuery] Guid? guid,
            [FromQuery] Guid? visitors_guid,
            [FromQuery] string? tipo_publicacion,
            [FromQuery] string? order,
            [FromQuery] int? limit,
            [FromQuery] int? skip
        )
        {
            // Splits the string by comma and returns an array having all integer items 
            var tipoIds = string.IsNullOrEmpty(tipo_publicacion) == false
                ? tipo_publicacion
                    .Split(",")
                    .Select(tipo => 
                        int.TryParse(tipo.Trim(), out int value)
                            ? int.Parse(tipo.Trim()) 
                            : 0
                     )
                    .ToList()
                : Enumerable.Empty<int>();

            bool isMe = visitors_guid.ToString() != string.Empty
                && guid.ToString() != string.Empty
                && visitors_guid == guid;

            // Makes a queryable object of publicacion with its type and owner
            var query = from publicacion in _context.Set<Publicacion>()

                        let tipoPublicacion = _context.CatalogoPublicaciones
                            .Where(tipoPublicacion =>
                                publicacion.CatalogoPublicacionId == tipoPublicacion.Id
                             )
                            .FirstOrDefault()

                        let perfil = _context.Perfil
                            .Where(perfil =>
                                publicacion.PerfilId == perfil.Id
                                    && perfil.Activo == true
                             )
                            .FirstOrDefault()

                        where tipoIds.Any()
                            ? tipoIds.Contains(tipoPublicacion.Id)
                            : false
                        where perfil.Guid == guid
                        where publicacion.Activo == true
                        where isMe
                            ? publicacion.EsVisible == true || publicacion.EsVisible == false
                            : publicacion.EsVisible == true

                        orderby string.IsNullOrEmpty(order) == false
                            && (order.ToLower() == "desc" || order.ToLower() == "descending")
                            ? publicacion.FechaCreacion
                            : publicacion.FechaCreacion descending

                        select publicacion;

            if (query.Count() < limit)
            {
                return query;
            }

            return query
                .Skip(skip ?? 0)
                .Take(limit ?? 5);
        }

        // PUT api/<PublicacionController>/5
        [HttpPut]
        public async Task<IActionResult> PutV2(
            [FromQuery] Guid? guid,
            PublicacionViewModel request
        )
        {
            var publicacion = await _context.Publicacion
                .Where(publicacion => guid == publicacion.Guid)
                .FirstOrDefaultAsync();

            if (publicacion == null)
            {
                return NotFound();
            }

            Guid refGuid = publicacion.Guid ?? Guid.NewGuid();

            _mapper.Map(request, publicacion);

            publicacion.Guid = refGuid;
            publicacion.Url += "-" + refGuid
                .ToString()
                .Split("-")
                .First();

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = publicacion.Id }, publicacion);
        }

        private Publicacion deactivate(Publicacion publicacion)
        {
            publicacion.Activo = false;

            return publicacion;
        }

        private Publicacion activate(Publicacion publicacion)
        {
            publicacion.Activo = true;

            return publicacion;
        }
    }
}
