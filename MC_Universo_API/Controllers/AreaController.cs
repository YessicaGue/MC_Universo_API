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
    public class AreaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public AreaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<AreaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Area>>> Get()
        {
            return await _context.Area.ToListAsync();
        }

        // GET api/<AreaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Area>> Get(int id)
        {
            var area = await _context.Area.FindAsync(id);

            return area == null ? NotFound() : area;
        }

        // POST api/<AreaController>
        [HttpPost]
        public async Task<ActionResult<Area>> Post(Area area)
        {
            _context.Area.Add(area);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = area.Id }, area);
        }

    }
}
