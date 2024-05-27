using System.Security.Claims;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class HabilidadCustomController : ControllerBase
{
    private readonly UniversoContext _context;
    
    public HabilidadCustomController(UniversoContext context)
    {
        _context = context;
    }
    
    // Get all Habilidades custom
    [HttpGet]
    public async Task<ActionResult<IEnumerable<HabilidadCustom>>> GetHabilidadesCustom()
    {
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        
        if (identity == null)
        {
            return Unauthorized("No se incontró el token de autenticación");
        }
        
        var tokenValid = await new Jwt().ValidateToken(identity, _context);
        
        if (tokenValid.error)
        {
            return Unauthorized(tokenValid.message);
        }
        
        Usuario usuario = tokenValid.result;
        
        if (usuario.Rol != "Super Administrador")
        {
            return Unauthorized("No está autorizado para acceder a este recurso");
        }
        
        return await _context.HabilidadCustom.ToListAsync();
    }
    
    // Get Habilidad custom by id
    [HttpGet("{id}")]
    public async Task<ActionResult<HabilidadCustom>> GetHabilidadCustom(int id)
    {
        var habilidadCustom = await _context.HabilidadCustom.FindAsync(id);
        
        if (habilidadCustom == null)
        {
            return NotFound();
        }
        
        return habilidadCustom;
    }
    
    // Get Habilidades custom by PersonaId
    [HttpGet("Persona/{id}")]
    public async Task<ActionResult<IEnumerable<HabilidadCustom>>> GetHabilidadesCustomByPersonaId(int id)
    {
        // Check if Persona exists
        var persona = await _context.Persona.FindAsync(id);
        // If not, return NotFound with a message
        if (persona == null)
        {
            return NotFound("Persona no encontrada");
        }
        
        var habilidadesCustom = await _context.HabilidadCustom.Where(h => h.PersonaId == id).ToListAsync();

        return habilidadesCustom;
    }
}