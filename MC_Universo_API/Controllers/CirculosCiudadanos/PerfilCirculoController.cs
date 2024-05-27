using AutoMapper;
using DocumentFormat.OpenXml.InkML;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.CirculosCiudadanos;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels.CirculosCiudadanos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CirculosCiudadanos;

[Route("api/[controller]")]
[ApiController]
public class PerfilCirculoController(UniversoContext context, IMapper mapper) : ControllerBase
{
    // GET: api/<PerfilCirculoController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PerfilCirculo>>> Get()
    {
        return await context.PerfilCirculo.ToListAsync();
    }

    // GET: api/<PerfilCirculoController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<PerfilCirculo>> Get(int id)
    {
        var perfilCirculo = await context.PerfilCirculo.FindAsync(id);

        return perfilCirculo == null ? NotFound() : perfilCirculo;
    }

    // POST: api/<PerfilCirculoController>
    [HttpPost]
    public async Task<ActionResult<PerfilCirculo>> Post(PerfilCirculoViewModel request)
    {
        PerfilCirculo perfilCirculo = mapper.Map<PerfilCirculo>(request);
        context.PerfilCirculo.Add(perfilCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = perfilCirculo.Id }, perfilCirculo);
    }

    // PUT: api/<PerfilCirculoController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, PerfilCirculoViewModel request)
    {
        var perfilCirculo = await context.PerfilCirculo.FindAsync(id);

        if (perfilCirculo == null)
        {
            return NotFound();
        }

        mapper.Map(request, perfilCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = perfilCirculo.Id }, perfilCirculo);
    }

    // DELETE: api/<PerfilCirculoController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var perfilCirculo = await context.PerfilCirculo.FindAsync(id);

        if (perfilCirculo == null)
        {
            return NotFound();
        }

        context.PerfilCirculo.Remove(perfilCirculo);
        await context.SaveChangesAsync();

        return Ok();
    }

    // PUT: api/<PerfilCirculoController>/disable/5
    [HttpPut("disable/{id}")]
    public async Task<IActionResult> Disable(
        int id,
        [FromQuery] int? update_user_id
    )
    {
        var perfilCirculo = await context.PerfilCirculo.FindAsync(id);

        if (perfilCirculo == null)
        {
            return NotFound();
        }

        perfilCirculo.Activo = false;
        perfilCirculo.FechaModificacion = DateTime.UtcNow;
        perfilCirculo.UsuarioModificacionId = update_user_id ?? 2;
        await context.SaveChangesAsync();

        return Ok();
    }

    [HttpGet("resume")]
    public async Task<IActionResult> GetResume(
        [FromQuery] string? guid,
        [FromQuery] string? order_by,
        [FromQuery] int? limit,
        [FromQuery] int? skip
    )
    {
        var perfil = await context.Perfil
            .Where(perfil => string.IsNullOrEmpty(guid) == false && guid == perfil.Guid.ToString())
            .FirstOrDefaultAsync();

        if (perfil == null)
        {
            return NotFound();
        }

        var perfilesCirculos = await context.PerfilCirculo
            .Where(perfilCirculo => perfilCirculo.Activo && perfil.Id == perfilCirculo.PerfilId)
            .DefaultIfEmpty()
            .ToListAsync();

        var result = new List<object>();

        foreach (var perfilCirculo in perfilesCirculos)
        {
            if (perfilCirculo == null)
            {
                continue;
            }

            var circulo = await context.Circulo
                .Where(circulo => perfilCirculo.CirculoId == circulo.Id)
                .FirstOrDefaultAsync();

            var ultimoHistorico = await context.HistoricoEstatusCirculo
                .Where(historicoEstatus => circulo != null && circulo.EstatusActualHistoricoCirculoId == historicoEstatus.Id)
                .FirstOrDefaultAsync();

            var estatus = await context.CatalogoEstatusCirculo
                .Where(estatus => ultimoHistorico != null && ultimoHistorico.EstatusNuevoId == estatus.Id)
                .FirstOrDefaultAsync();

            var perfilFundador = await context.Perfil
                .Where(perfil => circulo != null && circulo.PerfilFundadorId == perfil.Id)
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

            var perfiles = new List<object>();

            var perfilesList = await context.Perfil
                .Where(perfil => perfilCirculo.PerfilId == perfil.Id && perfil.Activo == true)
                .DefaultIfEmpty()
                .ToListAsync();

            foreach (var perfilList in perfilesList)
            {
                if (perfilList == null)
                {
                    continue;
                }

                var userData = new
                {
                    perfil = perfilList,
                    perfilUserData = new
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
                    }
                };

                perfiles.Add(userData);
            }

            result.Add(new
            {
                circulo,
                estatus,
                perfiles,
                perfilFundador,
                perfilFundadorUserData
            });
        }

        return Ok(result);
    }

    public class PerfilCirculoTransactionDto
    {
        public bool HasPerfil { get; set; }
        public int PerfilId { get; set; }
        public int CirculoId { get; set; }
        public List<int>? CheckinsList { get; set; }
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
    public async Task<ActionResult<Circulo>> PostTransactionForPerfilCirculo(PerfilCirculoTransactionDto request)
    {
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
                //    perfilPersona.PerfilId == (request.HasPerfil ? request.PerfilId : perfil.Id)
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
                //        PerfilId = request.HasPerfil ? request.PerfilId : perfil.Id,
                //        PersonaId = persona.Id,
                //    };
                //    context.PerfilPersona.Add(perfilPersona);
                //    await context.SaveChangesAsync();
                //}

                PerfilCirculo perfilCirculo = new PerfilCirculo
                {
                    PerfilId = request.HasPerfil ? request.PerfilId : perfil.Id,
                    CirculoId = request.CirculoId,
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
                        perfilRed.PerfilId == (request.HasPerfil ? request.PerfilId : perfil.Id) &&
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
                        PerfilId = request.HasPerfil ? request.PerfilId : perfil.Id,
                        CatalogoRedesSocialesId = 1,
                        Url = request.LigaFacebook,
                    };
                    context.PerfilCatalogoRedesSociales.Add(perfilFacebook);
                    await context.SaveChangesAsync();
                }

                bool hasTwitter = await context.PerfilCatalogoRedesSociales
                    .AnyAsync(perfilRed =>
                        perfilRed.PerfilId == (request.HasPerfil ? request.PerfilId : perfil.Id) &&
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
                        PerfilId = request.HasPerfil ? request.PerfilId : perfil.Id,
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
                        CedulaRegistroCheckIns cedulaRegistroCheckIns = new CedulaRegistroCheckIns
                        {
                            PerfilCirculoId = perfilCirculo.Id,
                            CheckInId = checkin,
                            IsAccepted = true
                        };

                        context.CedulaRegistroCheckIns.Add(cedulaRegistroCheckIns);
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

                return Ok(request.CheckinsList);
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

    [HttpGet("by-perfil")]
    public async Task<IActionResult> GetByPerfil(
        [FromQuery] string guid
    )
    {
        if (string.IsNullOrEmpty(guid))
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

        var perfilesCirculos = await context.PerfilCirculo
            .Where(perfilCirculo => perfil.Id == perfilCirculo.PerfilId)
            .DefaultIfEmpty()
            .ToListAsync();

        if (!perfilesCirculos.Any())
        {
            return Ok(new List<int>());
        }

        var result = new List<object>();

        foreach (var perfilCirculo in perfilesCirculos)
        {
            if (perfilCirculo == null)
            {
                continue;
            }

            var circulo = await context.Circulo
                .Where(circulo => perfilCirculo.CirculoId == circulo.Id)
                .FirstOrDefaultAsync();

            var fundador = await context.Perfil
                .Where(perfil => circulo != null && circulo.PerfilFundadorId == perfil.Id)
                .FirstOrDefaultAsync();

            var fundadorUserData = new
            {
                perfil = fundador,
                perfilUserData = new
                {
                    isDashboard = await context.UsuarioPerfil.AnyAsync(up => fundador != null && fundador.Id == up.PerfilId),
                    usuarioPerfil = await context.UsuarioPerfil
                        .Where(up => fundador != null && fundador.Id == up.PerfilId)
                        .Select(up =>
                            new
                            {
                                id = up != null ? up.Id : 0,
                                usuarioId = up != null ? up.UsuarioId : 0,
                            }
                        )
                        .FirstOrDefaultAsync(),
                    perfilUsuario = await context.PerfilUsuario
                        .Where(pu => fundador != null && fundador.Id == pu.PerfilId)
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
                }
            };

            var estatusHistorico = await context.HistoricoEstatusCirculo
                .Where(historico => circulo != null && circulo.EstatusActualHistoricoCirculoId == historico.Id)
                .FirstOrDefaultAsync();

            var estatus = await context.CatalogoEstatusCirculo
                .Where(estatus => estatusHistorico != null && estatusHistorico.EstatusNuevoId == estatus.Id)
                .FirstOrDefaultAsync();

            var perfilesCirculo = await context.PerfilCirculo
                .Where(perfilCirculo => circulo != null && circulo.Id == perfilCirculo.CirculoId)
                .DefaultIfEmpty()
                .Take(5)
                .ToListAsync();

            var miembros = new List<Perfil>();
            foreach (var perfilCirculoItem in perfilesCirculo)
            {
                var miembro = await context.Perfil
                    .Where(perfil => perfilCirculoItem != null && perfilCirculoItem.PerfilId == perfil.Id)
                    .FirstOrDefaultAsync();
                
                if (miembro != null)
                {
                    miembros.Add(miembro);
                }
            }

            var miembrosUserData = new List<object>();

            foreach (var miembro in miembros)
            {
                if (miembro == null)
                {
                    continue;
                }

                var userData = new
                {
                    perfil = miembro,
                    perfilUserData = new
                    {
                        isDashboard = await context.UsuarioPerfil.AnyAsync(up => miembro.Id == up.PerfilId),
                        usuarioPerfil = await context.UsuarioPerfil
                            .Where(up => miembro.Id == up.PerfilId)
                            .Select(up =>
                                new
                                {
                                    id = up != null ? up.Id : 0,
                                    usuarioId = up != null ? up.UsuarioId : 0,
                                }
                            )
                            .FirstOrDefaultAsync(),
                        perfilUsuario = await context.PerfilUsuario
                            .Where(pu => miembro.Id == pu.PerfilId)
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
                    }
                };

                miembrosUserData.Add(userData);
            }

            var circuloCausas = await context.CirculoCausa
                .Where(circuloCausa => circulo != null && circulo.Id == circuloCausa.CirculoId)
                .DefaultIfEmpty()
                .ToListAsync();

            var causas = new List<Causa>();
            foreach (var circuloCausa in circuloCausas)
            {
                var causa = await context.Causa
                    .Where(causa => circuloCausa != null && circuloCausa.CausaId == causa.Id)
                    .FirstOrDefaultAsync();

                if (causa != null)
                {
                    causas.Add(causa);
                }
            }

            result.Add(new
            {
                circulo,
                fundadorUserData,
                estatus,
                miembrosUserData,
                causas,
            });
        }

        return Ok(result);
    }

    [HttpGet("by-link")]
    public async Task<IActionResult> GetByLink(
        [FromQuery] string guid
    )
    {
        if (string.IsNullOrEmpty(guid))
        {
            return BadRequest();
        }

        var circulo = await context.Circulo
                .Where(circulo => guid == circulo.LigaInvitacion)
                .FirstOrDefaultAsync();

        var fundador = await context.Perfil
            .Where(perfil => circulo != null && circulo.PerfilFundadorId == perfil.Id)
            .FirstOrDefaultAsync();

        /*var fundadorPersona = await context.PerfilPersona
            .Where()*/

        var fundadorUserData = new
        {
            perfil = fundador,
            perfilUserData = new
            {
                isDashboard = await context.UsuarioPerfil.AnyAsync(up => fundador != null && fundador.Id == up.PerfilId),
                usuarioPerfil = await context.UsuarioPerfil
                    .Where(up => fundador != null && fundador.Id == up.PerfilId)
                    .Select(up =>
                        new
                        {
                            id = up != null ? up.Id : 0,
                            usuarioId = up != null ? up.UsuarioId : 0,
                        }
                    )
                    .FirstOrDefaultAsync(),
                perfilUsuario = await context.PerfilUsuario
                    .Where(pu => fundador != null && fundador.Id == pu.PerfilId)
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
            }
        };

        var estatusHistorico = await context.HistoricoEstatusCirculo
            .Where(historico => circulo != null && circulo.EstatusActualHistoricoCirculoId == historico.Id)
            .FirstOrDefaultAsync();

        var estatus = await context.CatalogoEstatusCirculo
            .Where(estatus => estatusHistorico != null && estatusHistorico.EstatusNuevoId == estatus.Id)
            .FirstOrDefaultAsync();

        var perfilesCirculo = await context.PerfilCirculo
            .Where(perfilCirculo => circulo != null && circulo.Id == perfilCirculo.CirculoId)
            .DefaultIfEmpty()
            .Take(5)
            .ToListAsync();

        var miembros = new List<Perfil>();
        foreach (var perfilCirculoItem in perfilesCirculo)
        {
            var miembro = await context.Perfil
                .Where(perfil => perfilCirculoItem != null && perfilCirculoItem.PerfilId == perfil.Id)
                .FirstOrDefaultAsync();

            if (miembro != null)
            {
                miembros.Add(miembro);
            }
        }

        var miembrosUserData = new List<object>();
        foreach (var miembro in miembros)
        {
            if (miembro == null)
            {
                continue;
            }

            var userData = new
            {
                perfil = miembro,
                perfilUserData = new
                {
                    isDashboard = await context.UsuarioPerfil.AnyAsync(up => miembro.Id == up.PerfilId),
                    usuarioPerfil = await context.UsuarioPerfil
                        .Where(up => miembro.Id == up.PerfilId)
                        .Select(up =>
                            new
                            {
                                id = up != null ? up.Id : 0,
                                usuarioId = up != null ? up.UsuarioId : 0,
                            }
                        )
                        .FirstOrDefaultAsync(),
                    perfilUsuario = await context.PerfilUsuario
                        .Where(pu => miembro.Id == pu.PerfilId)
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
                }
            };

            miembrosUserData.Add(userData);
        }

        var circuloCausas = await context.CirculoCausa
            .Where(circuloCausa => circulo != null && circulo.Id == circuloCausa.CirculoId)
            .DefaultIfEmpty()
            .ToListAsync();

        var causas = new List<Causa>();
        foreach (var circuloCausa in circuloCausas)
        {
            var causa = await context.Causa
                .Where(causa => circuloCausa != null && circuloCausa.CausaId == causa.Id)
                .FirstOrDefaultAsync();

            if (causa != null)
            {
                causas.Add(causa);
            }
        }

        return Ok(new
        {
            circulo,
            fundadorUserData,
            estatus,
            miembrosUserData,
            causas,
        });
    }
}
