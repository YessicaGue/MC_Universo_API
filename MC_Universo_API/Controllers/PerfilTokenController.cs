using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilTokenController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilTokenController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PerfilTokenController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilToken>>> Get()
        {
            return await _context.PerfilToken.ToListAsync();
        }

        // GET api/<PerfilTokenController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilToken>> Get(int id)
        {
            var perfilToken = await _context.PerfilToken.FindAsync(id);

            return perfilToken == null ? NotFound() : perfilToken;
        }
        
        // GET api/<PerfilTokenController>/5
        [HttpGet("TokenPorGuid/guid={uuid}/ctId={ctId}")]
        public async Task<ActionResult<PerfilToken>> Get(Guid uuid, int ctId)
        {
            try
            {
                var perfilToken = await _context.PerfilToken
                    .Include(pt => pt.Token)
                    .FirstOrDefaultAsync(pt => pt.Perfil.Guid == uuid && pt.Token.CatalogoTokenId == ctId);
                if (perfilToken == null)
                {
                    return NotFound();
                }
                return Ok(perfilToken);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocurrió un error interno en el servidor.");
            }
        }
        
        // POST api/<PerfilTokenController>
        [HttpPost]
        public async Task<ActionResult<PerfilToken>> Post(PerfilTokenViewModel request)
        {
            PerfilToken perfilToken = _mapper.Map<PerfilToken>(request);
            _context.PerfilToken.Add(perfilToken);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilToken.Id }, perfilToken);
        }

        // PUT api/<PerfilTokenController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilTokenViewModel request)
        {
            var perfilToken = await _context.PerfilToken.FindAsync(id);
            _mapper.Map(request, perfilToken);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilToken.Id }, perfilToken);
        }
    }
}
