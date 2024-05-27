using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoTokensController : ControllerBase
    {
        private readonly UniversoContext _context;

        public CatalogoTokensController(UniversoContext context)
        {
            _context = context;
        }

        // GET: api/<CatalogoTokensController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoTokens>>> Get()
        {
            return await _context.CatalogoTokens.ToListAsync();
        }

        // GET api/<CatalogoTokensController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoTokens>> Get(int id)
        {
            var catalogoTokens = await _context.CatalogoTokens.FindAsync(id);

            if (catalogoTokens == null)
                return NotFound();

            return catalogoTokens;
        }
    }
}
