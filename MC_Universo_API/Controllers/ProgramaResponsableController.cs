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
    public class ProgramaResponsableController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ProgramaResponsableController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/ProgramaResponsableController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProgramaResponsable>>> Get()
        {
            return await _context.ProgramaResponsable.ToListAsync();
        }

        // GET api/<ProgramaResponsableController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProgramaResponsable>> Get(int id)
        {
            var programaResponsable = await _context.ProgramaResponsable.FindAsync(id);

            return programaResponsable == null ? NotFound() : programaResponsable;
        }

        // GET api/<ProgramaResponsableController>/programa=5
        [HttpGet("programa={id}")]
        public async Task<ActionResult<IEnumerable<ProgramaResponsable>>> GetByPrograma(int id)
        {
            var programaResponsable = await _context.ProgramaResponsable.Where(acc => acc.ProgramaId == id).ToListAsync();

            return programaResponsable == null ? NotFound() : programaResponsable;
        }

        // GET api/<ProgramaResponsableController>/responsable=5
        [HttpGet("responsable={id}")]
        public async Task<ActionResult<IEnumerable<ProgramaResponsable>>> GetByResponsable(int id)
        {
            var programaResponsable = await _context.ProgramaResponsable.Where(acc => acc.ResponsableId == id).ToListAsync();

            return programaResponsable == null ? NotFound() : programaResponsable;
        }

        // POST api/<ProgramaResponsableController>
        [HttpPost]
        public async Task<ActionResult<ProgramaResponsable>> Post(ProgramaResponsableViewModel request)
        {
            ProgramaResponsable programaResponsable = _mapper.Map<ProgramaResponsable>(request);
            _context.ProgramaResponsable.Add(programaResponsable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = programaResponsable.Id }, programaResponsable);
        }

        // PUT api/<ProgramaResponsableController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ProgramaResponsableViewModel request)
        {
            var programaResponsable = await _context.ProgramaResponsable.FindAsync(id);
            _mapper.Map(request, programaResponsable);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = programaResponsable.Id }, programaResponsable);
        }

        // DELETE api/<ProgramaResponsableController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var programaResponsable = await _context.ProgramaResponsable.FindAsync(id);
            if (programaResponsable == null)
                return NotFound();

            _context.ProgramaResponsable.Remove(programaResponsable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
