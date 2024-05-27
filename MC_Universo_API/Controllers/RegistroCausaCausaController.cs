using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroCausaCausaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RegistroCausaCausaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<RegistroCausaCausaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroCausaCausa>>> Get()
        {
            return await _context.RegistroCausaCausa.ToListAsync();
        }

        // GET api/<RegistroCausaCausaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroCausaCausa>> Get(int id)
        {
            var registroCausaCausa = await _context.RegistroCausaCausa.FindAsync(id);

            return registroCausaCausa == null ? NotFound() : registroCausaCausa;
        }

        // GET api/<RegistroCausaCausaController>/registro-causa=5
        [HttpGet("registro-causa={id}")]
        public async Task<ActionResult<IEnumerable<RegistroCausaCausa>>> GetByRegistroCausa(int id)
        {
            var registroCausaCausa = await _context.RegistroCausaCausa.Where(acc => acc.RegistroCausaId == id).ToListAsync();

            return registroCausaCausa == null ? NotFound() : registroCausaCausa;
        }

        // GET api/<RegistroCausaCausaController>/causa=5
        [HttpGet("causa={id}")]
        public async Task<ActionResult<IEnumerable<RegistroCausaCausa>>> GetByCausa(int id)
        {
            var registroCausaCausa = await _context.RegistroCausaCausa.Where(acc => acc.CausaId == id).ToListAsync();

            return registroCausaCausa == null ? NotFound() : registroCausaCausa;
        }

        // POST api/<RegistroCausaCausaController>
        [HttpPost]
        public async Task<ActionResult<RegistroCausaCausa>> Post(RegistroCausaCausaViewModel request)
        {
            RegistroCausaCausa registroCausaCausa = _mapper.Map<RegistroCausaCausa>(request);
            _context.RegistroCausaCausa.Add(registroCausaCausa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroCausaCausa.Id }, registroCausaCausa);
        }

        // PUT api/<RegistroCausaCausaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RegistroCausaCausaViewModel request)
        {
            var registroCausaCausa = await _context.RegistroCausaCausa.FindAsync(id);
            _mapper.Map(request, registroCausaCausa);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroCausaCausa.Id }, registroCausaCausa);
        }

        // DELETE api/<RegistroCausaCausaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var registroCausaCausa = await _context.RegistroCausaCausa.FindAsync(id);
            if (registroCausaCausa == null)
                return NotFound();

            _context.RegistroCausaCausa.Remove(registroCausaCausa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
