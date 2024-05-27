using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoConfiguracionesController : ControllerBase
    {
        private readonly UniversoContext _context;

        public CatalogoConfiguracionesController(UniversoContext context)
        {
            _context = context;
        }

        // GET api/<CatalogoConfiguracionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoConfiguraciones>> Get(int id)
        {
            var catalogoConfiguraciones = await _context.CatalogoConfiguraciones.FindAsync(id);

            if (catalogoConfiguraciones == null)
                return NotFound();

            return catalogoConfiguraciones;
        }
    }
}
