using AutoMapper;
using Azure.Core;
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
    public class GrupoInteresesController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public GrupoInteresesController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<GrupoInteresesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrupoIntereses>>> Get()
        {
            return await _context.GrupoIntereses.ToListAsync();
        }

        // GET api/<GrupoInteresesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GrupoIntereses>> Get(int id)
        {
            var grupoIntereses = await _context.GrupoIntereses.FindAsync(id);

            return grupoIntereses == null ? NotFound() : grupoIntereses;
        }

        // POST api/<GrupoInteresesController>
        [HttpPost]
        public async Task<ActionResult<GrupoIntereses>> Post(GrupoIntereses grupoIntereses)
        {
            _context.GrupoIntereses.Add(grupoIntereses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = grupoIntereses.Id }, grupoIntereses);
        }

    }
}
