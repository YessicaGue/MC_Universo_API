using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventoController : ControllerBase
{
    private readonly UniversoContext _context;
    
    public EventoController(UniversoContext context)
    {
        _context = context;
    }
    
    // GET: api/Evento
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Evento>>> GetEvento()
    {
        return await _context.Evento.ToListAsync();
    }
    
    // GET: api/Evento/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Evento>> GetEvento(int id)
    {
        var evento = await _context.Evento.FindAsync(id);
        
        if (evento == null)
        {
            return NotFound();
        }
        
        return evento;
    }
    
    // PUT: api/Evento/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutEvento(Guid id, Evento evento)
    {
        if (id != evento.Id)
        {
            return BadRequest();
        }
        
        _context.Entry(evento).State = EntityState.Modified;
        
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            var eventoExists = await _context.Evento.FindAsync(id);
            if (eventoExists == null)
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
        
        return NoContent();
    }
    
    // POST: api/Evento
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Evento>> PostEvento(Evento evento)
    {
        _context.Evento.Add(evento);
        await _context.SaveChangesAsync();

        try
        {
            return CreatedAtAction("GetEvento", new { id = evento.Id }, evento);
        } catch (Exception e)
        {
            return BadRequest("Error al crear el evento " + e.Message);
        }
    }
}