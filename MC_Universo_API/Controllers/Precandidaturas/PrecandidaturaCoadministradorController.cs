using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CirculosCiudadanos;
using MC_Universo_API.Models.Precandidaturas;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels.Precandidaturas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.Precandidaturas;

[Route("api/[controller]")]
[ApiController]
public class PrecandidaturaCoadministradorController(UniversoContext context, IMapper mapper) : ControllerBase
{
    // GET: api/<PrecandidaturaCoadministradorController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PrecandidaturaCoadministrador>>> Get()
    {
        return await context.PrecandidaturaCoadministrador.ToListAsync();
    }

    // GET: api/<PrecandidaturaCoadministradorController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<PrecandidaturaCoadministrador>> Get(int id)
    {
        var precandidaturaCoadministrador = await context.PrecandidaturaCoadministrador.FindAsync(id);

        return precandidaturaCoadministrador == null ? NotFound() : precandidaturaCoadministrador;
    }

    // POST: api/<PrecandidaturaCoadministradorController>
    [HttpPost]
    public async Task<ActionResult<PrecandidaturaCoadministrador>> Post(PrecandidaturaCoadministradorViewModel request)
    {
        bool isRepeated = context.PrecandidaturaCoadministrador
            .Any(administrador =>
                request.PerfilPrecandidaturaId == administrador.PerfilPrecandidaturaId
                    && request.PerfilId == administrador.PerfilId
            );

        if (isRepeated)
        {
            return BadRequest();
        }

        PrecandidaturaCoadministrador precandidaturaCoadministrador = mapper.Map<PrecandidaturaCoadministrador>(request);
        context.PrecandidaturaCoadministrador.Add(precandidaturaCoadministrador);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = precandidaturaCoadministrador.Id }, precandidaturaCoadministrador);
    }

    // PUT: api/<PrecandidaturaCoadministradorController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, PrecandidaturaCoadministradorViewModel request)
    {
        var precandidaturaCoadministrador = await context.PrecandidaturaCoadministrador.FindAsync(id);

        if (precandidaturaCoadministrador == null)
        {
            return NotFound();
        }

        mapper.Map(request, precandidaturaCoadministrador);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = precandidaturaCoadministrador.Id }, precandidaturaCoadministrador);
    }

    // DELETE: api/<PrecandidaturaCoadministradorController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var precandidaturaCoadministrador = await context.PrecandidaturaCoadministrador.FindAsync(id);

        if (precandidaturaCoadministrador == null)
        {
            return NotFound();
        }

        context.PrecandidaturaCoadministrador.Remove(precandidaturaCoadministrador);
        await context.SaveChangesAsync();

        return Ok();
    }

    // PUT: api/<PrecandidaturaCoadministradorController>/disable/5
    [HttpPut("disable/{id}")]
    public async Task<IActionResult> Disable(
        int id,
        [FromQuery] int? update_user_id
    )
    {
        var precandidaturaCoadministrador = await context.PrecandidaturaCoadministrador.FindAsync(id);

        if (precandidaturaCoadministrador == null)
        {
            return NotFound();
        }

        precandidaturaCoadministrador.Activo = false;
        precandidaturaCoadministrador.FechaModificacion = DateTime.UtcNow;
        precandidaturaCoadministrador.UsuarioModificacionId = update_user_id ?? 2;
        await context.SaveChangesAsync();

        return Ok();
    }

    [HttpGet("provide-coadministrador-token")]
    public object ProvideCoadministradorToken(
        [FromQuery] string? guid
    )
    {
        if (string.IsNullOrEmpty(guid))
        {
            return BadRequest();
        }

        var perfil = context.Perfil
            .Where(perfil => guid == perfil.Guid.ToString())
            .FirstOrDefault();

        if (perfil == null)
        {
            var response = new ApiResponse<string>
            {
                Success = false,
                StatusCode = 404,
                Message = "Perfil no encontrado",
            };
            return NotFound(response);
        }

        var precandidatura = context.PerfilPrecandidatura
            .Where(precandidatura => perfil.Id == precandidatura.PerfilId)
            .FirstOrDefault();

        if (precandidatura == null)
        {
            var response = new ApiResponse<string>
            {
                Success = false,
                StatusCode = 404,
                Message = "Precandidatura no encontrada",
            };
            return NotFound();
        }

        if (precandidatura.LigaInvitacionCoadministracion == null)
        {
            Guid guidInvitacion = Guid.NewGuid();
            precandidatura.GuidInvitacionCoadministracion = guidInvitacion;
            precandidatura.LigaInvitacionCoadministracion = guidInvitacion
                .ToString()
                .Split("-")
                .First();

            context.PerfilPrecandidatura.Update(precandidatura);
            context.SaveChangesAsync();
        }

        return new
        {
            token = precandidatura.LigaInvitacionCoadministracion
        };
    }

    [HttpGet("validate-coadministrador-token")]
    public object ValidateCoadministradorToken(
        [FromQuery] string? token,
        [FromQuery] int? perfil_id
    )
    {
        if (token == null)
        {
            return BadRequest();
        }

        var precandidatura = context.PerfilPrecandidatura
            .Where(precandidatura => token == precandidatura.LigaInvitacionCoadministracion)
            .FirstOrDefault();

        if (precandidatura == null)
        {
            var response = new ApiResponse<string>
            {
                Success = false,
                StatusCode = 404,
                Message = "Perfil no encontrado",
            };
            return NotFound();
        }

        bool isRepeated = context.PrecandidaturaCoadministrador
            .Any(administrador => 
                perfil_id != null && (
                    precandidatura.Id == administrador.PerfilPrecandidaturaId
                        && perfil_id == administrador.PerfilId
                )
            );

        if (isRepeated)
        {
            var response = new ApiResponse<string>
            {
                Success = false,
                StatusCode = 402,
                Message = "El registro ya existe",
            };
            return BadRequest();
        }

        var perfil = context.Perfil
            .Where(perfil => precandidatura.PerfilId == perfil.Id)
            .FirstOrDefault();

        if (perfil == null)
        {
            var response = new ApiResponse<string>
            {
                Success = false,
                StatusCode = 404,
                Message = "Perfil ligado es inaccesible",
            };
            return NotFound();
        }

        return perfil;
    }
}
