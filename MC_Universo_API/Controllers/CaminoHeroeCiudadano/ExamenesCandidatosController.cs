using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CaminoHeroeCiudadano
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamenesCandidatosController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ExamenesCandidatosController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ExamenesCandidatosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidatosExamenes>>> Get()
        {
            return await _context.CandidatosExamenes.ToListAsync();
        }

        // GET api/<ExamenesCandidatosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CandidatosExamenes>> Get(int id)
        {
            var examenesCandidatos = await _context.CandidatosExamenes.FindAsync(id);

            return examenesCandidatos == null ? NotFound() : examenesCandidatos;
        }
        //POST api/<ExamenesCandidatosController>
        [HttpPost]
        public async Task<ActionResult<CandidatosExamenes>> Post(ExamenesCandidatosViewModel request)
        {
            CandidatosExamenes examenesCandidatos = _mapper.Map<CandidatosExamenes>(request);
            _context.CandidatosExamenes.Add(examenesCandidatos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = examenesCandidatos.Id }, examenesCandidatos);
        }

        //PUT api/<ExamenesCandidatosController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ExamenesCandidatosViewModel request)
        {
            var examenesCandidatos = await _context.CandidatosExamenes.FindAsync(id);
            _mapper.Map(request, examenesCandidatos);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = examenesCandidatos.Id }, examenesCandidatos);
        }

        // DELETE api/<ExamenesCandidatosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
