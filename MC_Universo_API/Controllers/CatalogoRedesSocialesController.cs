using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoRedesSocialesController : ControllerBase
    {
        private readonly UniversoContext _context;

        public CatalogoRedesSocialesController(UniversoContext context)
        {
            _context = context;
        }

        // GET: api/<CatalogoRedesSocialesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoRedesSociales>>> Get()
        {
            return await _context.CatalogoRedesSociales.ToListAsync();
        }

        // GET api/<CatalogoRedesSocialesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoRedesSociales>> Get(int id)
        {
            var catalogoRedesSociales = await _context.CatalogoRedesSociales.FindAsync(id);

            if (catalogoRedesSociales == null)
                return NotFound();

            return catalogoRedesSociales;
        }
    }
}
