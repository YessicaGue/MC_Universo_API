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
    public class MotivoController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public MotivoController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<MotivoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Motivo>>> Get()
        {
            return await _context.Motivo.ToListAsync();
        }

        // GET api/<MotivoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Motivo>> Get(int id)
        {
            var motivo = await _context.Motivo.FindAsync(id);

            return motivo == null ? NotFound() : motivo;
        }

        // POST api/<MotivoController>
        [HttpPost]
        public async Task<ActionResult<Motivo>> Post(Motivo motivo)
        {
            _context.Motivo.Add(motivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = motivo.Id }, motivo);
        }

    }
}
