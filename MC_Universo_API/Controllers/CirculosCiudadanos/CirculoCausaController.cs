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
public class CirculoCausaController(UniversoContext context, IMapper mapper) : ControllerBase
{
    // GET: api/<CirculoCausaController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CirculoCausa>>> Get()
    {
        return await context.CirculoCausa.ToListAsync();
    }

    // GET: api/<CirculoCausaController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<CirculoCausa>> Get(int id)
    {
        var circuloCausa = await context.CirculoCausa.FindAsync(id);

        return circuloCausa == null ? NotFound() : circuloCausa;
    }

    // POST: api/<CirculoCausaController>
    [HttpPost]
    public async Task<ActionResult<CirculoCausa>> Post(CirculoCausaViewModel request)
    {
        CirculoCausa circuloCausa = mapper.Map<CirculoCausa>(request);
        context.CirculoCausa.Add(circuloCausa);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = circuloCausa.Id }, circuloCausa);
    }

    // PUT: api/<CirculoCausaController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, CirculoCausaViewModel request)
    {
        var circuloCausa = await context.CirculoCausa.FindAsync(id);

        if (circuloCausa == null)
        {
            return NotFound();
        }

        mapper.Map(request, circuloCausa);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = circuloCausa.Id }, circuloCausa);
    }

    // DELETE: api/<CirculoCausaController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var circuloCausa = await context.CirculoCausa.FindAsync(id);

        if (circuloCausa == null)
        {
            return NotFound();
        }

        context.CirculoCausa.Remove(circuloCausa);
        await context.SaveChangesAsync();

        return Ok();
    }

    // PUT: api/<CirculoCausaController>/disable/5
    [HttpPut("disable/{id}")]
    public async Task<IActionResult> Disable(
        int id,
        [FromQuery] int? update_user_id
    )
    {
        var circuloCausa = await context.CirculoCausa.FindAsync(id);

        if (circuloCausa == null)
        {
            return NotFound();
        }

        circuloCausa.Activo = false;
        circuloCausa.FechaModificacion = DateTime.UtcNow;
        circuloCausa.UsuarioModificacionId = update_user_id ?? 2;
        await context.SaveChangesAsync();

        return Ok();
    }
}
