using AutoMapper;
using DocumentFormat.OpenXml.InkML;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CirculosCiudadanos;
using MC_Universo_API.ViewModels.CirculosCiudadanos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CirculosCiudadanos;

[Route("api/[controller]")]
[ApiController]
public class HistoricoEstatusCirculoController(UniversoContext context, IMapper mapper) : ControllerBase
{
    // GET: api/<HistoricoEstatusCirculoController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<HistoricoEstatusCirculo>>> Get()
    {
        return await context.HistoricoEstatusCirculo.ToListAsync();
    }

    // GET: api/<HistoricoEstatusCirculoController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<HistoricoEstatusCirculo>> Get(int id)
    {
        var historicoEstatusCirculo = await context.HistoricoEstatusCirculo.FindAsync(id);

        return historicoEstatusCirculo == null ? NotFound() : historicoEstatusCirculo;
    }

    // POST: api/<HistoricoEstatusCirculoController>
    [HttpPost]
    public async Task<ActionResult<HistoricoEstatusCirculo>> Post(HistoricoEstatusCirculoViewModel request)
    {
        HistoricoEstatusCirculo historicoEstatusCirculo = mapper.Map<HistoricoEstatusCirculo>(request);
        context.HistoricoEstatusCirculo.Add(historicoEstatusCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = historicoEstatusCirculo.Id }, historicoEstatusCirculo);
    }

    // PUT: api/<HistoricoEstatusCirculoController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, HistoricoEstatusCirculoViewModel request)
    {
        var historicoEstatusCirculo = await context.HistoricoEstatusCirculo.FindAsync(id);

        if (historicoEstatusCirculo == null)
        {
            return NotFound();
        }

        mapper.Map(request, historicoEstatusCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = historicoEstatusCirculo.Id }, historicoEstatusCirculo);
    }

    // DELETE: api/<HistoricoEstatusCirculoController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var historicoEstatusCirculo = await context.HistoricoEstatusCirculo.FindAsync(id);

        if (historicoEstatusCirculo == null)
        {
            return NotFound();
        }

        context.HistoricoEstatusCirculo.Remove(historicoEstatusCirculo);
        await context.SaveChangesAsync();

        return Ok();
    }

    // PUT: api/<HistoricoEstatusCirculoController>/disable/5
    [HttpPut("disable/{id}")]
    public async Task<IActionResult> Disable(
        int id,
        [FromQuery] int? update_user_id
    )
    {
        var historicoEstatusCirculo = await context.HistoricoEstatusCirculo.FindAsync(id);

        if (historicoEstatusCirculo == null)
        {
            return NotFound();
        }

        historicoEstatusCirculo.Activo = false;
        historicoEstatusCirculo.FechaModificacion = DateTime.UtcNow;
        historicoEstatusCirculo.UsuarioModificacionId = update_user_id ?? 2;
        await context.SaveChangesAsync();

        return Ok();
    }
}