using AutoMapper;
using DocumentFormat.OpenXml.InkML;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.AccionesAfirmativas;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.Models.CirculosCiudadanos;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels.AccionesAfirmativas;
using MC_Universo_API.ViewModels.CirculosCiudadanos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Server.Circuits;
using System.Net.NetworkInformation;
using Microsoft.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CirculosCiudadanos;

[Route("api/[controller]")]
[ApiController]
public class CirculoController(UniversoContext context, IMapper mapper) : ControllerBase
{
    // GET: api/<CirculoController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Circulo>>> Get()
    {
        return await context.Circulo.ToListAsync();
    }

    // GET: api/<CirculoController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Circulo>> Get(int id)
    {
        var circulo = await context.Circulo.FindAsync(id);

        return circulo == null ? NotFound() : circulo;
    }

    // POST: api/<CirculoController>
    [HttpPost]
    public async Task<ActionResult<Circulo>> Post(CirculoViewModel request)
    {
        Circulo circulo = mapper.Map<Circulo>(request);
        context.Circulo.Add(circulo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = circulo.Id }, circulo);
    }

    // PUT: api/<CirculoController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, CirculoViewModel request)
    {
        var circulo = await context.Circulo.FindAsync(id);

        if (circulo == null)
        {
            return NotFound();
        }

        mapper.Map(request, circulo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = circulo.Id }, circulo);
    }

    // DELETE: api/<CirculoController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var circulo = await context.Circulo.FindAsync(id);

        if (circulo == null)
        {
            return NotFound();
        }

        context.Circulo.Remove(circulo);
        await context.SaveChangesAsync();

        return Ok();
    }

    // PUT: api/<CirculoController>/disable/5
    [HttpPut("disable/{id}")]
    public async Task<IActionResult> Disable(
        int id,
        [FromQuery] int? update_user_id
    )
    {
        var circulo = await context.Circulo.FindAsync(id);

        if (circulo == null)
        {
            return NotFound();
        }

        circulo.Activo = false;
        circulo.FechaModificacion = DateTime.UtcNow;
        circulo.UsuarioModificacionId = update_user_id ?? 2;
        await context.SaveChangesAsync();

        return Ok();
    }

    [HttpGet("resume")]
    public async Task<IActionResult> GetResume(
        [FromQuery] string? order_by,
        [FromQuery] int? limit,
        [FromQuery] int? skip
    )
    {
        List<Circulo> circulos = await context.Circulo
            .Where(circulo => circulo.Activo)
            .ToListAsync();

        //var result = await circulos
        //    .ToAsyncEnumerable()
        //    .SelectAwait(async circulo =>
        //        new
        //        {
        //            circulo.Id,
        //            circulo.Nombre,
        //            circulo.Descripcion,
        //            circulo.LigaInvitacion,
        //            circulo.FechaCreacion,
        //            Estado = await context.EntidadFederativa
        //                .Where(entidad => circulo.EntidadFederativaId == entidad.Id)
        //                .Select(entidad => new
        //                {
        //                    entidad.Id,
        //                    entidad.Nombre
        //                })
        //                .FirstOrDefaultAsync(),
        //            Estatus = await context.HistoricoEstatusCirculo
        //                .ToAsyncEnumerable()
        //                .Where(historicoEstatus => circulo.EstatusActualHistoricoCirculoId == historicoEstatus.Id)
        //                .SelectAwait(async historico =>
        //                    await context.CatalogoEstatusCirculo
        //                        .Where(catalogo => historico.EstatusNuevoId == catalogo.Id)
        //                        .Select(catalogo => catalogo.Nombre)
        //                        .FirstOrDefaultAsync()
        //                )
        //                .FirstOrDefaultAsync(),
        //            PerfilFundador = await context.Perfil
        //                .ToAsyncEnumerable()
        //                .Where(perfil => circulo.PerfilFundadorId == perfil.Id)
        //                .SelectAwait(async perfilFundador => new
        //                    {
        //                        perfilFundador.Id,
        //                        perfilFundador.Guid,
        //                        perfilFundador.Alias,
        //                        isDashboard = await context.UsuarioPerfil.AnyAsync(up => perfilFundador.Id == up.PerfilId),
        //                        usuarioPerfil = await context.UsuarioPerfil
        //                                .Where(up => perfilFundador.Id == up.PerfilId)
        //                                .Select(up =>
        //                                    new
        //                                    {
        //                                        up.Id,
        //                                        up.UsuarioId,
        //                                    }
        //                                )
        //                                .FirstOrDefaultAsync(),
        //                        perfilUsuario = await context.PerfilUsuario
        //                                .Where(pu => perfilFundador.Id == pu.PerfilId)
        //                                .Select(pu =>
        //                                    new
        //                                    {
        //                                        pu.Id,
        //                                        pu.Name,
        //                                        username = pu.Name,
        //                                        pu.Area,
        //                                        pu.Puesto,
        //                                        pu.ProfileImage,
        //                                    }
        //                                )
        //                                .FirstOrDefaultAsync()
        //                    }
        //                )
        //                .FirstOrDefaultAsync()
        //        }
        //    )
        //    .ToListAsync();

        var result = new List<object>();

        foreach (var circulo in circulos)
        {
            if (circulo == null)
            {
                continue;
            }

            var entidadFederativa = await context.EntidadFederativa
                .Where(entidadFederativa => circulo.EntidadFederativaId == entidadFederativa.Id)
                .FirstOrDefaultAsync();

            var ultimoHistorico = await context.HistoricoEstatusCirculo
                .Where(historicoEstatus => circulo.EstatusActualHistoricoCirculoId == historicoEstatus.Id)
                .FirstOrDefaultAsync();

            var estatus = await context.CatalogoEstatusCirculo
                .Where(estatus => ultimoHistorico != null && ultimoHistorico.EstatusNuevoId == estatus.Id)
                .FirstOrDefaultAsync();

            var conteoParticipantes = await context.PerfilCirculo
                .Where(perfilCirculo =>
                    circulo.Id == perfilCirculo.CirculoId
                        && perfilCirculo.Activo
                )
                .CountAsync();

            var perfilFundador = await context.Perfil
                .Where(perfil => circulo.PerfilFundadorId == perfil.Id)
                .FirstOrDefaultAsync();

            var perfilFundadorUserData = new
            {
                isDashboard = await context.UsuarioPerfil.AnyAsync(up => perfilFundador != null && perfilFundador.Id == up.PerfilId),
                usuarioPerfil = await context.UsuarioPerfil
                    .Where(up => perfilFundador != null && perfilFundador.Id == up.PerfilId)
                    .Select(up =>
                        new
                        {
                            id = up != null ? up.Id : 0,
                            usuarioId = up != null ? up.UsuarioId : 0,
                        }
                    )
                    .FirstOrDefaultAsync(),
                perfilUsuario = await context.PerfilUsuario
                    .Where(pu => perfilFundador != null && perfilFundador.Id == pu.PerfilId)
                    .Select(pu =>
                        new
                        {
                            id = pu != null ? pu.Id : 0,
                            name = pu != null ? pu.Name : "",
                            username = pu != null ? pu.Name : "",
                            area = pu != null ? pu.Area : "",
                            puesto = pu != null ? pu.Puesto : "",
                            profileImage = pu != null ? pu.ProfileImage : "",
                        }
                    )
                    .FirstOrDefaultAsync()
            };

            result.Add(new
            {
                circulo.Id,
                circulo.Nombre,
                circulo.Descripcion,
                circulo.LigaInvitacion,
                circulo.FechaCreacion,
                Estado = entidadFederativa != null ? entidadFederativa.Nombre : "",
                Estatus = estatus != null ? estatus.Nombre : "",
                Comentario = ultimoHistorico != null ? ultimoHistorico.ComentarioEstatus : "",
                conteoParticipantes,
                perfilFundador,
                perfilFundadorUserData
            });
        }

        return Ok(result);
        //var query = from circulo in context.Set<Circulo>()

        //            let entidadFederativa = context.EntidadFederativa
        //                .Where(entidadFederativa => circulo.EntidadFederativaId == entidadFederativa.Id)
        //                .FirstOrDefault()

        //            let ultimoHistorico = context.HistoricoEstatusCirculo
        //                .Where(historicoEstatus => circulo.EstatusActualHistoricoCirculoId == historicoEstatus.Id)
        //                .FirstOrDefault()

        //            let estatus = context.CatalogoEstatusCirculo
        //                .Where(estatus => ultimoHistorico.EstatusNuevoId == estatus.Id)
        //                .FirstOrDefault()

        //            let conteoParticipantes = context.PerfilCirculo
        //                .Where(perfilCirculo =>
        //                    circulo.Id == perfilCirculo.CirculoId
        //                        && perfilCirculo.Activo
        //                )
        //                .Count()

        //            let perfilesCirculo = context.PerfilCirculo
        //                .Where(perfilCirculo =>
        //                    circulo.Id == perfilCirculo.CirculoId
        //                        && perfilCirculo.Activo
        //                )
        //                .DefaultIfEmpty()
        //                .ToList()

        //            let algunosParticipantesPerfiles = perfilesCirculo
        //                .Select(perfilCirculo =>
        //                    context.UsuarioPerfil
        //                        .Where(usuarioPerfil => perfilCirculo.PerfilId == usuarioPerfil.PerfilId)
        //                        .Select(usuarioPerfil => new
        //                        {
        //                            usuarioPerfil.Id,
        //                            usuarioPerfil.UsuarioId,
        //                            perfilData = context.Perfil
        //                                .Where(perfil => usuarioPerfil.PerfilId == perfil.Id)
        //                                .FirstOrDefault()
        //                        })
        //                        .FirstOrDefault()
        //                )
        //                .DefaultIfEmpty()
        //                .ToList()

        //            let perfilFundador = context.Perfil
        //                .Where(perfil => circulo.PerfilFundadorId == perfil.Id)
        //                .Select(perfil => new
        //                {
        //                    perfil.Id,
        //                    perfil.Guid,
        //                    perfil.Alias,
        //                    userData = new
        //                    {
        //                        isDashboard = context.UsuarioPerfil.Any(up => perfil.Id == up.PerfilId),
        //                        usuarioPerfil = context.UsuarioPerfil
        //                            .Where(up => perfil.Id == up.PerfilId)
        //                            .Select(up =>
        //                                new
        //                                {
        //                                    id = up.Id,
        //                                    usuarioId = up.UsuarioId,
        //                                }
        //                            )
        //                            .FirstOrDefault(),
        //                        perfilUsuario = context.PerfilUsuario
        //                            .Where(pu => perfil.Id == pu.PerfilId)
        //                            .Select(pu =>
        //                                new
        //                                {
        //                                    id = pu.Id,
        //                                    name = pu.Name,
        //                                    username = pu.Name,
        //                                    area = pu.Area,
        //                                    puesto = pu.Puesto,
        //                                    profileImage = pu.ProfileImage,
        //                                }
        //                            )
        //                            .FirstOrDefault()
        //                    }
        //                })
        //                .FirstOrDefault()

        //            where circulo.Activo

        //            select new
        //            {
        //                circulo.Id,
        //                circulo.Nombre,
        //                circulo.Descripcion,
        //                circulo.LigaInvitacion,
        //                circulo.FechaCreacion,
        //                perfilFundador,
        //                Estado = entidadFederativa.Nombre,
        //                Estatus = estatus.Nombre,
        //                Comentario = ultimoHistorico.ComentarioEstatus,
        //                ConteoParticipantes = conteoParticipantes,
        //                Participantes = algunosParticipantesPerfiles
        //            };

        //return Ok();
    }

    // This method allows create a new row being new circulo inserted
    public class CirculoTransactionDto
    {
        public bool HasPerfil { get; set; }
        public int PerfilFundadorId { get; set; }
        public int? EstatusActualHistoricoCirculoId { get; set; }
        public int? EntidadFederativaCirculoId { get; set; }
        public List<int>? CheckinsList { get; set; }
        public required string Nombre { get; set; }
        public string? Folio {  get; set; }
        public string? Descripcion { get; set; }
        public string? Direccion { get; set; }
        public bool PuedeGenerarInvitacion { get; set; } = true;
        public required string NombrePersonal { get; set; }
        public required string PrimerApellido { get; set; }
        public required string SegundoApellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public required int EntidadFederativaId { get; set; }
        public required int GeneroId { get; set; }
        public string? Calle { get; set; }
        public string? NoExterior { get; set; }
        public string? NoInterior { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Colonia { get; set; }
        public string? Municipio { get; set; }
        public string? Celular { get; set; }
        public int MovilSistemaOperativo { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? Cargo { get; set; }
        public required string Email { get; set; } //can be empty string for existing perfil
        public required string Password { get; set; } //can be empty string for existing perfil
        public string? LigaFacebook { get; set; }
        public string? LigaTwitter { get; set; }
        public string? ClaveElector { get; set; }
        public string? ClaveMunicipio { get; set; }
        public string? SeccionElectoral { get; set; }
        public string? Curp { get; set; }
        public string? Localidad { get; set; }
        public string? Firma { get; set; }
        public bool IsAvisoAceptado { get; set; }
    }

    [HttpPost("transaction")]
    public async Task<ActionResult<Circulo>> PostTransactionForPerfilCirculo(CirculoTransactionDto request)
    {
        Guid refGuid = Guid.NewGuid();

        using (var transaction = context.Database.BeginTransaction())
        {
            try
            {
                Perfil perfil = new Perfil
                {
                    Alias = request.NombrePersonal + " " + request.PrimerApellido + " " + request.SegundoApellido,
                    Url = request.NombrePersonal + "-" + request.PrimerApellido + "-" + request.SegundoApellido,
                };

                if (!request.HasPerfil)
                {
                    context.Perfil.Add(perfil);
                    await context.SaveChangesAsync();

                    PerfilUsuario perfilUsuario = new PerfilUsuario
                    {
                        PerfilId = perfil.Id,
                        Name = perfil.Alias,
                        Email = request.Email,
                        Password = request.Password,
                        Puesto = request.Cargo ?? "",
                    };
                    context.PerfilUsuario.Add(perfilUsuario);
                    await context.SaveChangesAsync();
                }

                //bool isAnyPersona = await context.PerfilPersona.AnyAsync(perfilPersona =>
                //    perfilPersona.PerfilId == (request.HasPerfil ? request.PerfilFundadorId : perfil.Id)
                //);

                //if (!request.HasPerfil || !isAnyPersona)
                //{
                //    Persona persona = new Persona
                //    {
                //        Nombre = request.NombrePersonal,
                //        ApellidoPaterno = request.PrimerApellido,
                //        ApellidoMaterno = request.SegundoApellido,
                //        FechaNacimiento = request.FechaNacimiento,
                //        EntidadFederativaId = request.EntidadFederativaId,
                //        GeneroId = request.GeneroId,
                //        CorreoElectronico = request.Email,
                //        TiempoResidencia = 0,
                //        TelefonoParticular = request.Celular,
                //        ClaveElector = request.ClaveElector,
                //    };
                //    context.Persona.Add(persona);
                //    await context.SaveChangesAsync();

                //    PerfilPersona perfilPersona = new PerfilPersona
                //    {
                //        PerfilId = request.HasPerfil ? request.PerfilFundadorId : perfil.Id,
                //        PersonaId = persona.Id,
                //    };
                //    context.PerfilPersona.Add(perfilPersona);
                //    await context.SaveChangesAsync();
                //}

                HistoricoEstatusCirculo historicoEstatusCirculo = new HistoricoEstatusCirculo
                {
                    EstatusAnteriorId = 1,
                    EstatusNuevoId = 1,
                };
                context.HistoricoEstatusCirculo.Add(historicoEstatusCirculo);
                await context.SaveChangesAsync();

                Circulo circulo = new Circulo
                {
                    PerfilFundadorId = request.HasPerfil ? request.PerfilFundadorId : perfil.Id,
                    EstatusActualHistoricoCirculoId = historicoEstatusCirculo.Id,
                    EntidadFederativaId = request.EntidadFederativaId,
                    Nombre = request.Nombre,
                    Direccion = request.Direccion,
                    Folio = request.Folio,
                    GuidInvitacion = refGuid,
                    LigaInvitacion = refGuid
                        .ToString()
                        .Split("-")
                        .First()
                };
                context.Circulo.Add(circulo);
                await context.SaveChangesAsync();

                PerfilCirculo perfilCirculo = new PerfilCirculo
                {
                    PerfilId = request.HasPerfil ? request.PerfilFundadorId : perfil.Id,
                    CirculoId = circulo.Id,
                    PuedeGenerarInvitacion = true,
                    Nombre = request.NombrePersonal,
                    PrimerApellido = request.PrimerApellido,
                    SegundoApellido = request.SegundoApellido,
                    EntidadFederativaId = request.EntidadFederativaId,
                    GeneroId = request.GeneroId,
                    Calle = request.Calle,
                    NoExterior = request.NoExterior,
                    NoInterior = request.NoInterior,
                    CodigoPostal = request.CodigoPostal,
                    Colonia = request.Colonia,
                    Municipio = request.Municipio,
                    Celular = request.Celular,
                    MovilSistemaOperativo = request.MovilSistemaOperativo,
                    TelefonoFijo = request.TelefonoFijo,
                    Cargo = request.Cargo,
                    Email = request.Email,
                    LigaFacebook = request.LigaFacebook,
                    LigaTwitter = request.LigaTwitter,
                    ClaveElector = request.ClaveElector,
                    ClaveMunicipio = request.ClaveMunicipio,
                    SeccionElectoral = request.SeccionElectoral,
                    Curp = request.Curp,
                    Localidad = request.Localidad,
                    Firma = request.Firma,
                    IsAvisoAceptado = request.IsAvisoAceptado
                };
                context.PerfilCirculo.Add(perfilCirculo);
                await context.SaveChangesAsync();

                bool hasFacebook = await context.PerfilCatalogoRedesSociales
                    .AnyAsync(perfilRed =>
                        perfilRed.PerfilId == (request.HasPerfil ? request.PerfilFundadorId : perfil.Id) &&
                        perfilRed.CatalogoRedesSocialesId == 1 &&
                        !string.IsNullOrEmpty(perfilRed.Url)
                    );

                if (
                    !string.IsNullOrEmpty(request.LigaFacebook) &&
                    (
                        !request.HasPerfil ||
                        !hasFacebook
                    )
                )
                {
                    PerfilCatalogoRedesSociales perfilFacebook = new PerfilCatalogoRedesSociales
                    {
                        PerfilId = request.HasPerfil ? request.PerfilFundadorId : perfil.Id,
                        CatalogoRedesSocialesId = 1,
                        Url = request.LigaFacebook,
                    };
                    context.PerfilCatalogoRedesSociales.Add(perfilFacebook);
                    await context.SaveChangesAsync();
                }

                bool hasTwitter = await context.PerfilCatalogoRedesSociales
                    .AnyAsync(perfilRed =>
                        perfilRed.PerfilId == (request.HasPerfil ? request.PerfilFundadorId : perfil.Id) &&
                        perfilRed.CatalogoRedesSocialesId == 3 &&
                        !string.IsNullOrEmpty(perfilRed.Url)
                    );

                if (
                    !string.IsNullOrEmpty(request.LigaTwitter) &&
                    (
                        !request.HasPerfil ||
                        !hasTwitter
                    )
                )
                {
                    PerfilCatalogoRedesSociales perfilTwitter = new PerfilCatalogoRedesSociales
                    {
                        PerfilId = request.HasPerfil ? request.PerfilFundadorId : perfil.Id,
                        CatalogoRedesSocialesId = 3,
                        Url = request.LigaTwitter,
                    };
                    context.PerfilCatalogoRedesSociales.Add(perfilTwitter);
                    await context.SaveChangesAsync();
                }

                if (request.CheckinsList != null)
                {
                    foreach (var checkin in request.CheckinsList)
                    {
                        CedulaRegistroCheckIns cedulaRegistroCheckIn = new CedulaRegistroCheckIns
                        {
                            PerfilCirculoId = perfilCirculo.Id,
                            CheckInId = checkin,
                            IsAccepted = true
                        };

                        context.CedulaRegistroCheckIns.Add(cedulaRegistroCheckIn);
                        await context.SaveChangesAsync();
                    }
                }
                
                await transaction.CommitAsync();
                var response = new ApiResponse<string>
                {
                    Success = true,
                    StatusCode = 200,
                    Message = "Datos Enviados",
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                var errorResponse = new ApiResponse<string>()
                {
                    StatusCode = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                    Success = false
                };
                return BadRequest(errorResponse);
            }
        }
    }

    // GET: api/<CirculoController>/5
    [HttpGet("circulo")]
    public async Task<IActionResult> GetCedula(
        [FromQuery] string? invitacion
    )
    {
        //Do not change this to Any() method, circulo is needed to be send through response
        var circulo = await context.Circulo
            .Where(circulo =>
                string.IsNullOrEmpty(invitacion) == false &&
                invitacion == circulo.LigaInvitacion &&
                circulo.Activo
            )
            .FirstOrDefaultAsync();

        if (circulo == null)
        {
            return NotFound();
        }

        var perfil = await context.Perfil
            .Where(perfil =>
                circulo.PerfilFundadorId == perfil.Id &&
                perfil.Activo
            )
            .FirstOrDefaultAsync();

        return Ok(new
        {
            circulo,
            perfil
        });
    }

    public class CirculoHistoricoTransactionDto
    {
        public int EstatusNuevoHistoricoCirculoId { get; set; }
        public string? ComentarioEstatus { get; set; }
    }

    [HttpPut("historico")]
    public async Task<IActionResult> PutHistorico(
        CirculoHistoricoTransactionDto request,
        [FromQuery] string guid
    )
    {
        if (string.IsNullOrEmpty(guid))
        {
            return BadRequest();
        }

        var circulo = await context.Circulo
            .Where(circulo => guid == circulo.GuidInvitacion.ToString())
            .FirstOrDefaultAsync();

        if (circulo == null)
        {
            return NotFound();
        }

        var estatusHistorico = await context.HistoricoEstatusCirculo
            .Where(historico => circulo.EstatusActualHistoricoCirculoId == historico.Id)
            .FirstOrDefaultAsync();

        using (var transaction = context.Database.BeginTransaction())
        {
            try
            {
                var nuevoRegistroHistorico = new HistoricoEstatusCirculo
                {
                    EstatusNuevoId = request.EstatusNuevoHistoricoCirculoId,
                    EstatusAnteriorId = estatusHistorico != null ? estatusHistorico.EstatusNuevoId : 1,
                    ComentarioEstatus = request.ComentarioEstatus
                };
                context.HistoricoEstatusCirculo.Add(nuevoRegistroHistorico);
                await context.SaveChangesAsync();

                circulo.EstatusActualHistoricoCirculoId = nuevoRegistroHistorico.Id;
                circulo.FechaModificacion = DateTime.UtcNow;
                context.Circulo.Update(circulo);
                await context.SaveChangesAsync();

                await transaction.CommitAsync();
                var response = new ApiResponse<string>
                {
                    Success = true,
                    StatusCode = 200,
                    Message = "Datos Enviados",
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                var errorResponse = new ApiResponse<string>()
                {
                    StatusCode = 500,
                    Message = ex.InnerException.Message,
                    Success = false
                };
                return BadRequest(errorResponse);
            }
        }
    }

    public class CausaDto
    {
        public required List<int> causasId { get; set; }
    }
    [HttpPost("create-acta")]
    public async Task<IActionResult> PostCreatActa(
        CausaDto request,
        [FromQuery] string guid
    )
    {
        if (string.IsNullOrEmpty(guid))
        {
            return BadRequest();
        }

        var circulo = await context.Circulo
            .Where(circulo => guid == circulo.GuidInvitacion.ToString())
            .FirstOrDefaultAsync();

        if (circulo == null)
        {
            return NotFound();
        }

        var estatusHistorico = await context.HistoricoEstatusCirculo
            .Where(historico => circulo.EstatusActualHistoricoCirculoId == historico.Id)
            .FirstOrDefaultAsync();

        using (var transaction = context.Database.BeginTransaction())
        {
            try
            {
                foreach (var causaId in request.causasId)
                {
                    var circuloCausa = new CirculoCausa
                    {
                        CirculoId = circulo.Id,
                        CausaId = causaId,
                    };

                    context.CirculoCausa.Add(circuloCausa);
                    await context.SaveChangesAsync();
                }

                var nuevoRegistroHistorico = new HistoricoEstatusCirculo
                {
                    EstatusNuevoId = 2,
                    EstatusAnteriorId = estatusHistorico != null ? estatusHistorico.EstatusNuevoId : 1,
                    ComentarioEstatus = null
                };
                context.HistoricoEstatusCirculo.Add(nuevoRegistroHistorico);
                await context.SaveChangesAsync();

                circulo.EstatusActualHistoricoCirculoId = nuevoRegistroHistorico.Id;
                circulo.FechaModificacion = DateTime.UtcNow;
                context.Circulo.Update(circulo);
                await context.SaveChangesAsync();

                await transaction.CommitAsync();
                var response = new ApiResponse<string>
                {
                    Success = true,
                    StatusCode = 200,
                    Message = "Datos Enviados",
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                var errorResponse = new ApiResponse<string>()
                {
                    StatusCode = 500,
                    Message = ex.InnerException.Message,
                    Success = false
                };
                return BadRequest(errorResponse);
            }
        }
    }

    [HttpGet("resume/{id}")]
    public async Task<IActionResult> GetResumeById(int id)
    {
        var circulo = await context.Circulo.FindAsync(id);

        if (circulo == null)
        {
            return NotFound();
        }

        var entidadFederativa = await context.EntidadFederativa
            .Where(entidadFederativa => circulo.EntidadFederativaId == entidadFederativa.Id)
            .FirstOrDefaultAsync();

        var ultimoHistorico = await context.HistoricoEstatusCirculo
            .Where(historicoEstatus => circulo.EstatusActualHistoricoCirculoId == historicoEstatus.Id)
            .FirstOrDefaultAsync();

        var estatus = await context.CatalogoEstatusCirculo
            .Where(estatus => ultimoHistorico != null && ultimoHistorico.EstatusNuevoId == estatus.Id)
            .FirstOrDefaultAsync();

        var conteoParticipantes = await context.PerfilCirculo
            .Where(perfilCirculo =>
                circulo.Id == perfilCirculo.CirculoId
                    && perfilCirculo.Activo
            )
            .CountAsync();

        var perfilFundador = await context.Perfil
            .Where(perfil => circulo.PerfilFundadorId == perfil.Id)
            .FirstOrDefaultAsync();

        var perfilFundadorUserData = new
        {
            isDashboard = await context.UsuarioPerfil.AnyAsync(up => perfilFundador != null && perfilFundador.Id == up.PerfilId),
            usuarioPerfil = await context.UsuarioPerfil
                .Where(up => perfilFundador != null && perfilFundador.Id == up.PerfilId)
                .Select(up =>
                    new
                    {
                        id = up != null ? up.Id : 0,
                        usuarioId = up != null ? up.UsuarioId : 0,
                    }
                )
                .FirstOrDefaultAsync(),
            perfilUsuario = await context.PerfilUsuario
                .Where(pu => perfilFundador != null && perfilFundador.Id == pu.PerfilId)
                .Select(pu =>
                    new
                    {
                        id = pu != null ? pu.Id : 0,
                        name = pu != null ? pu.Name : "",
                        username = pu != null ? pu.Name : "",
                        area = pu != null ? pu.Area : "",
                        puesto = pu != null ? pu.Puesto : "",
                        profileImage = pu != null ? pu.ProfileImage : "",
                    }
                )
                .FirstOrDefaultAsync()
        };

        return Ok(new
        {
            circulo.Id,
            circulo.GuidInvitacion,
            circulo.Nombre,
            circulo.Descripcion,
            circulo.LigaInvitacion,
            circulo.FechaCreacion,
            circulo.Folio,
            Estado = entidadFederativa != null ? entidadFederativa.Nombre : "",
            Estatus = estatus != null ? estatus.Nombre : "",
            EstatusId = estatus != null ? estatus.Id : 1,
            Comentario = ultimoHistorico != null ? ultimoHistorico.ComentarioEstatus : "",
            conteoParticipantes,
            perfilFundador,
            perfilFundadorUserData
        });
    }
}
