using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.Precandidaturas;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.Precandidaturas
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilPrecandidaturaController(UniversoContext context, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilPrecandidatura>>> Get()
        {
            return await context.PerfilPrecandidatura.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PerfilPrecandidatura>> Get(int id)
        {
            var perfilPrecandidatura = await context.PerfilPrecandidatura.FindAsync(id);

            return perfilPrecandidatura == null ? NotFound() : perfilPrecandidatura;
        }

        [HttpPost]
        public async Task<ActionResult<PerfilPrecandidatura>> Post(PerfilPrecandidaturaViewModel request)
        {
            PerfilPrecandidatura perfilPrecandidatura = mapper.Map<PerfilPrecandidatura>(request);
            context.PerfilPrecandidatura.Add(perfilPrecandidatura);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilPrecandidatura.Id }, perfilPrecandidatura);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, PerfilPrecandidaturaViewModel request)
        {
            var perfilPrecandidatura = await context.PerfilPrecandidatura.FindAsync(id);

            if (perfilPrecandidatura == null)
            {
                return NotFound();
            }

            mapper.Map(request, perfilPrecandidatura);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilPrecandidatura.Id }, perfilPrecandidatura);
        }

        // DELETE: api/<PerfilPrecandidaturaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var perfilPrecandidatura = await context.PerfilPrecandidatura.FindAsync(id);

            if (perfilPrecandidatura == null)
            {
                return NotFound();
            }

            context.PerfilPrecandidatura.Remove(perfilPrecandidatura);
            await context.SaveChangesAsync();

            return Ok();
        }

        // PUT: api/<PerfilPrecandidaturaController>/disable/5
        [HttpPut("disable/{id:int}")]
        public async Task<IActionResult> Disable(int id)
        {
            var perfilPrecandidatura = await context.PerfilPrecandidatura.FindAsync(id);

            if (perfilPrecandidatura == null)
            {
                return NotFound();
            }

            perfilPrecandidatura.Activo = false;
            perfilPrecandidatura.FechaActualizacion = DateTime.UtcNow;
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("perfil")]
        public object Get([FromQuery] string alias)
        {

            var existingPerfil = context.Perfil
                .FirstOrDefault(perfil => !string.IsNullOrEmpty(perfil.Alias) &&
                                          perfil.Alias.ToLower().Replace(" ", "") == alias &&
                                          perfil.Activo);

            if (existingPerfil == null)
            {
                return NotFound();
            }

            var existingPerfilPrecandidatura = context.PerfilPrecandidatura
                .FirstOrDefault(perfilPrecandidatura => existingPerfil.Id == perfilPrecandidatura.PerfilId);

            if (existingPerfilPrecandidatura == null)
            {
                return NotFound(new { existingPerfilPrecandidatura = false });
            }

            var existingTipoCandidatura = context.CatalogoTipoPrecandidatura
                .FirstOrDefault(tipoCandidatura =>
                    existingPerfilPrecandidatura.TipoPrecandidaturaId == tipoCandidatura.Id &&
                    tipoCandidatura.Activo);

            if (existingTipoCandidatura == null)
            {
                return NotFound(new { existingTipoCandidatura = false });
            }

            return from perfilPrecandidatura in context.Set<PerfilPrecandidatura>()
                let perfil = context.Perfil
                    .FirstOrDefault(perfil => perfilPrecandidatura.PerfilId == perfil.Id)
                let tipoPrecandidatura = context.CatalogoTipoPrecandidatura
                    .FirstOrDefault(tipoPrecandidatura =>
                        perfilPrecandidatura.TipoPrecandidaturaId == tipoPrecandidatura.Id)
                where !string.IsNullOrEmpty(perfil.Alias) &&
                      perfil.Alias.ToLower().Replace(" ", "") == alias
                select new
                {
                    perfilPrecandidatura.Id,
                    perfilPrecandidatura.Activo,
                    perfilPrecandidatura.EntidadFederativa,
                    perfilPrecandidatura.EntidadFederativaId,
                    perfilPrecandidatura.TipoPrecandidaturaId,
                    perfilPrecandidatura.Municipio,
                    perfilPrecandidatura.Distrito,
                    perfilPrecandidatura.FechaActualizacion,
                    perfilPrecandidatura.Descripcion,
                    perfilPrecandidatura.FotoPerfil,
                    perfil,
                    tipoPrecandidatura,
                    perfilCatalogoRedesSociales = context.PerfilCatalogoRedesSociales
                        .Where(pcr => pcr.PerfilId == perfil.Id)
                        .Select(pcr => new
                        {
                            pcr.CatalogoRedesSocialesId,
                            pcr.Url,
                        })
                        .DefaultIfEmpty()
                        .ToList(),
                    userData = new
                    {
                        isDashboard = context.UsuarioPerfil.Any(up => perfil.Id == up.PerfilId),
                        usuarioPerfil = context.UsuarioPerfil.First(up => perfil.Id == up.PerfilId),
                        perfilUsuario = context.PerfilUsuario
                            .Select(pu => new
                            {
                                pu.Id,
                                pu.PerfilId,
                                pu.Name,
                                pu.Email,
                                pu.EmailVerifiedAt,
                                pu.Area,
                                pu.Puesto,
                                pu.ProfileImage,
                                pu.Activo,
                                pu.EsCHC,
                                pu.FechaCreacion
                            })
                            .FirstOrDefault(pu => perfil.Id == pu.PerfilId),
                    }
                };
        }
    }
}