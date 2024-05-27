using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoCausasLandingController : ControllerBase
    {
        private readonly UniversoContext _context;

        public CatalogoCausasLandingController(UniversoContext context)
        {
            _context = context;
        }

        // GET: api/<CatalogoCausasLandingController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoCausasLanding>>> Get()
        {
            return await _context.CatalogoCausasLanding.ToListAsync();
        }

        // GET api/<CatalogoCausasLandingController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoCausasLanding>> Get(int id)
        {
            var catalogoCausasLanding = await _context.CatalogoCausasLanding.FindAsync(id);

            if (catalogoCausasLanding == null)
                return NotFound();

            return catalogoCausasLanding;
        }
    }
}
