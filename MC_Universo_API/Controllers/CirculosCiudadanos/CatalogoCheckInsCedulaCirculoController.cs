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
public class CatalogoCheckInsCedulaCirculoController(UniversoContext context, IMapper mapper) : ControllerBase
{
    // GET: api/<CatalogoCheckInsCedulaCirculoController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CatalogoCheckInsCedulaCirculo>>> Get()
    {
        return await context.CatalogoCheckInsCedulaCirculo
            .Where(estatus => estatus.Activo == true)
            .OrderBy(estatus => estatus.Id)
            .ToListAsync();
    }

    // GET: api/<CatalogoCheckInsCedulaCirculoController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<CatalogoCheckInsCedulaCirculo>> Get(int id)
    {
        var catalogoCheckInsCedulaCirculo = await context.CatalogoCheckInsCedulaCirculo.FindAsync(id);

        return catalogoCheckInsCedulaCirculo == null ? NotFound() : catalogoCheckInsCedulaCirculo;
    }

    // POST: api/<CatalogoCheckInsCedulaCirculoController>
    [HttpPost]
    public async Task<ActionResult<CatalogoCheckInsCedulaCirculo>> Post(CatalogoCheckInsCedulaCirculoViewModel request)
    {
        CatalogoCheckInsCedulaCirculo catalogoCheckInsCedulaCirculo = mapper.Map<CatalogoCheckInsCedulaCirculo>(request);
        context.CatalogoCheckInsCedulaCirculo.Add(catalogoCheckInsCedulaCirculo);
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = catalogoCheckInsCedulaCirculo.Id }, catalogoCheckInsCedulaCirculo);
    }

    // PUT: api/<CatalogoCheckInsCedulaCirculoController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, CatalogoCheckInsCedulaCirculoViewModel request)
    {
        var catalogoCheckInsCedulaCirculo = await context.CatalogoCheckInsCedulaCirculo.FindAsync(id);

        if (catalogoCheckInsCedulaCirculo == null)
        {
            return NotFound();
        }

        mapper.Map(request, catalogoCheckInsCedulaCirculo);
        catalogoCheckInsCedulaCirculo.FechaModificacion = DateTime.UtcNow;
        await context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = catalogoCheckInsCedulaCirculo.Id }, catalogoCheckInsCedulaCirculo);
    }

    // DELETE: api/<CatalogoCheckInsCedulaCirculoController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var catalogoCheckInsCedulaCirculo = await context.CatalogoCheckInsCedulaCirculo.FindAsync(id);

        if (catalogoCheckInsCedulaCirculo == null)
        {
            return NotFound();
        }

        context.CatalogoCheckInsCedulaCirculo.Remove(catalogoCheckInsCedulaCirculo);
        await context.SaveChangesAsync();

        return Ok();
    }

    // PUT: api/<CatalogoCheckInsCedulaCirculoController>/disable/5
    [HttpPut("disable/{id}")]
    public async Task<IActionResult> Disable(
        int id,
        [FromQuery] int? update_user_id
    )
    {
        var catalogoCheckInsCedulaCirculo = await context.CatalogoCheckInsCedulaCirculo.FindAsync(id);

        if (catalogoCheckInsCedulaCirculo == null)
        {
            return NotFound();
        }

        catalogoCheckInsCedulaCirculo.Activo = false;
        catalogoCheckInsCedulaCirculo.FechaModificacion = DateTime.UtcNow;
        catalogoCheckInsCedulaCirculo.UsuarioModificacionId = update_user_id ?? 2;
        await context.SaveChangesAsync();

        return Ok();
    }
}
