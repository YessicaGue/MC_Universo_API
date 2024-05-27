using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CirculosCiudadanos;
using MC_Universo_API.ViewModels.CirculosCiudadanos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CirculosCiudadanos;

[Route("api/[controller]")]
[ApiController]
public class CatalogoEstatusCirculoController(UniversoContext context, IMapper mapper) : ControllerBase
{
    // GET: api/<CatalogoEstatusCirculoController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CatalogoEstatusCirculo>>> Get()
    {
        return await context.CatalogoEstatusCirculo
            .Where(estatus => estatus.Activo == true)
            .OrderBy(estatus => estatus.Id)
            .ToListAsync();
    }

    // GET: api/<CatalogoEstatusCirculoController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<CatalogoEstatusCirculo>> Get(int id)
    {
        var catalogoEstatusCirculo = await context.CatalogoEstatusCirculo.FindAsync(id);

        return catalogoEstatusCirculo == null ? NotFound() : catalogoEstatusCirculo;
    }

    // POST: api/<CatalogoEstatusCirculoController>
    [HttpPost]
    public async Task<ActionResult<CatalogoEstatusCirculo>> Post(CatalogoEstatusCirculoViewModel request)
    {
        CatalogoEstatusCirculo catalogoEstatusCirculo = mapper.Map<CatalogoEstatusCirculo>(request);
        context.CatalogoEstatusCirculo.Add(catalogoEstatusCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = catalogoEstatusCirculo.Id }, catalogoEstatusCirculo);
    }

    // PUT: api/<CatalogoEstatusCirculoController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, CatalogoEstatusCirculoViewModel request)
    {
        var catalogoEstatusCirculo = await context.CatalogoEstatusCirculo.FindAsync(id);

        if (catalogoEstatusCirculo == null)
        {
            return NotFound();
        }

        mapper.Map(request, catalogoEstatusCirculo);
        catalogoEstatusCirculo.FechaModificacion = DateTime.UtcNow;
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = catalogoEstatusCirculo.Id }, catalogoEstatusCirculo);
    }

    // DELETE: api/<CatalogoEstatusCirculoController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var catalogoEstatusCirculo = await context.CatalogoEstatusCirculo.FindAsync(id);

        if (catalogoEstatusCirculo == null)
        {
            return NotFound();
        }

        context.CatalogoEstatusCirculo.Remove(catalogoEstatusCirculo);
        await context.SaveChangesAsync();

        return Ok();
    }

    // PUT: api/<CatalogoEstatusCirculoController>/disable/5
    [HttpPut("disable/{id}")]
    public async Task<IActionResult> Disable(
        int id,
        [FromQuery] int? update_user_id
    )
    {
        var catalogoEstatusCirculo = await context.CatalogoEstatusCirculo.FindAsync(id);

        if (catalogoEstatusCirculo == null)
        {
            return NotFound();
        }

        catalogoEstatusCirculo.Activo = false;
        catalogoEstatusCirculo.FechaModificacion = DateTime.UtcNow;
        catalogoEstatusCirculo.UsuarioModificacionId = update_user_id ?? 2;
        await context.SaveChangesAsync();

        return Ok();
    }
}
