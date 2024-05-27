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
    public class EntidadFederativaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public EntidadFederativaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<EntidadFederativaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntidadFederativa>>> Get()
        {
            return await _context.EntidadFederativa.ToListAsync();
        }

        // GET api/<EntidadFederativaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntidadFederativa>> Get(int id)
        {
            var entidadFederativa = await _context.EntidadFederativa.FindAsync(id);

            return entidadFederativa == null ? NotFound() : entidadFederativa;
        }

        // GET api/<EntidadFederativaController>/5
        [HttpGet("nombre={nombre}")]
        public async Task<ActionResult<EntidadFederativa>> GetByNombre(string nombre)
        {
            var entidadFederativa = await _context.EntidadFederativa.FirstOrDefaultAsync(acc => acc.Nombre.ToLower() == nombre.ToLower());

            return entidadFederativa == null ? NotFound() : entidadFederativa;
        }


    }
}
