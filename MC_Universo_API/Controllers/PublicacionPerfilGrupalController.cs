using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacionPerfilGrupalController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PublicacionPerfilGrupalController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from publicacionPerfilGrupal in _context.Set<PublicacionPerfilGrupal>()

                        let catalogoPublicacionPerfilGrupal = _context.CatalogoPublicacionesPerfilGrupal
                            .Where(cp => publicacionPerfilGrupal.CatalogoPublicacionPerfilGrupalId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfilGrupal = _context.UsuarioPerfilGrupal
                            .Where(up => publicacionPerfilGrupal.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfil = _context.Perfil
                            .Where(p => publicacionPerfilGrupal.PerfilGrupalId == p.Id)
                            .FirstOrDefault()

                        where publicacionPerfilGrupal.Activo == true

                        select new
                        {
                            publicacionPerfilGrupal.Id,
                            publicacionPerfilGrupal.UsuarioId,
                            publicacionPerfilGrupal.PerfilUsuarioId,
                            publicacionPerfilGrupal.Titulo,
                            publicacionPerfilGrupal.Descripcion,
                            publicacionPerfilGrupal.Contenido,
                            publicacionPerfilGrupal.Activo,
                            publicacionPerfilGrupal.Url,
                            publicacionPerfilGrupal.ImagenPublicacion,
                            publicacionPerfilGrupal.FechaInicio,
                            publicacionPerfilGrupal.FechaFin,
                            publicacionPerfilGrupal.FechaCreacion,
                            publicacionPerfilGrupal.UrlMovimientoSocial,
                            catalogoPublicacionPerfilGrupal,
                            perfil
                        };

            return query.ToList();
        }

        // GET: api/<PublicacionPerfilGrupalController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PublicacionPerfilGrupal>>> Get()
        {
            return await _context.PublicacionPerfilGrupal.ToListAsync();
        }

        [HttpGet("related/{id}")]
        public object GetRelated(int id)
        {
            var query = from publicacionPerfilGrupal in _context.Set<PublicacionPerfilGrupal>()

                        let catalogoPublicacionPerfilGrupal = _context.CatalogoPublicacionesPerfilGrupal
                            .Where(cp => publicacionPerfilGrupal.CatalogoPublicacionPerfilGrupalId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfilGrupal = _context.UsuarioPerfilGrupal
                            .Where(up => publicacionPerfilGrupal.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfilGrupal = _context.PerfilGrupal
                            .Where(p => publicacionPerfilGrupal.PerfilGrupalId == p.Id)
                            .FirstOrDefault()
                            //.Where(p => usuarioPerfilGrupal.PerfilGrupalId == p.Id)
                            //.FirstOrDefault()

                        where publicacionPerfilGrupal.Id == id && publicacionPerfilGrupal.Activo == true

                        select new
                        {
                            publicacionPerfilGrupal.Id,
                            publicacionPerfilGrupal.UsuarioId,
                            publicacionPerfilGrupal.PerfilUsuarioId,
                            publicacionPerfilGrupal.Titulo,
                            publicacionPerfilGrupal.Descripcion,
                            publicacionPerfilGrupal.Contenido,
                            publicacionPerfilGrupal.Activo,
                            publicacionPerfilGrupal.Url,
                            publicacionPerfilGrupal.ImagenPublicacion,
                            publicacionPerfilGrupal.FechaInicio,
                            publicacionPerfilGrupal.FechaFin,
                            publicacionPerfilGrupal.FechaCreacion,
                            publicacionPerfilGrupal.UrlMovimientoSocial,
                            catalogoPublicacionPerfilGrupal,
                            perfilGrupal
                        };

            return query.First();
        }

        [HttpGet("related/pg={id}")]
        public object GetRelatedByPerfilGrupal(int id)
        {
            var query = from publicacionPerfilGrupal in _context.Set<PublicacionPerfilGrupal>()

                        let catalogoPublicacionPerfilGrupal = _context.CatalogoPublicacionesPerfilGrupal
                            .Where(cp => publicacionPerfilGrupal.CatalogoPublicacionPerfilGrupalId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfilGrupal = _context.UsuarioPerfilGrupal
                            .Where(up => publicacionPerfilGrupal.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfilGrupal = _context.PerfilGrupal
                            .Where(p => publicacionPerfilGrupal.PerfilGrupalId == p.Id)
                            .FirstOrDefault()

                        where publicacionPerfilGrupal.PerfilGrupalId == id && publicacionPerfilGrupal.Activo == true

                        select new
                        {
                            publicacionPerfilGrupal.Id,
                            publicacionPerfilGrupal.UsuarioId,
                            publicacionPerfilGrupal.PerfilUsuarioId,
                            publicacionPerfilGrupal.Titulo,
                            publicacionPerfilGrupal.Descripcion,
                            publicacionPerfilGrupal.Contenido,
                            publicacionPerfilGrupal.Activo,
                            publicacionPerfilGrupal.Url,
                            publicacionPerfilGrupal.ImagenPublicacion,
                            publicacionPerfilGrupal.FechaInicio,
                            publicacionPerfilGrupal.FechaFin,
                            publicacionPerfilGrupal.FechaCreacion,
                            publicacionPerfilGrupal.UrlMovimientoSocial,
                            catalogoPublicacionPerfilGrupal,
                            perfilGrupal
                        };

            return query.ToList();
        }

        [HttpGet("related/u={id}")]
        public object GetRelatedByUsuario(int id)
        {
            var query = from publicacionPerfilGrupal in _context.Set<PublicacionPerfilGrupal>()

                        let catalogoPublicacionPerfilGrupal = _context.CatalogoPublicacionesPerfilGrupal
                            .Where(cp => publicacionPerfilGrupal.CatalogoPublicacionPerfilGrupalId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfilGrupal = _context.UsuarioPerfilGrupal
                            .Where(up => publicacionPerfilGrupal.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfilGrupal = _context.PerfilGrupal
                            .Where(p => publicacionPerfilGrupal.PerfilGrupalId == p.Id)
                            .FirstOrDefault()

                        where publicacionPerfilGrupal.UsuarioId == id && publicacionPerfilGrupal.Activo == true

                        select new
                        {
                            publicacionPerfilGrupal.Id,
                            publicacionPerfilGrupal.UsuarioId,
                            publicacionPerfilGrupal.PerfilUsuarioId,
                            publicacionPerfilGrupal.Titulo,
                            publicacionPerfilGrupal.Descripcion,
                            publicacionPerfilGrupal.Contenido,
                            publicacionPerfilGrupal.Activo,
                            publicacionPerfilGrupal.Url,
                            publicacionPerfilGrupal.ImagenPublicacion,
                            publicacionPerfilGrupal.FechaInicio,
                            publicacionPerfilGrupal.FechaFin,
                            publicacionPerfilGrupal.FechaCreacion,
                            publicacionPerfilGrupal.UrlMovimientoSocial,
                            catalogoPublicacionPerfilGrupal,
                            perfilGrupal
                        };

            return query.ToList();
        }

        [HttpGet("related/pu={id}")]
        public object GetRelatedByPerfilUsuario(int id)
        {
            var query = from publicacionPerfilGrupal in _context.Set<PublicacionPerfilGrupal>()

                        let catalogoPublicacionPerfilGrupal = _context.CatalogoPublicacionesPerfilGrupal
                            .Where(cp => publicacionPerfilGrupal.CatalogoPublicacionPerfilGrupalId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfilGrupal = _context.UsuarioPerfilGrupal
                            .Where(up => publicacionPerfilGrupal.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfilGrupal = _context.PerfilGrupal
                            .Where(p => publicacionPerfilGrupal.PerfilGrupalId == p.Id)
                            .FirstOrDefault()

                        where publicacionPerfilGrupal.PerfilUsuarioId == id && publicacionPerfilGrupal.Activo == true

                        select new
                        {
                            publicacionPerfilGrupal.Id,
                            publicacionPerfilGrupal.UsuarioId,
                            publicacionPerfilGrupal.PerfilUsuarioId,
                            publicacionPerfilGrupal.Titulo,
                            publicacionPerfilGrupal.Descripcion,
                            publicacionPerfilGrupal.Contenido,
                            publicacionPerfilGrupal.Activo,
                            publicacionPerfilGrupal.Url,
                            publicacionPerfilGrupal.ImagenPublicacion,
                            publicacionPerfilGrupal.FechaInicio,
                            publicacionPerfilGrupal.FechaFin,
                            publicacionPerfilGrupal.FechaCreacion,
                            publicacionPerfilGrupal.UrlMovimientoSocial,
                            catalogoPublicacionPerfilGrupal,
                            perfilGrupal
                        };

            return query.ToList();
        }

        [HttpGet("related/url={url}")]
        public object GetRelatedByUrl(string url)
        {
            var query = from publicacionPerfilGrupal in _context.Set<PublicacionPerfilGrupal>()

                        let catalogoPublicacionPerfilGrupal = _context.CatalogoPublicacionesPerfilGrupal
                            .Where(cp => publicacionPerfilGrupal.CatalogoPublicacionPerfilGrupalId == cp.Id)
                            .FirstOrDefault()

                        let usuarioPerfilGrupal = _context.UsuarioPerfilGrupal
                            .Where(up => publicacionPerfilGrupal.UsuarioId == up.UsuarioId)
                            .FirstOrDefault()

                        let perfilGrupal = _context.PerfilGrupal
                            .Where(p => publicacionPerfilGrupal.PerfilGrupalId == p.Id)
                            .FirstOrDefault()

                        let siguiendoIds = _context.PerfilSiguePerfilGrupal
                            .Where(psp => perfilGrupal.Id == psp.PerfilSeguidorId)
                            .DefaultIfEmpty()
                            .ToList()

                        let siguiendoPerfiles = siguiendoIds
                            .Select(s =>
                                _context.UsuarioPerfilGrupal
                                    .Where(up => s.PerfilGrupalSeguidoId == up.PerfilGrupalId)
                                    .FirstOrDefault()
                            )

                        let seguidoresIds = _context.PerfilSiguePerfilGrupal
                            .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidoId)
                            .DefaultIfEmpty()
                            .ToList()

                        let seguidoresPerfiles = seguidoresIds
                            .Select(s =>
                                _context.UsuarioPerfil
                                    .Where(up => s.PerfilGrupalSeguidoId == up.PerfilId)
                                    .FirstOrDefault()
                            )

                        let programasResponsable = _context.ProgramaResponsable
                            .Where(p => usuarioPerfilGrupal.UsuarioId == p.ResponsableId)
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

                        where publicacionPerfilGrupal.Url == url && publicacionPerfilGrupal.Activo == true

                        select new
                        {
                            publicacionPerfilGrupal.Id,
                            publicacionPerfilGrupal.UsuarioId,
                            publicacionPerfilGrupal.PerfilUsuarioId,
                            publicacionPerfilGrupal.Titulo,
                            publicacionPerfilGrupal.Descripcion,
                            publicacionPerfilGrupal.Contenido,
                            publicacionPerfilGrupal.Activo,
                            publicacionPerfilGrupal.Url,
                            publicacionPerfilGrupal.ImagenPublicacion,
                            publicacionPerfilGrupal.FechaInicio,
                            publicacionPerfilGrupal.FechaFin,
                            publicacionPerfilGrupal.FechaCreacion,
                            publicacionPerfilGrupal.UrlMovimientoSocial,
                            catalogoPublicacionPerfilGrupal,
                            perfilGrupal,
                            seguidores = seguidoresPerfiles
                                .Select(sp =>
                                    _context.Perfil
                                        .Where(p => sp.PerfilId == p.Id)
                                        .FirstOrDefault()
                                ),
                            siguiendo = siguiendoPerfiles
                                .Select(sp =>
                                    _context.PerfilGrupal
                                        .Where(p => sp.PerfilGrupalId == p.Id)
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

            return query.First();
        }

        // GET api/<PublicacionPerfilGrupalController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PublicacionPerfilGrupal>> Get(int id)
        {
            var publicacionPerfilGrupal = await _context.PublicacionPerfilGrupal.FindAsync(id);

            return publicacionPerfilGrupal == null ? NotFound() : publicacionPerfilGrupal;
        }

        // POST api/<PublicacionPerfilGrupalController>
        [HttpPost]
        public async Task<ActionResult<PublicacionPerfilGrupal>> Post(PublicacionPerfilGrupalViewModel request)
        {
            PublicacionPerfilGrupal publicacionPerfilGrupal = _mapper.Map<PublicacionPerfilGrupal>(request);

            publicacionPerfilGrupal.Url += "-" + Guid.NewGuid()
                .ToString()
                .Split("-")
                .First();

            _context.PublicacionPerfilGrupal.Add(publicacionPerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = publicacionPerfilGrupal.Id }, publicacionPerfilGrupal);
        }

        // PUT api/<PublicacionPerfilGrupalController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PublicacionPerfilGrupalViewModel request)
        {
            var publicacionPerfilGrupal = await _context.PublicacionPerfilGrupal.FindAsync(id);

            if (publicacionPerfilGrupal == null)
            {
                return NotFound();
            }

            Guid guid = publicacionPerfilGrupal.Guid ?? Guid.NewGuid();

            _mapper.Map(request, publicacionPerfilGrupal);

            publicacionPerfilGrupal.Guid = guid;
            publicacionPerfilGrupal.Url += "-" + guid
                .ToString()
                .Split("-")
                .First();

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = publicacionPerfilGrupal.Id }, publicacionPerfilGrupal);
        }

        [HttpGet("cron/dues")]
        public void CronDues([FromQuery] string uuid)
        {
            /* JG - 20230906 - Desactivar registros expirados */
            var publicacionesExpiradas = (
                from publicacion in _context.Set<PublicacionPerfilGrupal>()

                let perfilGrupal = _context.PerfilGrupal
                    .Where(perfilGrupal => publicacion.PerfilGrupalId == perfilGrupal.Id)
                    .FirstOrDefault()

                where perfilGrupal.Guid == new Guid(uuid)
                where publicacion.FechaFin < DateTime.UtcNow
                //where publicacion.Activo == true

                select publicacion
            ).ToList();

            publicacionesExpiradas = publicacionesExpiradas
                .Select(publicacion => deactivate(publicacion))
                .ToList();

            foreach (var publicacion in publicacionesExpiradas)
            {
                _context.Set<PublicacionPerfilGrupal>().Attach(publicacion);
            }

            _context.SaveChanges();

            /* JG - 20230906 - Activar registros vigentes */
            var publicacionesVigentes = (
                from publicacion in _context.Set<PublicacionPerfilGrupal>()

                let perfilGrupal = _context.PerfilGrupal
                    .Where(perfilGrupal => publicacion.PerfilGrupalId == perfilGrupal.Id)
                    .FirstOrDefault()

                where perfilGrupal.Guid == new Guid(uuid)
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
                _context.Set<PublicacionPerfilGrupal>().Attach(publicacion);
            }

            _context.SaveChanges();
        }

        private PublicacionPerfilGrupal deactivate(PublicacionPerfilGrupal publicacion)
        {
            publicacion.Activo = false;

            return publicacion;
        }

        private PublicacionPerfilGrupal activate(PublicacionPerfilGrupal publicacion)
        {
            publicacion.Activo = true;

            return publicacion;
        }
    }
}
