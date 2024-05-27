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
    public class ProgramaAreaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ProgramaAreaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/ProgramaAreaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProgramaArea>>> Get()
        {
            return await _context.ProgramaArea.ToListAsync();
        }

        // GET api/<ProgramaAreaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProgramaArea>> Get(int id)
        {
            var programaArea = await _context.ProgramaArea.FindAsync(id);

            return programaArea == null ? NotFound() : programaArea;
        }

        // GET api/<ProgramaAreaController>/programa=5
        [HttpGet("programa={id}")]
        public async Task<ActionResult<IEnumerable<ProgramaArea>>> GetByPrograma(int id)
        {
            var programaArea = await _context.ProgramaArea.Where(acc => acc.ProgramaId == id).ToListAsync();

            return programaArea == null ? NotFound() : programaArea;
        }

        // GET api/<ProgramaAreaController>/area=5
        [HttpGet("area={id}")]
        public async Task<ActionResult<IEnumerable<ProgramaArea>>> GetByArea(int id)
        {
            var programaArea = await _context.ProgramaArea.Where(acc => acc.AreaId == id).ToListAsync();

            return programaArea == null ? NotFound() : programaArea;
        }

        // POST api/<ProgramaAreaController>
        [HttpPost]
        public async Task<ActionResult<ProgramaArea>> Post(ProgramaAreaViewModel request)
        {
            ProgramaArea programaArea = _mapper.Map<ProgramaArea>(request);
            _context.ProgramaArea.Add(programaArea);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = programaArea.Id }, programaArea);
        }

        // PUT api/<ProgramaAreaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ProgramaAreaViewModel request)
        {
            var programaArea = await _context.ProgramaArea.FindAsync(id);
            _mapper.Map(request, programaArea);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = programaArea.Id }, programaArea);
        }

        // DELETE api/<ProgramaAreaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var programaArea = await _context.ProgramaArea.FindAsync(id);
            if (programaArea == null)
                return NotFound();

            _context.ProgramaArea.Remove(programaArea);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
