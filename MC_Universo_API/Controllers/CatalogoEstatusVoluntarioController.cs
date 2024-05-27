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
    public class CatalogoEstatusVoluntarioController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CatalogoEstatusVoluntarioController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CatalogoEstatusVoluntarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogoEstatusVoluntario>>> Get()
        {
            return await _context.CatalogoEstatusVoluntario.ToListAsync();
        }

        // GET api/<CatalogoEstatusVoluntarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CatalogoEstatusVoluntario>> Get(int id)
        {
            var estatusVoluntario = await _context.CatalogoEstatusVoluntario.FindAsync(id);

            return estatusVoluntario == null ? NotFound() : estatusVoluntario;
        }

        // POST api/<CatalogoEstatusVoluntarioController>
        [HttpPost]
        public async Task<ActionResult<CatalogoEstatusVoluntario>> Post(CatalogoEstatusVoluntario estatusVoluntario)
        {
            _context.CatalogoEstatusVoluntario.Add(estatusVoluntario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = estatusVoluntario.Id }, estatusVoluntario);
        }

        // PUT api/<CatalogoEstatusVoluntarioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CatalogoEstatusVoluntario request)
        {
            var estatusVoluntario = await _context.CatalogoEstatusVoluntario.FindAsync(id);
            _mapper.Map(request, estatusVoluntario);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = estatusVoluntario.Id }, estatusVoluntario);
        }

    }
}
