using AutoMapper;
using DocumentFormat.OpenXml.InkML;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CirculosCiudadanos;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels.CirculosCiudadanos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CirculosCiudadanos;

[Route("api/[controller]")]
[ApiController]
public class PerfilInvitacionCirculoController(UniversoContext context, IMapper mapper) : ControllerBase
{
    // GET: api/<PerfilInvitacionCirculoController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PerfilInvitacionCirculo>>> Get()
    {
        return await context.PerfilInvitacionCirculo.ToListAsync();
    }

    // GET: api/<PerfilInvitacionCirculoController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<PerfilInvitacionCirculo>> Get(int id)
    {
        var perfilInvitacionCirculo = await context.PerfilInvitacionCirculo.FindAsync(id);

        return perfilInvitacionCirculo == null ? NotFound() : perfilInvitacionCirculo;
    }

    // POST: api/<PerfilInvitacionCirculoController>
    [HttpPost]
    public async Task<ActionResult<PerfilInvitacionCirculo>> Post(PerfilInvitacionCirculoViewModel request)
    {
        bool isRepeated = context.PerfilInvitacionCirculo
            .Any(invitacion =>
                request.PerfilAnfitrionId == invitacion.PerfilAnfitrionId &&
                request.PerfilInvitadoId == invitacion.PerfilInvitadoId
            );

        if (isRepeated)
        {
            ApiResponse<string> errorResponse = new ApiResponse<string>()
            {
                StatusCode = 400,
                Message = "Invitación repetida",
                Success = false
            };
            return BadRequest(errorResponse);
        }

        PerfilInvitacionCirculo perfilInvitacionCirculo = mapper.Map<PerfilInvitacionCirculo>(request);
        context.PerfilInvitacionCirculo.Add(perfilInvitacionCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = perfilInvitacionCirculo.Id }, perfilInvitacionCirculo);
    }

    // PUT: api/<PerfilInvitacionCirculoController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, PerfilInvitacionCirculoViewModel request)
    {
        var perfilInvitacionCirculo = await context.PerfilInvitacionCirculo.FindAsync(id);

        if (perfilInvitacionCirculo == null)
        {
            return NotFound();
        }

        bool isRepeated = context.PerfilInvitacionCirculo
            .Any(invitacion =>
                request.PerfilAnfitrionId == invitacion.PerfilAnfitrionId &&
                request.PerfilInvitadoId == invitacion.PerfilInvitadoId
            );

        if (isRepeated)
        {
            ApiResponse<string> errorResponse = new ApiResponse<string>()
            {
                StatusCode = 400,
                Message = "Invitación repetida",
                Success = false
            };
            return BadRequest(errorResponse);
        }

        mapper.Map(request, perfilInvitacionCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = perfilInvitacionCirculo.Id }, perfilInvitacionCirculo);
    }

    // DELETE: api/<PerfilInvitacionCirculoController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var perfilInvitacionCirculo = await context.PerfilInvitacionCirculo.FindAsync(id);

        if (perfilInvitacionCirculo == null)
        {
            return NotFound();
        }

        context.PerfilInvitacionCirculo.Remove(perfilInvitacionCirculo);
        await context.SaveChangesAsync();

        return Ok();
    }

    // PUT: api/<PerfilInvitacionCirculoController>/disable/5
    [HttpPut("disable/{id}")]
    public async Task<IActionResult> Disable(
        int id,
        [FromQuery] int? update_user_id
    )
    {
        var perfilInvitacionCirculo = await context.PerfilInvitacionCirculo.FindAsync(id);

        if (perfilInvitacionCirculo == null)
        {
            return NotFound();
        }

        perfilInvitacionCirculo.Activo = false;
        perfilInvitacionCirculo.FechaModificacion = DateTime.UtcNow;
        perfilInvitacionCirculo.UsuarioModificacionId = update_user_id ?? 2;
        await context.SaveChangesAsync();

        return Ok();
    }

    [HttpGet("resume")]
    public object GetResume(
        [FromQuery] string? order_by,
        [FromQuery] int? limit,
        [FromQuery] int? skip
    )
    {
        var query = from perfilInvitacionCirculo in context.Set<PerfilInvitacionCirculo>()

                    let perfilAnfitrion = context.Perfil
                        .Where(perfil => perfilInvitacionCirculo.PerfilAnfitrionId == perfil.Id)
                        .Select(perfil => new
                        {
                            perfil.Id,
                            perfil.Guid,
                            perfil.Alias,
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
                        })
                        .FirstOrDefault()

                    let perfilInvitado = context.Perfil
                        .Where(perfil => perfilInvitacionCirculo.PerfilInvitadoId == perfil.Id)
                        .Select(perfil => new
                        {
                            perfil.Id,
                            perfil.Guid,
                            perfil.Alias,
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
                        })
                        .FirstOrDefault()

                    where perfilInvitacionCirculo.Activo

                    select new
                    {
                        perfilInvitacionCirculo.Id,
                        perfilInvitacionCirculo.FechaCreacion,
                        perfilAnfitrion,
                        perfilInvitado,
                    };

        return query;
    }

    [HttpPost("list")]
    public async Task<ActionResult<PerfilInvitacionCirculo>> PostList(List<PerfilInvitacionCirculoViewModel> request)
    {
        if (request.Any() == false)
        {
            return BadRequest();
        }

        var usuarioPerfil = context.UsuarioPerfil
            .Where(usuarioPerfil => request[0].UsuarioCreacionId == usuarioPerfil.UsuarioId)
            .FirstOrDefault();

        if (usuarioPerfil == null)
        {
            return BadRequest(new {msg = "User has not any perfil"});
        }

        bool wasEvenRepeated = false;

        foreach (var perfilInvitacion in request)
        {
            bool isRepeated = context.PerfilInvitacionCirculo
                .Any(invitacion =>
                    invitacion.PerfilInvitadoId == perfilInvitacion.PerfilInvitadoId &&
                    invitacion.UsuarioCreacionId == perfilInvitacion.UsuarioCreacionId
                );

            if (isRepeated)
            {
                wasEvenRepeated = true;
                continue;
            }

            PerfilInvitacionCirculo perfilInvitacionCirculo = mapper.Map<PerfilInvitacionCirculo>(perfilInvitacion);
            perfilInvitacionCirculo.PerfilAnfitrionId = usuarioPerfil.PerfilId;

            context.PerfilInvitacionCirculo.Add(perfilInvitacionCirculo);
        }
        
        await context.SaveChangesAsync();

        ApiResponse<string> response = wasEvenRepeated
            ? new ApiResponse<string>()
            {
                StatusCode = 202,
                Message = "Existieron una o varias invitaciones repetidas",
                Success = true
            }
            : new ApiResponse<string>()
            {
                StatusCode = 200,
                Success = true
            };

        return Ok(response);
    }
}
