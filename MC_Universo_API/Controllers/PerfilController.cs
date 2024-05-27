using AutoMapper;
using Azure.Core;
using DocumentFormat.OpenXml.InkML;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.Models.Precandidaturas;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Any;
using Npgsql;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static MC_Universo_API.Controllers.Precandidaturas.ApoyoPrecandidaturaController;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController(UniversoContext context, IMapper mapper) : ControllerBase
    {
        [HttpPost("init/u={id:int}")]
        public async Task<ActionResult<Perfil>> Init(int id, PerfilViewModel request)
        {
            Perfil perfil = mapper.Map<Perfil>(request);
            context.Perfil.Add(perfil);
            await context.SaveChangesAsync();

            UsuarioPerfilViewModel usuarioPerfilVM = new UsuarioPerfilViewModel
                { UsuarioId = id, PerfilId = perfil.Id };
            UsuarioPerfil usuarioPerfil = mapper.Map<UsuarioPerfil>(usuarioPerfilVM);
            context.UsuarioPerfil.Add(usuarioPerfil);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfil.Id }, perfil);
        }

        [HttpGet("related")]
        public object GetAllRelated()
        {
            var query = from usuarioPerfil in context.Set<UsuarioPerfil>()
                let perfil = context.Perfil
                    .Where(p => usuarioPerfil.PerfilId == p.Id)
                    .FirstOrDefault()
                let usuariosPerfilesGrupales = context.UsuarioPerfilGrupal
                    .Where(upg => usuarioPerfil.UsuarioId == upg.UsuarioId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesGrupales = usuariosPerfilesGrupales
                    .Select(upg =>
                        context.PerfilGrupal
                            .Where(pg => upg.PerfilGrupalId == pg.Id)
                            .FirstOrDefault()
                    )
                let siguiendoIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let siguiendoIdsGrupales = context.PerfilSiguePerfilGrupal
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIdsGrupales = context.PerfilGrupalSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let programasResponsable = context.ProgramaResponsable
                    .Where(p => usuarioPerfil.UsuarioId == p.ResponsableId)
                    .DefaultIfEmpty()
                    .ToList()
                let voluntariosProgramas = programasResponsable
                    .Select(pr =>
                        context.VoluntarioPrograma
                            .Where(vp => pr.ProgramaId == vp.ProgramaId)
                            .First()
                    )
                    .Where(pr => pr != null)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilToken = context.PerfilToken
                    .Where(pt => perfil.Id == pt.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilCatalogoRedesSociales = context.PerfilCatalogoRedesSociales
                    .Where(pcr => usuarioPerfil.PerfilId == pcr.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()
                let caminoCandidato = context.CandidatosCHC
                    .Where(cc => perfil.Id == cc.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()
                select new
                {
                    usuarioPerfil.Id,
                    usuarioPerfil.UsuarioId,
                    usuarioPerfil.FechaCreacion,
                    perfil,
                    perfilesGrupales,
                    seguidores = seguidoresIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    siguiendo = siguiendoIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    seguidoresGrupales = seguidoresIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                .FirstOrDefault()
                        ),
                    siguiendoGrupales = siguiendoIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
                                .FirstOrDefault()
                        ),
                    voluntarios = voluntariosProgramas
                        .Select(vp =>
                            context.Voluntario
                                .Where(p => vp.VoluntarioId == p.Id)
                                .FirstOrDefault()
                        ),
                    voluntariosProgramas,
                    programas = programasResponsable
                        .Select(pr =>
                            context.Programa
                                .Where(p => pr.ProgramaId == p.Id)
                                .FirstOrDefault()
                        ),
                    tokens = perfilToken
                        .Select(pt =>
                            context.Token
                                .Where(t => pt.TokenId == t.Id)
                                .FirstOrDefault()
                        ),
                    perfilToken,
                    perfilCatalogoRedesSociales,
                    caminoCandidato,
                };

            return query.ToList();
        }

        //Buscador Perfiles
        [HttpGet("buscador")]
        public async Task<ActionResult<IEnumerable<object>>> GetPerfilAll()
        {
            return await context.Perfil
            .Where(nop => nop.Activo == true && nop.Alias != null && nop.CustomUrl != null )

            .Select(nop => new { nop.Activo, nop.Alias, nop.CustomUrl, isDashboard = true  }) 
            
            .ToListAsync();

        }

        ////Buscador Landing
        //[HttpGet("buscadorLoading")]
        //public async Task<ActionResult<IEnumerable<object>>> GetLoadingAll()
        //{
        //    return await context.Perfil
        //    .Where(nop => nop.Activo == true && nop.esCandidato == true && nop.Alias != null && nop.CustomUrl != null)
        
        //    .Select(nop => new { nop.Activo, nop.esCandidato, nop.Alias, nop.CustomUrl })
        //    .OrderBy(nop => nop.Alias)
        //    .ToListAsync();

        //}



        //Buscador Landing
        [HttpGet("buscadorLoading")]
        public async Task<ActionResult<IEnumerable<object>>> GetLoadingAll()
        {
            return await context.Perfil
                .Join(context.PerfilPrecandidatura,
                    perfiles => perfiles.Id,
                    perfilpre => perfilpre.PerfilId,
                    (perfiles, perfilpre) => new { Perfiles = perfiles, Perfilpre = perfilpre})
                .Where(nop => nop.Perfiles.Activo == true && nop.Perfiles.esCandidato == true && nop.Perfiles.Alias != null && nop.Perfiles.CustomUrl != null)

                .Select(nop => new { nop.Perfiles.Activo, nop.Perfiles.esCandidato, nop.Perfiles.Alias, nop.Perfiles.CustomUrl })
               
                .ToListAsync();

        }





        [HttpGet("related/{id:int}")]
        public object GetRelatedById(int id)
        {
            var query = from perfilUsuario in context.Set<PerfilUsuario>()
                let perfil = context.Perfil
                    .Where(p => perfilUsuario.PerfilId == p.Id)
                    .FirstOrDefault()
                let perfilesUsuariosPerfilesGrupales = context.PerfilUsuarioPerfilGrupal
                    .Where(pupg => perfilUsuario.Id == pupg.PerfilUsuarioId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesGrupales = perfilesUsuariosPerfilesGrupales
                    .Select(upg =>
                        context.PerfilGrupal
                            .Where(pg => upg.PerfilGrupalId == pg.Id)
                            .FirstOrDefault()
                    )
                let siguiendoIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let siguiendoIdsGrupales = context.PerfilSiguePerfilGrupal
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIdsGrupales = context.PerfilGrupalSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilToken = context.PerfilToken
                    .Where(pt => perfil.Id == pt.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()
                where perfilUsuario.Id == id
                select new
                {
                    perfilUsuario.Id,
                    perfilUsuario.Name,
                    perfilUsuario.Email,
                    perfilUsuario.Area,
                    perfilUsuario.FechaCreacion,
                    perfil,
                    perfilesGrupales,
                    seguidores = seguidoresIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    siguiendo = siguiendoIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    seguidoresGrupales = seguidoresIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                .FirstOrDefault()
                        ),
                    siguiendoGrupales = siguiendoIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
                                .FirstOrDefault()
                        ),
                    tokens = perfilToken
                        .Select(pt =>
                            context.Token
                                .Where(t => pt.TokenId == t.Id)
                                .FirstOrDefault()
                        ),
                    perfilToken,
                };

            return query.FirstOrDefault();
        }

        [HttpGet("related/uuid={guid:guid}")]
        public object GetRelatedByGuid(Guid guid)
        {
            var query = from perfilUsuario in context.Set<PerfilUsuario>()
                let perfil = context.Perfil
                    .Where(p => perfilUsuario.PerfilId == p.Id)
                    .FirstOrDefault()
                let perfilesUsuariosPerfilesGrupales = context.PerfilUsuarioPerfilGrupal
                    .Where(pupg => perfilUsuario.Id == pupg.PerfilUsuarioId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesGrupales = perfilesUsuariosPerfilesGrupales
                    .Select(upg =>
                        context.PerfilGrupal
                            .Where(pg => upg.PerfilGrupalId == pg.Id)
                            .FirstOrDefault()
                    )
                let siguiendoIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let siguiendoIdsGrupales = context.PerfilSiguePerfilGrupal
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIdsGrupales = context.PerfilGrupalSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesEnCirculo = context.PerfilSiguePerfil
                    .Where(psp => psp.PerfilSeguidoId == perfil.Id && psp.EnCirculo == true)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilToken = context.PerfilToken
                    .Where(pt => perfil.Id == pt.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()
                //let caminoCandidatoExists = _context.CandidatosCHC
                //    .Any(cc => perfil.Id == cc.PerfilId)

                //let candidato = _context.CandidatosCHC
                //    .Where(chc => perfil.Id == chc.PerfilId)
                //    .FirstOrDefault()

                //let registroDatosFaltantesInicialExists = _context.PerfilPersonaCHC
                //    .Any(ppc => perfil.Id == ppc.PerfilId)

                //let etapaActualRegistro = _context.CatalogoEtapaRegistroCHC
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => !_context.CandidatoEtapaRegistroCHC.Any(ce =>
                //        ce.CandidatosCHC.PerfilId == perfil.Id && ce.CatalogoEtapaRegistroCHC.Id == e.Id))

                //let etapaSiguienteRegistro = _context.CatalogoEtapaRegistroCHC
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => e.IndiceOrden > etapaActualRegistro.IndiceOrden)

                //let esInicioEtapaRegistro = etapaActualRegistro.IndiceOrden == 1

                //let esUltimaEtapaRegistro = etapaSiguienteRegistro == null

                //let etapasCompletasRegistro = !_context.CatalogoEtapaRegistroCHC
                //    .Any(e => !_context.CandidatoEtapaRegistroCHC.Any(ce =>
                //        ce.CandidatosCHC.PerfilId == perfil.Id && ce.CatalogoEtapaRegistroCHC.Id == e.Id))

                //let avance = _context.AvanceEtapasCandidato
                //    .FirstOrDefault(ae =>
                //        ae.CandidatosCHC.PerfilId == perfil.Id &&
                //        ae.CatalogoEtapasCHC.CaminoId == candidato.CaminoId &&
                //        ae.PorcentajeAvance < 100)

                //let etapaActualCamino = _context.CatalogoEtapasCHC
                //        .Where(etapa => etapa.CaminoId == candidato.CaminoId)
                //        .OrderBy(e => e.IndiceOrden)
                //        .FirstOrDefault(e => avance != null && e.Id == avance.CatalogoEtapasCHC.Id)
                //    ?? _context.CatalogoEtapasCHC
                //        .Where(etapa => etapa.CaminoId == candidato.CaminoId)
                //        .OrderBy(e => e.IndiceOrden)
                //        .FirstOrDefault(e => !_context.AvanceEtapasCandidato.Any(
                //            ae => ae.CandidatosCHC.PerfilId == perfil.Id &&
                //                  ae.CatalogoEtapasCHC.Id == e.Id))
                where perfil.Guid == guid
                select new
                {
                    perfilUsuario.Id,
                    perfilUsuario.Name,
                    perfilUsuario.Email,
                    perfilUsuario.Area,
                    perfilUsuario.FechaCreacion,
                    perfil,
                    perfilesGrupales,
                    seguidores = seguidoresIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    siguiendo = siguiendoIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    seguidoresGrupales = seguidoresIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                .FirstOrDefault()
                        ),
                    siguiendoGrupales = siguiendoIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
                                .FirstOrDefault()
                        ),
                    tokens = perfilToken
                        .Select(pt =>
                            context.Token
                                .Where(t => pt.TokenId == t.Id)
                                .FirstOrDefault()
                        ),
                    perfilToken,
                    caminoCandidatoExists = false,
                    registroDatosFaltantesInicialExists = false,
                    etapaActualRegistro = new { },
                    etapaSiguienteRegistro = new { },
                    esInicioEtapaRegistro = false,
                    esUltimaEtapaRegistro = false,
                    etapasCompletasRegistro = false,
                    etapaActualCamino = new { },
                    avance = new { },
                    candidato = new { },
                };


            return query.FirstOrDefault();
        }

        [HttpGet("related/p={uuid:guid}")]
        public object GetRelatedByPerfil(Guid uuid)
        {
            var query = from usuarioPerfil in context.Set<UsuarioPerfil>()
                let perfil = context.Perfil
                    .Where(p => usuarioPerfil.PerfilId == p.Id)
                    .FirstOrDefault()
                let usuariosPerfilesGrupales = context.UsuarioPerfilGrupal
                    .Where(upg => usuarioPerfil.UsuarioId == upg.UsuarioId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesGrupales = usuariosPerfilesGrupales
                    .Select(upg =>
                        context.PerfilGrupal
                            .Where(pg => upg.PerfilGrupalId == pg.Id)
                            .FirstOrDefault()
                    )
                let siguiendoIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let siguiendoIdsGrupales = context.PerfilSiguePerfilGrupal
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIdsGrupales = context.PerfilGrupalSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesEnCirculo = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId && psp.EnCirculo == true)
                    .Join(
                        context.UsuarioPerfil,
                        psp => psp.PerfilSeguidoId,
                        up => up.PerfilId,
                        (psp, up) => new
                        {
                            psp.Id,
                            psp.PerfilSeguidoId,
                            psp.PerfilSeguido,
                            psp.PerfilSeguidorId,
                            psp.PerfilSeguidor,
                            psp.EnCirculo,
                            up.UsuarioId
                        }
                    )
                    .DefaultIfEmpty()
                    .ToList()
                let programasResponsable = context.ProgramaResponsable
                    .Where(p => usuarioPerfil.UsuarioId == p.ResponsableId)
                    .DefaultIfEmpty()
                    .ToList()
                let voluntariosProgramas = programasResponsable
                    .Select(pr =>
                        context.VoluntarioPrograma
                            .Where(vp => pr.ProgramaId == vp.ProgramaId)
                            .First()
                    )
                    .Where(pr => pr != null)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilToken = context.PerfilToken
                    .Where(pt => perfil.Id == pt.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilCatalogoRedesSociales = context.PerfilCatalogoRedesSociales
                    .Where(pcr => usuarioPerfil.PerfilId == pcr.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()

                //let caminoCandidatoExists = _context.CandidatosCHC
                //    .Any(cc => perfil.Id == cc.PerfilId)

                //let candidato = _context.CandidatosCHC
                //    .Where(chc => perfil.Id == chc.PerfilId)
                //    .FirstOrDefault()

                //let registroDatosFaltantesInicialExists = _context.PerfilPersonaCHC
                //    .Any(ppc => perfil.Id == ppc.PerfilId)

                //let etapaActualRegistro = _context.CatalogoEtapaRegistroCHC
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => !_context.CandidatoEtapaRegistroCHC.Any(ce =>
                //        ce.CandidatosCHC.PerfilId == perfil.Id && ce.CatalogoEtapaRegistroCHC.Id == e.Id))

                //let etapaSiguienteRegistro = _context.CatalogoEtapaRegistroCHC
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => e.IndiceOrden > etapaActualRegistro.IndiceOrden)

                //let esInicioEtapaRegistro = etapaActualRegistro.IndiceOrden == 1

                //let esUltimaEtapaRegistro = etapaSiguienteRegistro == null

                //let etapasCompletasRegistro = !_context.CatalogoEtapaRegistroCHC
                //    .Any(e => !_context.CandidatoEtapaRegistroCHC.Any(ce =>
                //        ce.CandidatosCHC.PerfilId == perfil.Id && ce.CatalogoEtapaRegistroCHC.Id == e.Id))

                //let avance = _context.AvanceEtapasCandidato
                //    .FirstOrDefault(ae => 
                //        ae.CandidatosCHC.PerfilId == perfil.Id && 
                //        ae.CatalogoEtapasCHC.CaminoId == candidato.CaminoId && 
                //        ae.PorcentajeAvance < 100 )

                //let etapaActualCamino = _context.CatalogoEtapasCHC
                //    .Where(etapa => etapa.CaminoId == candidato.CaminoId)
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => avance != null && e.Id == avance.CatalogoEtapasCHC.Id)
                //?? _context.CatalogoEtapasCHC
                //    .Where(etapa => etapa.CaminoId == candidato.CaminoId)
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault( e => !_context.AvanceEtapasCandidato.Any(
                //        ae => ae.CandidatosCHC.PerfilId == perfil.Id && 
                //              ae.CatalogoEtapasCHC.Id == e.Id))
                where perfil.Guid == uuid
                select new
                {
                    usuarioPerfil.Id,
                    usuarioPerfil.UsuarioId,
                    usuarioPerfil.FechaCreacion,
                    perfil,
                    perfilesGrupales,
                    seguidores = seguidoresIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    siguiendo = siguiendoIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    seguidoresGrupales = seguidoresIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                .FirstOrDefault()
                        ),
                    siguiendoGrupales = siguiendoIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
                                .FirstOrDefault()
                        ),
                    perfilesEnCirculo,
                    voluntarios = voluntariosProgramas
                        .Select(vp =>
                            context.Voluntario
                                .Where(p => vp.VoluntarioId == p.Id)
                                .FirstOrDefault()
                        ),
                    voluntariosProgramas,
                    programas = programasResponsable
                        .Select(pr =>
                            context.Programa
                                .Where(p => pr.ProgramaId == p.Id)
                                .FirstOrDefault()
                        ),
                    tokens = perfilToken
                        .Select(pt =>
                            context.Token
                                .Where(t => pt.TokenId == t.Id)
                                .FirstOrDefault()
                        ),
                    perfilToken,
                    perfilCatalogoRedesSociales,
                    caminoCandidatoExists = false,
                    registroDatosFaltantesInicialExists = false,
                    etapaActualRegistro = new { },
                    etapaSiguienteRegistro = new { },
                    esInicioEtapaRegistro = false,
                    esUltimaEtapaRegistro = false,
                    etapasCompletasRegistro = false,
                    etapaActualCamino = new { },
                    avance = new { },
                    candidato = new { },
                };

            return query.FirstOrDefault() ?? new object();
        }

        [HttpGet("related/customUrl={customUrl}")]
        public object GetRelatedByCustomUrl(string customUrl)
        {
            var query = from perfilUsuario in context.Set<PerfilUsuario>()
                let perfil = context.Perfil
                    .Where(p => perfilUsuario.PerfilId == p.Id)
                    .FirstOrDefault()
                let perfilesUsuariosPerfilesGrupales = context.PerfilUsuarioPerfilGrupal
                    .Where(pupg => perfilUsuario.Id == pupg.PerfilUsuarioId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesGrupales = perfilesUsuariosPerfilesGrupales
                    .Select(upg =>
                        context.PerfilGrupal
                            .Where(pg => upg.PerfilGrupalId == pg.Id)
                            .FirstOrDefault()
                    )
                let siguiendoIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let siguiendoIdsGrupales = context.PerfilSiguePerfilGrupal
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIdsGrupales = context.PerfilGrupalSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesEnCirculo = context.PerfilSiguePerfil
                    .Where(psp => psp.PerfilSeguidoId == perfil.Id && psp.EnCirculo == true)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilToken = context.PerfilToken
                    .Where(pt => perfil.Id == pt.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()
                //let caminoCandidatoExists = _context.CandidatosCHC
                //    .Any(cc => perfil.Id == cc.PerfilId)

                //let candidato = _context.CandidatosCHC
                //    .Where(chc => perfil.Id == chc.PerfilId)
                //    .FirstOrDefault()

                //let registroDatosFaltantesInicialExists = _context.PerfilPersonaCHC
                //    .Any(ppc => perfil.Id == ppc.PerfilId)

                //let etapaActualRegistro = _context.CatalogoEtapaRegistroCHC
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => !_context.CandidatoEtapaRegistroCHC.Any(ce =>
                //        ce.CandidatosCHC.PerfilId == perfil.Id && ce.CatalogoEtapaRegistroCHC.Id == e.Id))

                //let etapaSiguienteRegistro = _context.CatalogoEtapaRegistroCHC
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => e.IndiceOrden > etapaActualRegistro.IndiceOrden)

                //let esInicioEtapaRegistro = etapaActualRegistro.IndiceOrden == 1

                //let esUltimaEtapaRegistro = etapaSiguienteRegistro == null

                //let etapasCompletasRegistro = !_context.CatalogoEtapaRegistroCHC
                //    .Any(e => !_context.CandidatoEtapaRegistroCHC.Any(ce =>
                //        ce.CandidatosCHC.PerfilId == perfil.Id && ce.CatalogoEtapaRegistroCHC.Id == e.Id))

                //let avance = _context.AvanceEtapasCandidato
                //    .FirstOrDefault(ae =>
                //        ae.CandidatosCHC.PerfilId == perfil.Id &&
                //        ae.CatalogoEtapasCHC.CaminoId == candidato.CaminoId &&
                //        ae.PorcentajeAvance < 100)

                //let etapaActualCamino = _context.CatalogoEtapasCHC
                //        .Where(etapa => etapa.CaminoId == candidato.CaminoId)
                //        .OrderBy(e => e.IndiceOrden)
                //        .FirstOrDefault(e => avance != null && e.Id == avance.CatalogoEtapasCHC.Id)
                //    ?? _context.CatalogoEtapasCHC
                //        .Where(etapa => etapa.CaminoId == candidato.CaminoId)
                //        .OrderBy(e => e.IndiceOrden)
                //        .FirstOrDefault(e => !_context.AvanceEtapasCandidato.Any(
                //            ae => ae.CandidatosCHC.PerfilId == perfil.Id &&
                //                  ae.CatalogoEtapasCHC.Id == e.Id))
                where perfil.CustomUrl == customUrl
                select new
                {
                    perfilUsuario.Id,
                    perfilUsuario.Name,
                    perfilUsuario.Email,
                    perfilUsuario.Area,
                    perfilUsuario.FechaCreacion,
                    perfil,
                    perfilesGrupales,
                    seguidores = seguidoresIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    siguiendo = siguiendoIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    seguidoresGrupales = seguidoresIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                .FirstOrDefault()
                        ),
                    siguiendoGrupales = siguiendoIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
                                .FirstOrDefault()
                        ),
                    tokens = perfilToken
                        .Select(pt =>
                            context.Token
                                .Where(t => pt.TokenId == t.Id)
                                .FirstOrDefault()
                        ),
                    perfilToken,
                    caminoCandidatoExists = false,
                    registroDatosFaltantesInicialExists = false,
                    etapaActualRegistro = new { },
                    etapaSiguienteRegistro = new { },
                    esInicioEtapaRegistro = false,
                    esUltimaEtapaRegistro = false,
                    etapasCompletasRegistro = false,
                    etapaActualCamino = new { },
                    avance = new { },
                    candidato = new { },
                };

            return query.FirstOrDefault();
        }

        [HttpGet("related/p/customUrl={customUrl}")]
        public object GetRelatedByPerfilCustomUrl(string customUrl)
        {
            var query = from usuarioPerfil in context.Set<UsuarioPerfil>()
                let perfil = context.Perfil
                    .Where(p => usuarioPerfil.PerfilId == p.Id)
                    .FirstOrDefault()
                let usuariosPerfilesGrupales = context.UsuarioPerfilGrupal
                    .Where(upg => usuarioPerfil.UsuarioId == upg.UsuarioId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesGrupales = usuariosPerfilesGrupales
                    .Select(upg =>
                        context.PerfilGrupal
                            .Where(pg => upg.PerfilGrupalId == pg.Id)
                            .FirstOrDefault()
                    )
                let siguiendoIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let siguiendoIdsGrupales = context.PerfilSiguePerfilGrupal
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIdsGrupales = context.PerfilGrupalSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesEnCirculo = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId && psp.EnCirculo == true)
                    .Join(
                        context.UsuarioPerfil,
                        psp => psp.PerfilSeguidoId,
                        up => up.PerfilId,
                        (psp, up) => new
                        {
                            psp.Id,
                            psp.PerfilSeguidoId,
                            psp.PerfilSeguido,
                            psp.PerfilSeguidorId,
                            psp.PerfilSeguidor,
                            psp.EnCirculo,
                            up.UsuarioId
                        }
                    )
                    .DefaultIfEmpty()
                    .ToList()
                let programasResponsable = context.ProgramaResponsable
                    .Where(p => usuarioPerfil.UsuarioId == p.ResponsableId)
                    .DefaultIfEmpty()
                    .ToList()
                let voluntariosProgramas = programasResponsable
                    .Select(pr =>
                        context.VoluntarioPrograma
                            .Where(vp => pr.ProgramaId == vp.ProgramaId)
                            .First()
                    )
                    .Where(pr => pr != null)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilToken = context.PerfilToken
                    .Where(pt => perfil.Id == pt.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilCatalogoRedesSociales = context.PerfilCatalogoRedesSociales
                    .Where(pcr => usuarioPerfil.PerfilId == pcr.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()

                //let caminoCandidatoExists = _context.CandidatosCHC
                //    .Any(cc => perfil.Id == cc.PerfilId)

                //let candidato = _context.CandidatosCHC
                //    .Where(chc => perfil.Id == chc.PerfilId)
                //    .FirstOrDefault()

                //let registroDatosFaltantesInicialExists = _context.PerfilPersonaCHC
                //    .Any(ppc => perfil.Id == ppc.PerfilId)

                //let etapaActualRegistro = _context.CatalogoEtapaRegistroCHC
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => !_context.CandidatoEtapaRegistroCHC.Any(ce =>
                //        ce.CandidatosCHC.PerfilId == perfil.Id && ce.CatalogoEtapaRegistroCHC.Id == e.Id))

                //let etapaSiguienteRegistro = _context.CatalogoEtapaRegistroCHC
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => e.IndiceOrden > etapaActualRegistro.IndiceOrden)

                //let esInicioEtapaRegistro = etapaActualRegistro.IndiceOrden == 1

                //let esUltimaEtapaRegistro = etapaSiguienteRegistro == null

                //let etapasCompletasRegistro = !_context.CatalogoEtapaRegistroCHC
                //    .Any(e => !_context.CandidatoEtapaRegistroCHC.Any(ce =>
                //        ce.CandidatosCHC.PerfilId == perfil.Id && ce.CatalogoEtapaRegistroCHC.Id == e.Id))

                //let avance = _context.AvanceEtapasCandidato
                //    .FirstOrDefault(ae =>
                //        ae.CandidatosCHC.PerfilId == perfil.Id &&
                //        ae.CatalogoEtapasCHC.CaminoId == candidato.CaminoId &&
                //        ae.PorcentajeAvance < 100)

                //let etapaActualCamino = _context.CatalogoEtapasCHC
                //    .Where(etapa => etapa.CaminoId == candidato.CaminoId)
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => avance != null && e.Id == avance.CatalogoEtapasCHC.Id)
                //?? _context.CatalogoEtapasCHC
                //    .Where(etapa => etapa.CaminoId == candidato.CaminoId)
                //    .OrderBy(e => e.IndiceOrden)
                //    .FirstOrDefault(e => !_context.AvanceEtapasCandidato.Any(
                //        ae => ae.CandidatosCHC.PerfilId == perfil.Id &&
                //              ae.CatalogoEtapasCHC.Id == e.Id))
                where perfil.CustomUrl == customUrl
                select new
                {
                    usuarioPerfil.Id,
                    usuarioPerfil.UsuarioId,
                    usuarioPerfil.FechaCreacion,
                    perfil,
                    perfilesGrupales,
                    seguidores = seguidoresIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    siguiendo = siguiendoIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    seguidoresGrupales = seguidoresIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                .FirstOrDefault()
                        ),
                    siguiendoGrupales = siguiendoIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
                                .FirstOrDefault()
                        ),
                    perfilesEnCirculo,
                    voluntarios = voluntariosProgramas
                        .Select(vp =>
                            context.Voluntario
                                .Where(p => vp.VoluntarioId == p.Id)
                                .FirstOrDefault()
                        ),
                    voluntariosProgramas,
                    programas = programasResponsable
                        .Select(pr =>
                            context.Programa
                                .Where(p => pr.ProgramaId == p.Id)
                                .FirstOrDefault()
                        ),
                    tokens = perfilToken
                        .Select(pt =>
                            context.Token
                                .Where(t => pt.TokenId == t.Id)
                                .FirstOrDefault()
                        ),
                    perfilToken,
                    perfilCatalogoRedesSociales,
                    caminoCandidatoExists = false,
                    registroDatosFaltantesInicialExists = false,
                    etapaActualRegistro = new { },
                    etapaSiguienteRegistro = new { },
                    esInicioEtapaRegistro = false,
                    esUltimaEtapaRegistro = false,
                    etapasCompletasRegistro = false,
                    etapaActualCamino = new { },
                    avance = new { },
                    candidato = new { },
                };

            return query.FirstOrDefault();
        }

        [HttpGet("validacionPerfil/uuid={uuid}")]
        public IActionResult ValidacionPerfil(Guid uuid)
        {
            var perfil = context.Perfil
                .FirstOrDefault(p => p.Guid == uuid);

            if (perfil == null)
            {
                return Ok(new
                {
                    existePerfil = false,
                    perfil = (object)null,
                });
            }

            return Ok(new { existePerfil = true, perfil, });
        }

        [HttpGet("related/u={id:int}")]
        public object GetRelatedByUsuario(int id)
        {
            var query = from usuarioPerfil in context.Set<UsuarioPerfil>()
                let perfil = context.Perfil
                    .Where(p => usuarioPerfil.PerfilId == p.Id)
                    .FirstOrDefault()
                let usuariosPerfilesGrupales = context.UsuarioPerfilGrupal
                    .Where(upg => usuarioPerfil.UsuarioId == upg.UsuarioId)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilesGrupales = usuariosPerfilesGrupales
                    .Select(upg =>
                        context.PerfilGrupal
                            .Where(pg => upg.PerfilGrupalId == pg.Id)
                            .FirstOrDefault()
                    )
                let siguiendoIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let siguiendoIdsGrupales = context.PerfilSiguePerfilGrupal
                    .Where(psp => perfil.Id == psp.PerfilSeguidorId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIds = context.PerfilSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let seguidoresIdsGrupales = context.PerfilGrupalSiguePerfil
                    .Where(psp => perfil.Id == psp.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()
                let programasResponsable = context.ProgramaResponsable
                    .Where(p => usuarioPerfil.UsuarioId == p.ResponsableId)
                    .DefaultIfEmpty()
                    .ToList()
                let voluntariosProgramas = programasResponsable
                    .Select(pr =>
                        context.VoluntarioPrograma
                            .Where(vp => pr.ProgramaId == vp.ProgramaId)
                            .First()
                    )
                    .Where(pr => pr != null)
                    .DefaultIfEmpty()
                    .ToList()
                let perfilToken = context.PerfilToken
                    .Where(pt => perfil.Id == pt.PerfilId)
                    .DefaultIfEmpty()
                    .ToList()

                //let caminoCandidatoExists = _context.CandidatosCHC
                //    .Any(cc => perfil.Id == cc.PerfilId)

                //let registroDatosFaltantesInicialExists = _context.PerfilPersonaCHC
                //    .Any(ppc => perfil.Id == ppc.PerfilId)

                //let caminoCandidato = _context.CandidatosCHC
                //    .Where(cc => perfil.Id == cc.PerfilId)
                //    .DefaultIfEmpty()
                //    .ToList()
                where usuarioPerfil.UsuarioId == id
                select new
                {
                    usuarioPerfil.Id,
                    usuarioPerfil.UsuarioId,
                    usuarioPerfil.FechaCreacion,
                    perfil,
                    perfilesGrupales,
                    seguidores = seguidoresIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    siguiendo = siguiendoIds
                        .Select(sp =>
                            context.Perfil
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
                            userData = context.UsuarioPerfil.Any(up => p.Id == up.PerfilId)
                                ? new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = true
                                }
                                : new
                                {
                                    usuarioPerfil = context.UsuarioPerfil.Where(up => p.Id == up.PerfilId).First(),
                                    perfilUsuario = context.PerfilUsuario.Where(pu => p.Id == pu.PerfilId).First(),
                                    isDashboard = false
                                }
                        }),
                    seguidoresGrupales = seguidoresIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidorId == p.Id)
                                .FirstOrDefault()
                        ),
                    siguiendoGrupales = siguiendoIdsGrupales
                        .Select(sp =>
                            context.PerfilGrupal
                                .Where(p => sp.PerfilGrupalSeguidoId == p.Id)
                                .FirstOrDefault()
                        ),
                    voluntarios = voluntariosProgramas
                        .Select(vp =>
                            context.Voluntario
                                .Where(p => vp.VoluntarioId == p.Id)
                                .FirstOrDefault()
                        ),
                    voluntariosProgramas,
                    programas = programasResponsable
                        .Select(pr =>
                            context.Programa
                                .Where(p => pr.ProgramaId == p.Id)
                                .FirstOrDefault()
                        ),
                    tokens = perfilToken
                        .Select(pt =>
                            context.Token
                                .Where(t => pt.TokenId == t.Id)
                                .FirstOrDefault()
                        ),
                    perfilToken,
                    InscritoCHC = /*caminoCandidatoExists*/ false,
                    RegistroDatosFaltantesInicial = /*registroDatosFaltantesInicialExists*/ false,
                    caminoCandidato = new { },
                };

            return query.FirstOrDefault();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Perfil>>> Get()
        {
            return await context.Perfil.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Perfil>> Get(int id)
        {
            var perfil = await context.Perfil.FindAsync(id);

            return perfil == null ? NotFound() : perfil;
        }

        [HttpPost]
        public async Task<ActionResult<Perfil>> Post(PerfilViewModel request)
        {
            Perfil perfil = mapper.Map<Perfil>(request);
            context.Perfil.Add(perfil);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfil.Id }, perfil);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, PerfilViewModel request)
        {
            var perfil = await context.Perfil.FindAsync(id);

            if (perfil == null)
            {
                return NotFound();
            }

            mapper.Map(request, perfil);

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return BadRequest(new { code = 23505 });
            }

            return CreatedAtAction("Get", new { id = perfil.Id }, perfil);
        }

        [HttpGet("for-settings/{id:int}")]
        public async Task<IActionResult> GetForSettings(int id)
        {
            var perfilWithDetails = await context.Perfil
                .Where(p => p.Id == id && p.Activo)
                .Select(p => new
                {
                    p.Id,
                    p.Activo,
                    p.Alias,
                    p.Descripcion,
                    p.esPublico,
                    p.FechaCreacion,
                    p.Guid,
                    p.CustomUrl,
                    p.Url,
                    RedesSociales = context.PerfilCatalogoRedesSociales
                        .Where(prs => prs.PerfilId == p.Id && prs.Activo)
                        .Join(context.CatalogoRedesSociales,
                            prs => prs.CatalogoRedesSocialesId,
                            redes => redes.Id,
                            (prs, redes) => new
                            {
                                redes.Id,
                                redes.Nombre,
                                prs.Activo,
                                prs.Url,
                                prs.CatalogoRedesSocialesId
                            })
                        .ToList(),
                    PerfilUsuario = context.PerfilUsuario
                        .FirstOrDefault(pu => pu.PerfilId == p.Id),
                    UsuarioPerfil = context.UsuarioPerfil
                        .FirstOrDefault(up => up.PerfilId == p.Id)
                })
                .FirstOrDefaultAsync();

            if (perfilWithDetails == null)
            {
                return NotFound();
            }

            return Ok(perfilWithDetails);
        }

        // datos meramente iniciales pre render,
        // hay que valorar varias veces si es necesario agregar algo extra aqui
        // y que no sea pre render pesado y ralentice la pagina
        [HttpGet("server-render")]
        public object ServerRender(
            //Ambos guid en string porque si se envia un guid malformado genera error
            [FromQuery] string? guid,
            [FromQuery] string? visitors_guid,
            [FromQuery] string? custom_url
        )
        {
            if (
                string.IsNullOrEmpty(guid) &&
                string.IsNullOrEmpty(custom_url)
            )
            {
                return BadRequest();
            }

            // Para saber si el que visita el perfil es alguien logueado
            bool isVisitor = string.IsNullOrEmpty(visitors_guid) == false;

            var query = from perfil in context.Set<Perfil>()

                        // se obtiene el perfil del visitante
                        let visitorsPerfil = context.Perfil
                            .Where(perfil => isVisitor && visitors_guid == perfil.Guid.ToString())
                            .FirstOrDefault()

                        // se obtiene el bool si el visitante es seguidor
                        let isFollowing = context.PerfilSiguePerfil
                            .Any(psp => perfil.Id == psp.PerfilSeguidoId && visitorsPerfil.Id == psp.PerfilSeguidorId)

                        // si viene con custom url entonces se busca por custom url
                        where string.IsNullOrEmpty(custom_url)
                            ? perfil.Guid.ToString() == guid
                            : perfil.CustomUrl == custom_url

                        where perfil.Activo == true

                        select new
                        {
                            perfil.Id,
                            perfil.Guid,
                            perfil.esPublico,
                            visitorsPerfil,
                            isFollowing,

                            isInvitedToPerformCircles = context.PerfilInvitacionCirculo
                                .Any(perfilInvitacion =>
                                    perfil.Id == perfilInvitacion.PerfilInvitadoId && perfilInvitacion.Activo
                                ),

                            hasPerfilCirculo = context.PerfilCirculo
                                .Any(perfilCirculo =>
                                    perfil.Id == perfilCirculo.PerfilId && perfilCirculo.Activo
                                ),

                            redesSociales = context.PerfilCatalogoRedesSociales
                                .Where(perfilRedSocial =>
                                    perfil.Id == perfilRedSocial.PerfilId
                                        && perfilRedSocial.Activo == true
                                        && (
                                            perfil.Id == visitorsPerfil.Id ||
                                            perfil.esPublico == true ||
                                            isVisitor
                                        )
                                )
                                .Select(perfilRedes =>
                                    new
                                    {
                                        id = perfilRedes.Id,
                                        url = perfilRedes.Url,
                                        activo = perfilRedes.Activo,
                                        redSocial = context.CatalogoRedesSociales
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

                            // aqui podria agregarse el count de firmas
                            // (si vemos que la pagina tarda mucho en renderizar)
                            // entonces lo hacemos por peticion asincrona
                            seguidoresCount =
                                context.PerfilSiguePerfil
                                    .Where(psp =>
                                        perfil.Id == psp.PerfilSeguidoId
                                        && perfil.esPublico == true)
                                    .ToList()
                                    .Count +
                                context.PerfilGrupalSiguePerfil
                                    .Where(psp =>
                                        perfil.Id == psp.PerfilSeguidoId
                                        && perfil.esPublico == true)
                                    .ToList()
                                    .Count, /* +
                                context.ApoyoPrecandidatura
                                    .Where(apoyo =>
                                        perfil.Id == apoyo.PerfilId
                                    )
                                    .ToList()
                                    .Count
                                */

                            // aqui se determina si el usuario pertence a dash o solo public
                            // esto mismo se puede aplicar a detalles de seguidores
                            userData = new
                            {
                                isDashboard = context.UsuarioPerfil.Any(up => perfil.Id == up.PerfilId),
                                usuarioPerfil = context.UsuarioPerfil
                                    .Where(up => perfil.Id == up.PerfilId)
                                    .Select(up =>
                                        new
                                        {
                                            id = up.Id,
                                            usuarioId = up.UsuarioId,
                                        }
                                    )
                                    .FirstOrDefault(),
                                perfilUsuario = context.PerfilUsuario
                                    .Where(pu => perfil.Id == pu.PerfilId)
                                    .Select(pu =>
                                        new
                                        {
                                            id = pu.Id,
                                            name = pu.Name,
                                            username = pu.Name,
                                            area = pu.Area,
                                            puesto = pu.Puesto,
                                            profileImage = pu.ProfileImage,
                                        }
                                    )
                                    .FirstOrDefault()
                            }
                        };

            if (query.Any() == false)
            {
                return NotFound();
            }

            return query.First();
        }
        
        // GET api/<PerfilUsuarioController>/5
        [HttpGet("{guid}")]
        public async Task<IActionResult> ObtenerPerfilesSeguidores(Guid guid)
        {
            var query = from psp in context.PerfilSiguePerfil
                join p in context.Perfil on psp.PerfilSeguidoId equals p.Id into perfilJoin
                from perfil in perfilJoin.DefaultIfEmpty()
                join p2 in context.Perfil on psp.PerfilSeguidorId equals p2.Id into perfil2Join
                from perfil2 in perfil2Join.DefaultIfEmpty()
                join pu in context.PerfilUsuario on psp.PerfilSeguidorId equals pu.PerfilId into perfilUsuarioJoin
                from perfilUsuario in perfilUsuarioJoin.DefaultIfEmpty()
                join up in context.UsuarioPerfil on psp.PerfilSeguidorId equals up.PerfilId into usuarioPerfilJoin
                from up in usuarioPerfilJoin.DefaultIfEmpty()
                where perfil.Guid == guid
                select new
                {
                    usuarioIdDashbord = up.UsuarioId,
                    nombre = perfilUsuario.Name,
                    correo = perfilUsuario.Email
                };

            var result = await query.ToListAsync();

            if (result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ChangeCandidatoStatus(int perfilId, bool statusCandidato)
        {
            // Check if the perfil exists
            var perfil = await context.Perfil.FindAsync(perfilId);
            if (perfil == null) return NotFound();
            
            // Change the status
            perfil.esCandidato = statusCandidato;
            context.Entry(perfil).State = EntityState.Modified;
            await context.SaveChangesAsync();
            
            return Ok();
        }

        [HttpGet("perfiles-circulo")]
        public object GetPerfilesCirculo(
            [FromQuery] string guid,
            [FromQuery] string? visitorsGuid
        )
        {
            if (string.IsNullOrEmpty(guid))
            {
                return BadRequest();
            }

            var query = from perfil in context.Set<Perfil>()

                        let visitorsPerfil = context.Perfil
                           .Where(perfil => visitorsGuid == perfil.Guid.ToString())
                           .FirstOrDefault()

                        let siguiendoPerfilesCirculo = context.PerfilSiguePerfil
                            .Where(perfilSiguePerfil =>
                                perfil.Id == perfilSiguePerfil.PerfilSeguidorId &&
                                perfilSiguePerfil.EnCirculo == true
                             )
                            .DefaultIfEmpty()
                            .ToList()

                        let perfilesCirculo = siguiendoPerfilesCirculo
                            .Select(perfilSiguePerfil =>
                                context.Perfil
                                    .Where(perfil =>
                                        perfilSiguePerfil.PerfilSeguidoId == perfil.Id &&
                                        perfil.Activo == true
                                    )
                                    .FirstOrDefault()
                            )
                            .DefaultIfEmpty()
                            .ToList()

                        where perfil.Guid.ToString() == guid
                        where perfil.Activo == true

                        select perfilesCirculo
                            .Select(perfil => new
                            {
                                perfil.Id,
                                perfil.Alias,
                                perfil.Guid,
                                perfil.CustomUrl,
                                perfil.Descripcion,
                                isFollowedByMe = context.PerfilSiguePerfil
                                    .Any(perfilSiguePerfil =>
                                        string.IsNullOrEmpty(visitorsGuid) == false
                                            && perfilSiguePerfil.PerfilSeguidorId == visitorsPerfil.Id
                                    ),
                                userData = new
                                {
                                    isDashboard = context.UsuarioPerfil.Any(up => perfil.Id == up.PerfilId),
                                    usuarioPerfil = context.UsuarioPerfil
                                        .Where(up => perfil.Id == up.PerfilId)
                                        .Select(up => new
                                        {
                                            up.Id,
                                            up.UsuarioId,
                                        })
                                        .FirstOrDefault(),
                                    perfilUsuario = context.PerfilUsuario
                                        .Where(pu => perfil.Id == pu.PerfilId)
                                        .Select(pu => new
                                        {
                                            pu.Id,
                                            pu.Name,
                                            pu.Area,
                                            pu.Puesto,
                                            pu.ProfileImage,
                                            username = pu.Name,
                                        })
                                        .FirstOrDefault()
                                }
                            })
                            .DefaultIfEmpty()
                            .ToList();

            var result = query.First();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("third-party-media-tokens")]
        public object GetThirdPartyMediaTokens(
            [FromQuery] string guid,
            [FromQuery] int? tokenType
        )
        {
            if (string.IsNullOrEmpty(guid))
            {
                return BadRequest();
            }

            var query = from perfil in context.Set<Perfil>()

                        let tokenIdList = context.PerfilToken
                            .Where(perfilToken =>
                                perfil.Id == perfilToken.PerfilId &&
                                perfilToken.Activo == true
                            )
                            .Select(perfilToken => perfilToken.TokenId)
                            .DefaultIfEmpty()
                            .ToList()

                        let tokens = tokenIdList
                            .Select(tokenId =>
                                context.Token
                                    .Where(token =>
                                        tokenType != null
                                            ? token.CatalogoTokenId == tokenType
                                            : true &&
                                        tokenId == token.Id &&
                                        token.Activo == true
                                     )
                                    .FirstOrDefault()
                            )
                            .DefaultIfEmpty()
                            .ToList()


                        where perfil.Guid.ToString() == guid
                        where perfil.Activo == true

                        select tokens.Select(token => new { token.StringifiedToken, token.CatalogoTokenId });

            var result = query.First();

            if (result.Any() == false)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("followers/search_by")]
        public object GetFollowersSearchBy(
            [FromQuery] string guid,
            [FromQuery] string? visitors_guid,
            [FromQuery] string? order_by,
            [FromQuery] int? limit,
            [FromQuery] int? skip
        )
        {
            if (string.IsNullOrEmpty(guid))
            {
                return BadRequest();
            }

            var seguidoresQuery = from perfil in context.Set<Perfil>()

                let visitorsPerfil = context.Perfil
                    .Where(perfil => visitors_guid == perfil.Guid.ToString())
                    .FirstOrDefault()

                let seguidores = context.PerfilSiguePerfil
                    .Where(perfilSiguePerfil => perfil.Id == perfilSiguePerfil.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()

                where perfil.Guid.ToString() == guid
                where perfil.Activo == true

                select seguidores
                    .Select(seguidor =>
                        context.Perfil
                            .Where(perfil =>
                                seguidor.PerfilSeguidorId == perfil.Id &&
                                perfil.Activo == true
                            )
                            .Select(perfil => new
                            {
                                isPerfilGrupal = false,
                                perfil.Alias,
                                Frase = (string?)"",
                                perfil.Guid,
                                perfil.CustomUrl,
                                perfil.Descripcion,
                                Foto = (string?)"",
                                isFollowedByMe = context.PerfilSiguePerfil
                                    .Any(perfilSiguePerfil =>
                                        string.IsNullOrEmpty(visitors_guid) == false
                                            && perfilSiguePerfil.PerfilSeguidorId == visitorsPerfil.Id
                                    ),
                                userData = new
                                {
                                    isDashboard = context.UsuarioPerfil.Any(up => perfil.Id == up.PerfilId),
                                    usuarioPerfil = context.UsuarioPerfil
                                        .Where(up => perfil.Id == up.PerfilId)
                                        .Select(up => new
                                        {
                                            up.Id,
                                            up.UsuarioId,
                                        })
                                        .FirstOrDefault(),
                                    perfilUsuario = context.PerfilUsuario
                                        .Where(pu => perfil.Id == pu.PerfilId)
                                        .Select(pu => new
                                        {
                                            pu.Id,
                                            pu.Name,
                                            pu.Area,
                                            pu.Puesto,
                                            pu.ProfileImage,
                                            username = pu.Name,
                                        })
                                        .FirstOrDefault()
                                }
                            })
                            .FirstOrDefault()
                    );

            var seguidoresGrupalesQuery = from perfil in context.Set<Perfil>()

                let visitorsPerfil = context.Perfil
                    .Where(perfil => visitors_guid == perfil.Guid.ToString())
                    .FirstOrDefault()

                let seguidoresGrupales = context.PerfilGrupalSiguePerfil
                    .Where(perfilGrupalSiguePerfil => perfil.Id == perfilGrupalSiguePerfil.PerfilSeguidoId)
                    .DefaultIfEmpty()
                    .ToList()

                where perfil.Guid.ToString() == guid
                where perfil.Activo == true

                select seguidoresGrupales
                    .Select(seguidor =>
                        context.PerfilGrupal
                            .Where(perfilGrupal =>
                                seguidor.PerfilGrupalSeguidorId == perfilGrupal.Id &&
                                perfilGrupal.Activo == true
                            )
                            .Select(perfil => new
                            {
                                isPerfilGrupal = true,
                                perfil.Alias,
                                perfil.Frase,
                                perfil.Guid,
                                perfil.CustomUrl,
                                Descripcion = (string?)"",
                                perfil.Foto,
                                isFollowedByMe = context.PerfilSiguePerfilGrupal
                                    .Any(perfilSiguePerfilGrupal =>
                                        string.IsNullOrEmpty(visitors_guid) == false
                                            && perfilSiguePerfilGrupal.PerfilSeguidorId == visitorsPerfil.Id
                                    ),
                                userData = new
                                {
                                    isDashboard = context.UsuarioPerfil.Any(up => perfil.Id == up.PerfilId),
                                    usuarioPerfil = context.UsuarioPerfil
                                        .Where(up => perfil.Id == up.PerfilId)
                                        .Select(up => new
                                        {
                                            up.Id,
                                            up.UsuarioId,
                                        })
                                        .FirstOrDefault(),
                                    perfilUsuario = context.PerfilUsuario
                                        .Where(pu => perfil.Id == pu.PerfilId)
                                        .Select(pu => new
                                        {
                                            pu.Id,
                                            pu.Name,
                                            pu.Area,
                                            pu.Puesto,
                                            pu.ProfileImage,
                                            username = pu.Name,
                                        })
                                        .FirstOrDefault()
                                }
                            })
                            .FirstOrDefault()
                    );

            if (!seguidoresQuery.Any() && !seguidoresGrupalesQuery.Any())
            {
                return NotFound();
            }

            // Made this ternary-operator-hell to avoid struggling with a
            // if else structure duplicating return statements due to allSeguidores type and its scope
            var allSeguidores = seguidoresQuery.Any() && seguidoresGrupalesQuery.Any()
                ? seguidoresQuery
                    .First()
                    .Concat(
                        seguidoresGrupalesQuery.First()
                    )
                : !seguidoresQuery.Any()
                    ? seguidoresGrupalesQuery.First()
                    : seguidoresQuery.First();

            allSeguidores = allSeguidores.OrderBy(seguidor => seguidor.Alias);

            if (allSeguidores.Count() < limit)
            {
                return allSeguidores;
            }

            return allSeguidores
                .Skip(skip ?? 0)
                .Take(limit ?? 5);
        }

        [HttpGet("following/search_by")]
        public object GetFollowingSearchBy(
            [FromQuery] string guid,
            [FromQuery] string? visitors_guid,
            [FromQuery] string? order_by,
            [FromQuery] int? limit,
            [FromQuery] int? skip
        )
        {
            if (string.IsNullOrEmpty(guid))
            {
                return BadRequest();
            }

            var siguiendoQuery = from perfil in context.Set<Perfil>()

                                  let visitorsPerfil = context.Perfil
                                      .Where(perfil => visitors_guid == perfil.Guid.ToString())
                                      .FirstOrDefault()

                                  let siguiendo = context.PerfilSiguePerfil
                                      .Where(perfilSiguePerfil => perfil.Id == perfilSiguePerfil.PerfilSeguidorId)
                                      .DefaultIfEmpty()
                                      .ToList()

                                  where perfil.Guid.ToString() == guid
                                  where perfil.Activo == true

                                  select siguiendo
                                      .Select(seguidor =>
                                          context.Perfil
                                              .Where(perfil =>
                                                  seguidor.PerfilSeguidoId == perfil.Id &&
                                                  perfil.Activo == true
                                              )
                                              .Select(perfil => new
                                              {
                                                  isPerfilGrupal = false,
                                                  perfil.Alias,
                                                  Frase = (string?)"",
                                                  perfil.Guid,
                                                  perfil.CustomUrl,
                                                  perfil.Descripcion,
                                                  Foto = (string?)"",
                                                  isFollowedByMe = context.PerfilSiguePerfil
                                                      .Any(perfilSiguePerfil =>
                                                          string.IsNullOrEmpty(visitors_guid) == false
                                                              && perfilSiguePerfil.PerfilSeguidorId == visitorsPerfil.Id
                                                      ),
                                                  userData = new
                                                  {
                                                      isDashboard = context.UsuarioPerfil.Any(up => perfil.Id == up.PerfilId),
                                                      usuarioPerfil = context.UsuarioPerfil
                                                          .Where(up => perfil.Id == up.PerfilId)
                                                          .Select(up => new
                                                          {
                                                              up.Id,
                                                              up.UsuarioId,
                                                          })
                                                          .FirstOrDefault(),
                                                      perfilUsuario = context.PerfilUsuario
                                                          .Where(pu => perfil.Id == pu.PerfilId)
                                                          .Select(pu => new
                                                          {
                                                              pu.Id,
                                                              pu.Name,
                                                              pu.Area,
                                                              pu.Puesto,
                                                              pu.ProfileImage,
                                                              username = pu.Name,
                                                          })
                                                          .FirstOrDefault()
                                                  }
                                              })
                                              .FirstOrDefault()
                                      );

            var siguiendoGrupalesQuery = from perfil in context.Set<Perfil>()

                                          let visitorsPerfil = context.Perfil
                                              .Where(perfil => visitors_guid == perfil.Guid.ToString())
                                              .FirstOrDefault()

                                          let siguiendoGrupales = context.PerfilSiguePerfilGrupal
                                              .Where(perfilSiguePerfilGrupal => perfil.Id == perfilSiguePerfilGrupal.PerfilSeguidorId)
                                              .DefaultIfEmpty()
                                              .ToList()

                                          where perfil.Guid.ToString() == guid
                                          where perfil.Activo == true

                                          select siguiendoGrupales
                                              .Select(seguidor =>
                                                  context.PerfilGrupal
                                                      .Where(perfilGrupal =>
                                                          seguidor.PerfilGrupalSeguidoId == perfilGrupal.Id &&
                                                          perfilGrupal.Activo == true
                                                      )
                                                      .Select(perfil => new
                                                      {
                                                          isPerfilGrupal = true,
                                                          perfil.Alias,
                                                          perfil.Frase,
                                                          perfil.Guid,
                                                          perfil.CustomUrl,
                                                          Descripcion = (string?)"",
                                                          perfil.Foto,
                                                          isFollowedByMe = context.PerfilSiguePerfilGrupal
                                                              .Any(perfilSiguePerfilGrupal =>
                                                                  string.IsNullOrEmpty(visitors_guid) == false
                                                                      && perfilSiguePerfilGrupal.PerfilSeguidorId == visitorsPerfil.Id
                                                              ),
                                                          userData = new
                                                          {
                                                              isDashboard = context.UsuarioPerfil.Any(up => perfil.Id == up.PerfilId),
                                                              usuarioPerfil = context.UsuarioPerfil
                                                                  .Where(up => perfil.Id == up.PerfilId)
                                                                  .Select(up => new
                                                                  {
                                                                      up.Id,
                                                                      up.UsuarioId,
                                                                  })
                                                                  .FirstOrDefault(),
                                                              perfilUsuario = context.PerfilUsuario
                                                                  .Where(pu => perfil.Id == pu.PerfilId)
                                                                  .Select(pu => new
                                                                  {
                                                                      pu.Id,
                                                                      pu.Name,
                                                                      pu.Area,
                                                                      pu.Puesto,
                                                                      pu.ProfileImage,
                                                                      username = pu.Name,
                                                                  })
                                                                  .FirstOrDefault()
                                                          }
                                                      })
                                                      .FirstOrDefault()
                                              );

            if (!siguiendoQuery.Any() && !siguiendoGrupalesQuery.Any())
            {
                return NotFound();
            }

            // Made this ternary-operator-hell to avoid struggling with a
            // if else structure duplicating return statements due to allSeguidores type and its scope
            var allSiguiendo = siguiendoQuery.Any() && siguiendoGrupalesQuery.Any()
                ? siguiendoQuery
                    .First()
                    .Concat(
                        siguiendoGrupalesQuery.First()
                    )
                : !siguiendoQuery.Any()
                    ? siguiendoGrupalesQuery.First()
                    : siguiendoQuery.First();

            allSiguiendo = allSiguiendo.OrderBy(siguiendo => siguiendo.Alias);

            if (allSiguiendo.Count() < limit)
            {
                return allSiguiendo;
            }

            return allSiguiendo
                .Skip(skip ?? 0)
                .Take(limit ?? 5);
        }

        public class MetadataDto
        {
            public required int PerfilId { get; set; }

            public int? EntidadFederativaId { get; set; }

            public required int GeneroId { get; set; }

            public int? EscolaridadId { get; set; }

            public int[]? InteresIdList { get; set; } = [];
            
            public required string Nombre { get; set; }

            public required string ApellidoPaterno { get; set; }

            public string? ApellidoMaterno { get; set; } = default!;

            public string? Seudonimo { get; set; } = default!;

            public DateTime? FechaNacimiento { get; set; }

            public string? CorreoElectronico { get; set; } = default!;

            public int TiempoResidencia { get; set; } = 0;

            public string? TelefonoParticular { get; set; } = default!;

            public string? FirmaElectronica { get; set; } = default!;

            public string? Curp { get; set; } = default!;

            public string? Rfc { get; set; } = default!;

            public string? ClaveElector { get; set; } = default!;
        }

        [HttpPut("metadata")]
        public async Task<IActionResult> PutMetadata(
            [FromQuery] int perfil_id,
            MetadataDto request
        )
        {
            if (perfil_id == 0)
            {
                return BadRequest();
            }

            bool hasMatch = context.PerfilPersona
                .Any(perfilPersona => perfil_id == perfilPersona.PerfilId);

            using (
                var dbContextTransaction = context.Database.BeginTransaction()
            )
            {
                try
                {
                    if (!hasMatch)
                    {
                        Persona nuevaPersona = new Persona
                        {
                            Nombre = request.Nombre,
                            ApellidoPaterno = request.ApellidoPaterno,
                            ApellidoMaterno = request.ApellidoMaterno,
                            Seudonimo = request.Seudonimo,
                            GeneroId = request.GeneroId,
                            EntidadFederativaId = request.EntidadFederativaId,
                            Curp = request.Curp,
                            ClaveElector = request.ClaveElector,
                            FechaNacimiento = request.FechaNacimiento,
                            TelefonoParticular = request.TelefonoParticular,
                        };

                        context.Persona.Add(nuevaPersona);
                        await context.SaveChangesAsync();

                        foreach (int interesId in request.InteresIdList ?? [])
                        {
                            PersonaInteres nuevaPersonaInteres = new PersonaInteres
                            {
                                PersonaId = nuevaPersona.Id,
                                InteresId = interesId,
                            };

                            context.PersonaInteres.Add(nuevaPersonaInteres);
                            await context.SaveChangesAsync();
                        }

                        await dbContextTransaction.CommitAsync();
                        return NoContent();
                    }

                    var perfilPersona = await context.PerfilPersona
                            .Where(perfilPersona => perfil_id == perfilPersona.PerfilId)
                            .FirstOrDefaultAsync();

                    var persona = await context.Persona
                        .Where(persona => perfilPersona != null
                            && perfilPersona.PersonaId == persona.Id
                        )
                        .FirstOrDefaultAsync();

                    if (persona == null)
                    {
                        return NotFound();
                    }

                    persona.Nombre = request.Nombre;
                    persona.ApellidoPaterno = request.ApellidoPaterno;
                    persona.ApellidoMaterno = request.ApellidoMaterno;
                    persona.Seudonimo = request.Seudonimo;
                    persona.GeneroId = request.GeneroId;
                    persona.EntidadFederativaId = request.EntidadFederativaId;
                    persona.Curp = request.Curp;
                    persona.ClaveElector = request.ClaveElector;
                    persona.FechaNacimiento = request.FechaNacimiento;
                    persona.TelefonoParticular = request.TelefonoParticular;

                    context.Persona.Update(persona);
                    await context.SaveChangesAsync();

                    var personaInteresList = await context.PersonaInteres
                        .Where(personaInteres => persona.Id == personaInteres.PersonaId)
                        .DefaultIfEmpty()
                        .ToListAsync();

                    foreach (var personaInteres in personaInteresList)
                    {
                        if (personaInteres == null)
                        {
                            continue;
                        }

                        context.PersonaInteres.Remove(personaInteres);
                        await context.SaveChangesAsync();
                    }

                    foreach (int interesId in request.InteresIdList ?? [])
                    {
                        PersonaInteres nuevaPersonaInteres = new PersonaInteres
                        {
                            PersonaId = persona.Id,
                            InteresId = interesId,
                        };

                        context.PersonaInteres.Add(nuevaPersonaInteres);
                        await context.SaveChangesAsync();
                    }

                    await dbContextTransaction.CommitAsync();
                    return NoContent();
                }
                catch (Exception e)
                {
                    await dbContextTransaction.RollbackAsync();
                    return BadRequest();
                }
            }
        }

        [HttpPost("follow")]
        public async Task<IActionResult> PostFollow(
            [FromQuery] string guid,
            [FromQuery] string visitors_guid,
            [FromQuery] string? isGrupal
        )
        {
            bool isBadRequest = string.IsNullOrEmpty(guid)
                || string.IsNullOrEmpty(visitors_guid)
                || visitors_guid == guid;

            if (isBadRequest)
            {
                return BadRequest();
            }

            var perfil = await context.Perfil
                .Where(perfil => guid == perfil.Guid.ToString())
                .FirstOrDefaultAsync();

            if (perfil == null)
            {
                return NotFound();
            }

            // It tries to get matching profiles
            var perfilMatching = string.IsNullOrEmpty(isGrupal) == false
                ? await context.PerfilGrupal
                    .Where(perfilGrupal => visitors_guid == perfilGrupal.Guid.ToString())
                    .Select(perfilGrupal => new
                    {
                        perfilGrupal.Id,
                        IsGrupal = true
                    })
                    .FirstOrDefaultAsync()
                : await context.Perfil
                    .Where(perfil => visitors_guid == perfil.Guid.ToString())
                    .Select(perfil => new
                    {
                        perfil.Id,
                        IsGrupal = false
                    })
                    .FirstOrDefaultAsync();

            if (perfilMatching == null)
            {
                return NotFound();
            }

            bool isRepeated = perfilMatching.IsGrupal
                ? await context.PerfilGrupalSiguePerfil
                    .AnyAsync(perfilGrupalSiguePerfil =>
                        perfilMatching.Id == perfilGrupalSiguePerfil.PerfilGrupalSeguidorId
                            && perfil.Id == perfilGrupalSiguePerfil.PerfilSeguidoId
                    )
                : await context.PerfilSiguePerfil
                    .AnyAsync(perfilSiguePerfil =>
                        perfilMatching.Id == perfilSiguePerfil.PerfilSeguidorId
                            && perfil.Id == perfilSiguePerfil.PerfilSeguidoId
                    );

            if (isRepeated)
            {
                return NoContent();
            }

            PerfilSiguePerfilViewModel perfilSiguePerfilVW = new PerfilSiguePerfilViewModel
            {
                PerfilSeguidoId = perfil.Id,
                PerfilSeguidorId = perfilMatching.Id
            };

            PerfilSiguePerfil perfilSiguePerfil = mapper.Map<PerfilSiguePerfil>(perfilSiguePerfilVW);
            context.PerfilSiguePerfil.Add(perfilSiguePerfil);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilSiguePerfil.Id }, perfilSiguePerfil);
        }

        [HttpGet("resume")]
        public async Task<IActionResult> GetResume()
        {
            var perfiles = await context.Perfil
                .Select(perfil => new
                {
                    perfil.Id,
                    nombre = perfil.Alias,
                    //perfil.Descripcion,
                    //userData = new
                    //{
                    //    isDashboard = context.UsuarioPerfil.Any(up => perfil.Id == up.PerfilId),
                    //    usuarioPerfil = context.UsuarioPerfil
                    //    .Where(up => perfil.Id == up.PerfilId)
                    //    .Select(up =>
                    //        new
                    //        {
                    //            id = up.Id,
                    //            usuarioId = up.UsuarioId,
                    //        }
                    //    )
                    //    .FirstOrDefault(),
                    //    perfilUsuario = context.PerfilUsuario
                    //    .Where(pu => perfil.Id == pu.PerfilId)
                    //    .Select(pu =>
                    //        new
                    //        {
                    //            id = pu.Id,
                    //            name = pu.Name,
                    //            username = pu.Name,
                    //            area = pu.Area,
                    //            puesto = pu.Puesto,
                    //            profileImage = pu.ProfileImage,
                    //        }
                    //    )
                    //    .FirstOrDefault()
                    //}
                })
                .DefaultIfEmpty()
                .ToListAsync();

            return Ok(perfiles);
        }

        [HttpGet("is-invited-to-perform-circles")]
        public async Task<IActionResult> isInvitedToPerformCircles(string guid)
        {
            var perfil = await context.Perfil
                .Where(perfil =>
                    !string.IsNullOrEmpty(guid)
                        && guid == perfil.Guid.ToString()
                )
                .FirstOrDefaultAsync();

            if (perfil == null)
            {
                return NotFound();
            }

            return Ok(await context.PerfilInvitacionCirculo
                .AnyAsync(perfilInvitacion =>
                    perfil.Id == perfilInvitacion.PerfilInvitadoId && perfilInvitacion.Activo
                )
            );
        }

        [HttpGet("has-perfil-circulo")]
        public async Task<IActionResult> hasPerfilCirculo(string guid)
        {
            var perfil = await context.Perfil
                .Where(perfil =>
                    !string.IsNullOrEmpty(guid)
                        && guid == perfil.Guid.ToString()
                )
                .FirstOrDefaultAsync();

            if (perfil == null)
            {
                return NotFound();
            }

            return Ok(await context.PerfilCirculo
                .AnyAsync(perfilCirculo =>
                    perfil.Id == perfilCirculo.PerfilId && perfilCirculo.Activo
                )
            );
        }
    }
}