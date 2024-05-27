using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventoTipoController : ControllerBase
{
    private readonly UniversoContext _context;
    
    public EventoTipoController(UniversoContext context)
    {
        _context = context;
    }
    
    // GET: api/EventoTipo
    [HttpGet]
    public async Task<ActionResult<IEnumerable<EventoTipo>>> GetEventoTipo()
    {
        return await _context.EventoTipo.ToListAsync();
    }
    
    // GET: api/EventoTipo/5
    [HttpGet("{id}")]
    public async Task<ActionResult<EventoTipo>> GetEventoTipo(int id)
    {
        var eventoTipo = await _context.EventoTipo.FindAsync(id);
        
        if (eventoTipo == null)
        {
            return NotFound();
        }
        
        return eventoTipo;
    }
}