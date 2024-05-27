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
    public class ArchivoController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ArchivoController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ArchivoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Archivo>>> Get()
        {
            return await _context.Archivo.ToListAsync();
        }

        // GET api/<ArchivoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Archivo>> Get(int id)
        {
            var archivo = await _context.Archivo.FindAsync(id);

            return archivo == null ? NotFound() : archivo;
        }

        // POST api/<ArchivoController>
        [HttpPost]
        public async Task<ActionResult<Archivo>> Post(ArchivoViewModel request)
        {
            Archivo archivo = _mapper.Map<Archivo>(request);
            _context.Archivo.Add(archivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = archivo.Id }, archivo);
        }

    }
}
