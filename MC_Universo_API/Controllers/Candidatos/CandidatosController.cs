using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.Candidatos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers.Candidatos;

[Route("api/[controller]")]
[ApiController]
public class CandidatosController(UniversoContext context, IMapper mapper) : ControllerBase
{
    [HttpGet("Cuestionario/{perfilId:int}")]
    public async Task<IActionResult> GetCuestionario(int perfilId)
    {
        var cuestionario = await context.CuestionarioCandidato
            .Where(c => c.PerfilId == perfilId)
            .FirstOrDefaultAsync();
        
        if (cuestionario == null) return NotFound();
        return Ok(cuestionario);
    }
    
    [HttpPost("Cuestionario")]
    public async Task<IActionResult> PostCuestionario([FromBody] CuestionarioCandidato cuestionario)
    {
        if (!ModelState.IsValid)
        {
            var errores = string.Join(", ", ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage));
            
            return BadRequest(errores);
        }
        
        // Revisar si el perfil no tiene un cuestionario ya registrado
        var cuestionarioExistente = await context.CuestionarioCandidato
            .Where(c => c.PerfilId == cuestionario.PerfilId)
            .FirstOrDefaultAsync();
        
        if (cuestionarioExistente != null) return Conflict("Ya existe un cuestionario para este perfil.");
        
        // Revisar si el perfil existe y es un candidato
        var perfil = await context.Perfil
            .Where(p => p.Id == cuestionario.PerfilId)
            .FirstOrDefaultAsync();
        
        if (perfil == null) return NotFound("El perfil no existe.");
        
        if (!perfil.esCandidato) return BadRequest("El perfil no es un candidato.");
        
        context.CuestionarioCandidato.Add(cuestionario);
        await context.SaveChangesAsync();
        return Created();
    }



    [HttpGet("filtrado/ObtenerCandidatos/entidad/{entidadFederativaId}/tipoPrecandidatura/{tipoPrecandidatura}")]
    public async Task<IActionResult> GetFiltrarCandidatos
    (
    int entidadFederativaId,
    int tipoPrecandidatura)
    {
        try
        {
            var query = from p in context.Perfil
                        join pu in context.PerfilUsuario on p.Id equals pu.PerfilId
                        into gpu
                        from pu in gpu.DefaultIfEmpty()
                        join pp in context.PerfilPrecandidatura on p.Id equals pp.PerfilId
                        into gpp
                        from pp in gpp.DefaultIfEmpty()
                        join up in context.UsuarioPerfil on p.Id equals up.PerfilId
                        into gup
                        from up in gup.DefaultIfEmpty()
                        where
                            (p.esCandidato == true && p.Activo == true && pu.Activo == true) &&
                            (entidadFederativaId != 0 ? pp.EntidadFederativaId == entidadFederativaId : true) &&
                            (tipoPrecandidatura != 0 ? pp.TipoPrecandidaturaId == tipoPrecandidatura : true)
                        select new
                        {
                            PerfilId = p.Id,
                            p.esCandidato,
                            p.CustomUrl,
                            p.Alias,
                            Nombre = pu != null ? pu.Name : null,
                            TipoPrecandidaturaId = pp != null ? pp.TipoPrecandidaturaId : 0,
                            Candidatura = pp != null ? pp.CatalogoTipoPrecandidatura.Nombre : null,
                            Estado = pp != null ? pp.EntidadFederativa.Nombre : null,
                            Distrito = pp != null ? pp.Distrito : 0,
                            Municipio = pp != null ? pp.Municipio : null,
                            UsuarioId = up != null ? up.UsuarioId : 0,
                            ExisteEnPerfilUsuario = pu != null,
                            ExisteEnUsuarioPerfil = up != null,
                            ExisteEnPerfilPrecandidatura = pp != null,
                            PerfilUsuarioImage = pu != null ? pu.ProfileImage : null
                        };
            var resultados = await query.ToListAsync();
            return Ok(resultados);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new { Error = e.Message });
        }
    }
}