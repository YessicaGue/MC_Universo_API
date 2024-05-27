using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilGrupalController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilGrupalController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("init/u={id}")]
        public async Task<ActionResult<PerfilGrupal>> Init(int id, PerfilGrupal request)
        {
            PerfilGrupal perfilGrupal = _mapper.Map<PerfilGrupal>(request);
            _context.PerfilGrupal.Add(perfilGrupal);
            await _context.SaveChangesAsync();

            UsuarioPerfilGrupalViewModel usuarioPerfilGrupalVM = new UsuarioPerfilGrupalViewModel { UsuarioId = id, PerfilGrupalId = perfilGrupal.Id };
            UsuarioPerfilGrupal usuarioPerfilGrupal = _mapper.Map<UsuarioPerfilGrupal>(usuarioPerfilGrupalVM);
            _context.UsuarioPerfilGrupal.Add(usuarioPerfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilGrupal.Id }, perfilGrupal);
        }

        [HttpGet("related")]
        public object GetAllRelated()
        {
            var query = from perfilGrupal in _context.Set<PerfilGrupal>()

                let siguiendoIds = _context.PerfilGrupalSiguePerfil
                    .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()

                let siguiendoIdsGrupales = _context.PerfilGrupalSiguePerfilGrupal
                    .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()

                let seguidoresIds = _context.PerfilSiguePerfilGrupal
                    .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()

                let seguidoresIdsGrupales = _context.PerfilGrupalSiguePerfilGrupal
                    .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()

                let usuariosPerfilGrupal = _context.UsuarioPerfilGrupal
                    .Where(upg => perfilGrupal.Id == upg.PerfilGrupalId)
                    .DefaultIfEmpty()
                    .ToList()

                let programasResponsable = usuariosPerfilGrupal
                    .Select(upg =>
                        _context.ProgramaResponsable
                            .Where(pr => upg.UsuarioId == pr.ResponsableId)
                            .FirstOrDefault()
                    )

                let voluntariosProgramas = programasResponsable
                    .Select(pr =>
                        _context.VoluntarioPrograma
                            .Where(vp => pr.ProgramaId == vp.ProgramaId)
                            .First()
                    )
                    .Where(pr => pr != null)
                    .DefaultIfEmpty()
                    .ToList()

                where perfilGrupal.Activo == true

                select new
                {
                    usuariosPerfilGrupal,
                    perfilGrupal,
                    seguidores = seguidoresIds
                        .Select(sp =>
                            _context.Perfil
                                .Where(p => sp.PerfilSeguidorId == p.Id)
                                .FirstOrDefault()
                        )
                        .Where(s => s != null)
                        .Select(p => new
                        {
                            id = p.Id,
                            activo = p.Activo,
                            alias = p.Alias,
                            esPublico = p.esPublico,
                            fechaCreacion = p.FechaCreacion,
                            guid = p.Guid,
                            url = p.Url,
                            userData = _context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    siguiendo = siguiendoIds
                        .Select(sp =>
                            _context.Perfil
                                .Where(p => sp.PerfilSeguidoId == p.Id)
                                .FirstOrDefault()
                        )
                        .Where(s => s != null)
                        .Select(p => new
                        {
                            id = p.Id,
                            activo = p.Activo,
                            alias = p.Alias,
                            esPublico = p.esPublico,
                            fechaCreacion = p.FechaCreacion,
                            guid = p.Guid,
                            url = p.Url,
                            userData = _context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    seguidoresGrupales = seguidoresIdsGrupales
                        .Select(sp =>
                            _context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                .FirstOrDefault()
                        ),
                    siguiendoGrupales = siguiendoIdsGrupales
                        .Select(sp =>
                            _context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
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

            return query.ToList();
        }

        [HttpGet("related/p={uuid}")]
        public object GetRelatedByPerfil(Guid uuid)
        {
            var query = from perfilGrupal in _context.Set<PerfilGrupal>()

                let siguiendoIds = _context.PerfilGrupalSiguePerfil
                    .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()

                let siguiendoIdsGrupales = _context.PerfilGrupalSiguePerfilGrupal
                    .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()

                let seguidoresIds = _context.PerfilSiguePerfilGrupal
                    .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()

                let seguidoresIdsGrupales = _context.PerfilGrupalSiguePerfilGrupal
                    .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()

                let usuariosPerfilGrupal = _context.UsuarioPerfilGrupal
                    .Where(upg => perfilGrupal.Id == upg.PerfilGrupalId)
                    .DefaultIfEmpty()
                    .ToList()

                let programasResponsable = usuariosPerfilGrupal
                    .Select(upg => 
                        _context.ProgramaResponsable
                            .Where(pr => upg.UsuarioId == pr.ResponsableId)
                            .FirstOrDefault()
                    )

                let voluntariosProgramas = programasResponsable
                    .Select(pr =>
                        _context.VoluntarioPrograma
                            .Where(vp => pr.ProgramaId == vp.ProgramaId)
                            .First()
                    )
                    .Where(pr => pr != null)
                    .DefaultIfEmpty()
                    .ToList()

                let perfilGrupalCatalogoRedesSociales = _context.PerfilGrupalCatalogoRedesSociales
                            .Where(pcr => perfilGrupal.Id == pcr.PerfilGrupalId)
                            .DefaultIfEmpty()
                            .ToList()

                where perfilGrupal.Guid == uuid && perfilGrupal.Activo == true

                select new
                {
                    usuariosPerfilGrupal,
                    perfilGrupal,
                    seguidores = seguidoresIds
                        .Select(sp =>
                            _context.Perfil
                                .Where(p => sp.PerfilSeguidorId == p.Id)
                                .FirstOrDefault()
                        )
                        .Where(s => s != null)
                        .Select(p => new
                        {
                            id = p.Id,
                            activo = p.Activo,
                            alias = p.Alias,
                            esPublico = p.esPublico,
                            fechaCreacion = p.FechaCreacion,
                            guid = p.Guid,
                            url = p.Url,
                            userData = _context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    siguiendo = siguiendoIds
                        .Select(sp =>
                            _context.Perfil
                                .Where(p => sp.PerfilSeguidoId == p.Id)
                                .FirstOrDefault()
                        )
                        .Where(s => s != null)
                        .Select(p => new
                        {
                            id = p.Id,
                            activo = p.Activo,
                            alias = p.Alias,
                            esPublico = p.esPublico,
                            fechaCreacion = p.FechaCreacion,
                            guid = p.Guid,
                            url = p.Url,
                            userData = _context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    seguidoresGrupales = seguidoresIdsGrupales
                        .Select(sp =>
                            _context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                .FirstOrDefault()
                        ),
                    siguiendoGrupales = siguiendoIdsGrupales
                        .Select(sp =>
                            _context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
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
                        ),
                    perfilGrupalCatalogoRedesSociales
                };

            return query.FirstOrDefault();
        }

        [HttpGet("related-by-usuario/{id}")]
        public object GetRelatedByUsuario(int id)
        {
            var query = from usuarioPerfilGrupal in _context.Set<UsuarioPerfilGrupal>()

                        let perfilesGrupales = _context.PerfilGrupal
                            .Where(p => usuarioPerfilGrupal.PerfilGrupalId == p.Id)
                            .DefaultIfEmpty()
                            .ToList()

                        /*let siguiendoIds = perfilesGrupales
                            .Select(pg =>
                                _context.PerfilSiguePerfilGrupal
                                    .Where(pspg => pg.Id == pspg.PerfilSeguidorId)
                                    .FirstOrDefault()
                            )

                        let siguiendoPerfilesGrupales = siguiendoIds
                            .Select(s =>
                                _context.UsuarioPerfilGrupal
                                    .Where(up => s.PerfilGrupalSeguidoId == up.PerfilGrupalId)
                                    .FirstOrDefault()_
                            )*/

                        let seguidoresIds = perfilesGrupales
                            .Select(pg =>
                                _context.PerfilSiguePerfilGrupal
                                    .Where(pspg => pg.Id == pspg.PerfilGrupalSeguidoId)
                                    .FirstOrDefault()
                            )

                        let seguidoresPerfiles = seguidoresIds
                            .Select(s =>
                                _context.UsuarioPerfil
                                    .Where(up => s.PerfilSeguidorId == up.PerfilId)
                                    .FirstOrDefault()
                            )

                        where usuarioPerfilGrupal.UsuarioId == id

                        select new
                        {
                            usuarioPerfilGrupal.Id,
                            usuarioPerfilGrupal.UsuarioId,
                            usuarioPerfilGrupal.FechaCreacion,
                            perfilesGrupales,
                            seguidores = seguidoresPerfiles
                                .Select(sp =>
                                    _context.Perfil
                                        .Where(p => sp.PerfilId == p.Id)
                                        .FirstOrDefault()
                                ),
                            /*siguiendo = siguiendoPerfilesGrupales
                                .Select(sp =>
                                    _context.Perfil
                                        .Where(p => sp.PerfilGrupalId == p.Id)
                                        .FirstOrDefault()
                                ),*/
                        };

            return query.FirstOrDefault();
        }

        // GET: api/<PerfilController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilGrupal>>> Get()
        {
            return await _context.PerfilGrupal.ToListAsync();
        }

        // GET api/<PerfilController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilGrupal>> Get(int id)
        {
            var perfilGrupal = await _context.PerfilGrupal.FindAsync(id);

            return perfilGrupal == null ? NotFound() : perfilGrupal;
        }

        // GET api/<PerfilController>/5
        [HttpGet("uuid={uuid}")]
        public async Task<ActionResult<PerfilGrupal>> GetByUuid(Guid uuid)
        {
            var perfilGrupal = await _context.PerfilGrupal.Where(pg => pg.Guid == uuid).FirstOrDefaultAsync();

            return perfilGrupal == null ? NotFound() : perfilGrupal;
        }


        // POST api/<PerfilController>
        [HttpPost]
        public async Task<ActionResult<PerfilGrupal>> Post(PerfilGrupalViewModel request)
        {
            PerfilGrupal perfilGrupal = _mapper.Map<PerfilGrupal>(request);
            _context.PerfilGrupal.Add(perfilGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilGrupal.Id }, perfilGrupal);
        }

        [HttpPut("uuid/{uuid}")]
        public async Task<IActionResult> Put(Guid uuid, PerfilGrupalViewModel request)
        {
            var perfilGrupal = await _context.PerfilGrupal.FirstOrDefaultAsync(p => p.Guid == uuid);
            if (perfilGrupal == null)
            {
                return NotFound(); // Otra respuesta adecuada si el objeto no existe
            }
            //var perfilGrupal = await _context.PerfilGrupal.FindAsync(id);
            _mapper.Map(request, perfilGrupal);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { id = perfilGrupal.Id }, perfilGrupal);
        }

        // PUT api/<PerfilController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilGrupalViewModel request)
        {
            var perfilGrupal = await _context.PerfilGrupal.FindAsync(id);
            _mapper.Map(request, perfilGrupal);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilGrupal.Id }, perfilGrupal);
        }

        [HttpGet("for-settings/{id}")]
        public object GetForSettings(int id)
        {
            var query = from perfilGrupal in _context.Set<PerfilGrupal>()

                        let perfilGrupalCatalogoRedesSociales = _context.PerfilGrupalCatalogoRedesSociales
                            .Where(perfilRedSocial =>
                                perfilGrupal.Id == perfilRedSocial.PerfilGrupalId
                                    && perfilRedSocial.Activo == true
                             )
                            .DefaultIfEmpty()
                            .ToList()

                        where perfilGrupal.Activo == true
                        where perfilGrupal.Id == id

                        select new
                        {
                            id = perfilGrupal.Id,
                            activo = perfilGrupal.Activo,
                            alias = perfilGrupal.Alias,
                            frase = perfilGrupal.Frase,
                            esPublico = perfilGrupal.esPublico,
                            fechaCreacion = perfilGrupal.FechaCreacion,
                            guid = perfilGrupal.Guid,
                            customUrl = perfilGrupal.CustomUrl,
                            url = perfilGrupal.Url,
                            redesSociales = perfilGrupalCatalogoRedesSociales
                                 .Select(perfilRedes =>
                                     new
                                     {
                                         id = perfilRedes.Id,
                                         url = perfilRedes.Url,
                                         activo = perfilRedes.Activo,
                                         redSocial = _context.CatalogoRedesSociales
                                             .Where(redesSociales =>
                                                perfilRedes.CatalogoRedesSocialesId == redesSociales.Id
                                                    && redesSociales.Activo == true
                                             )
                                            .FirstOrDefault()
                                     }
                                 )
                                 .Where(perfilRedes => perfilRedes.activo == true)
                                 .DefaultIfEmpty()
                                 .ToList(),
                            
                        };

            if (query.FirstOrDefault() == null)
            {
                return NotFound();
            }

            return query.First();
        }

        [HttpGet("related/customUrl={customUrl}")]
        public object GetRelatedByCustomUrl(string customUrl)
        {
            var query = from perfilGrupal in _context.Set<PerfilGrupal>()

                        let siguiendoIds = _context.PerfilGrupalSiguePerfil
                            .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidorId)
                            .DefaultIfEmpty()
                            .ToList()

                        let siguiendoIdsGrupales = _context.PerfilGrupalSiguePerfilGrupal
                            .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidorId)
                            .DefaultIfEmpty()
                            .ToList()

                        let seguidoresIds = _context.PerfilSiguePerfilGrupal
                            .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidoId)
                            .DefaultIfEmpty()
                            .ToList()

                        let seguidoresIdsGrupales = _context.PerfilGrupalSiguePerfilGrupal
                            .Where(psp => perfilGrupal.Id == psp.PerfilGrupalSeguidoId)
                            .DefaultIfEmpty()
                            .ToList()

                        let usuariosPerfilGrupal = _context.UsuarioPerfilGrupal
                            .Where(upg => perfilGrupal.Id == upg.PerfilGrupalId)
                            .DefaultIfEmpty()
                            .ToList()

                        let programasResponsable = usuariosPerfilGrupal
                            .Select(upg =>
                                _context.ProgramaResponsable
                                    .Where(pr => upg.UsuarioId == pr.ResponsableId)
                                    .FirstOrDefault()
                            )

                        let voluntariosProgramas = programasResponsable
                            .Select(pr =>
                                _context.VoluntarioPrograma
                                    .Where(vp => pr.ProgramaId == vp.ProgramaId)
                                    .First()
                            )
                            .Where(pr => pr != null)
                            .DefaultIfEmpty()
                            .ToList()

                        let perfilGrupalCatalogoRedesSociales = _context.PerfilGrupalCatalogoRedesSociales
                                    .Where(pcr => perfilGrupal.Id == pcr.PerfilGrupalId)
                                    .DefaultIfEmpty()
                                    .ToList()

                        where perfilGrupal.CustomUrl == customUrl && perfilGrupal.Activo == true

                        select new
                        {
                            usuariosPerfilGrupal,
                            perfilGrupal,
                            seguidores = seguidoresIds
                                .Select(sp =>
                                    _context.Perfil
                                        .Where(p => sp.PerfilSeguidorId == p.Id)
                                        .FirstOrDefault()
                                )
                                .Select(p => new
                                {
                                    id = p.Id,
                                    activo = p.Activo,
                                    alias = p.Alias,
                                    esPublico = p.esPublico,
                                    fechaCreacion = p.FechaCreacion,
                                    guid = p.Guid,
                                    url = p.Url,
                                    userData = _context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                        ? new
                                        {
                                            usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                            perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                            isDashboard = true
                                        }
                                        : new
                                        {
                                            usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                            perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                            isDashboard = false
                                        }
                                }),
                            siguiendo = siguiendoIds
                                .Select(sp =>
                                    _context.Perfil
                                        .Where(p => sp.PerfilSeguidoId == p.Id)
                                        .FirstOrDefault()
                                )
                                .Select(p => new
                                {
                                    id = p.Id,
                                    activo = p.Activo,
                                    alias = p.Alias,
                                    esPublico = p.esPublico,
                                    fechaCreacion = p.FechaCreacion,
                                    guid = p.Guid,
                                    url = p.Url,
                                    userData = _context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                        ? new
                                        {
                                            usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                            perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                            isDashboard = true
                                        }
                                        : new
                                        {
                                            usuarioPerfil = _context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                            perfilUsuario = _context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                            isDashboard = false
                                        }
                                }),
                            seguidoresGrupales = seguidoresIdsGrupales
                                .Select(sp =>
                                    _context.PerfilGrupal
                                        .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                        .FirstOrDefault()
                                ),
                            siguiendoGrupales = siguiendoIdsGrupales
                                .Select(sp =>
                                    _context.PerfilGrupal
                                        .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
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
                                ),
                            perfilGrupalCatalogoRedesSociales
                        };

            return query.FirstOrDefault();
        }
    }
}
