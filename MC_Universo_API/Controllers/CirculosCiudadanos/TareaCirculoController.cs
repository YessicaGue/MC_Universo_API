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
public class TareaCirculoController(UniversoContext context, IMapper mapper) : ControllerBase
{
    // GET: api/<TareaCirculoController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TareaCirculo>>> Get()
    {
        return await context.TareaCirculo.ToListAsync();
    }

    // GET: api/<TareaCirculoController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TareaCirculo>> Get(int id)
    {
        var tareaCirculo = await context.TareaCirculo.FindAsync(id);

        return tareaCirculo == null ? NotFound() : tareaCirculo;
    }

    // POST: api/<TareaCirculoController>
    [HttpPost]
    public async Task<ActionResult<TareaCirculo>> Post(TareaCirculoViewModel request)
    {
        TareaCirculo tareaCirculo = mapper.Map<TareaCirculo>(request);
        context.TareaCirculo.Add(tareaCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = tareaCirculo.Id }, tareaCirculo);
    }

    // PUT: api/<TareaCirculoController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, TareaCirculoViewModel request)
    {
        var tareaCirculo = await context.TareaCirculo.FindAsync(id);

        if (tareaCirculo == null)
        {
            return NotFound();
        }

        mapper.Map(request, tareaCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = tareaCirculo.Id }, tareaCirculo);
    }

    // DELETE: api/<TareaCirculoController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var tareaCirculo = await context.TareaCirculo.FindAsync(id);

        if (tareaCirculo == null)
        {
            return NotFound();
        }

        context.TareaCirculo.Remove(tareaCirculo);
        await context.SaveChangesAsync();

        return Ok();
    }

    // PUT: api/<TareaCirculoController>/disable/5
    [HttpPut("disable/{id}")]
    public async Task<IActionResult> Disable(
        int id,
        [FromQuery] int? update_user_id
    )
    {
        var tareaCirculo = await context.TareaCirculo.FindAsync(id);

        if (tareaCirculo == null)
        {
            return NotFound();
        }

        tareaCirculo.Activo = false;
        tareaCirculo.FechaModificacion = DateTime.UtcNow;
        tareaCirculo.UsuarioModificacionId = update_user_id ?? 2;
        await context.SaveChangesAsync();

        return Ok();
    }
}
