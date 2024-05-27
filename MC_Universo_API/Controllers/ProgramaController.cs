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
    public class ProgramaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ProgramaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ProgramaController>/related
        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from programa in _context.Set<Programa>()

                        let programaArea = _context.ProgramaArea
                            .Where(pa => programa.Id == pa.ProgramaId)
                            .DefaultIfEmpty()
                            .ToList()

                        let programaResponsable = _context.ProgramaResponsable
                            .Where(pr => programa.Id == pr.ProgramaId)
                            .DefaultIfEmpty()
                            .ToList()

                        let voluntarioPrograma = _context.VoluntarioPrograma
                            .Where(vp => programa.Id == vp.ProgramaId)
                            .DefaultIfEmpty()
                            .ToList()

                        select new
                        {
                            programa.Id,
                            programa.Nombre,
                            programa.Localidad,
                            programa.Descripcion,
                            programa.Activo,
                            programa.CantidadCupo,
                            programa.FechaInicio,
                            programa.FechaFin,
                            programa.FechaCreacion,
                            responsables = programaResponsable,
                            areas = programaArea
                                .Select(pa =>
                                    _context.Area
                                        .Where(a => pa.AreaId == a.Id)
                                        .FirstOrDefault()
                                ),
                            voluntarios = voluntarioPrograma
                                .Select(vp =>
                                    _context.Voluntario
                                        .Where(v => vp.VoluntarioId == v.Id)
                                        .FirstOrDefault()
                                )
                        };
            return query.ToList();
        }

        // GET: api/<ProgramaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Programa>>> Get()
        {
            return await _context.Programa.ToListAsync();
        }

        // GET api/<ProgramaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Programa>> Get(int id)
        {
            var programa = await _context.Programa.FindAsync(id);

            return programa == null ? NotFound() : programa;
        }

        // POST api/<ProgramaController>
        [HttpPost]
        public async Task<ActionResult<Programa>> Post(ProgramaViewModel request)
        {
            Programa programa = _mapper.Map<Programa>(request);
            _context.Programa.Add(programa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = programa.Id }, programa);
        }

        // PUT api/<ProgramaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ProgramaViewModel request)
        {
            var programa = await _context.Programa.FindAsync(id);
            _mapper.Map(request, programa);

            await _context.SaveChangesAsync();
            
            return CreatedAtAction("Get", new { id = programa.Id }, programa);
        }

        // DELETE api/<ProgramaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
