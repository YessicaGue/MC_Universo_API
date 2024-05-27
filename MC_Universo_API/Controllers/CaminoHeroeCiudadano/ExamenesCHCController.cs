using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CaminoHeroeCiudadano
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamenesCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public ExamenesCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ExamenesCandidatosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExamenesCHC>>> Get()
        {
            return await _context.ExamenesCHC.ToListAsync();
        }

        // GET: api/<ExamenesCandidatosController>
        [HttpGet("GetDetalleExamen/{id}")]
        public IActionResult GetDetalleExamen(int id)
        {
            var examen = _context.ExamenesCHC
                .FirstOrDefault(e => e.Id == id);

            if (examen == null)
            {
                return NotFound();
            }

            var preguntas = _context.PreguntasExamenCHC
                .Where(p => p.ExamenCHCId == id)
                .Select(pregunta => new
                {
                    id = pregunta.Id,
                    question = pregunta.Pregunta,
                    options = _context.RespuestaExamenCHC
                        .Where(respuesta => respuesta.PreguntaExamenCHCId == pregunta.Id)
                        .Select(respuesta => new
                        {
                            id = respuesta.Id,
                            text = respuesta.Respuesta,
                            //isCorrect = respuesta.EsCorrecta
                        })
                        .ToList()
                })
                .ToList();
            var result = new
            {
                reference = examen.Id,
                preguntas = preguntas
            };
            return Ok(result);
        }

        // GET api/<ExamenesCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExamenesCHC>> Get(int id)
        {
            var examenesCHC = await _context.ExamenesCHC.FindAsync(id);

            return examenesCHC == null ? NotFound() : examenesCHC;
        }
        // POST api/<ExamenesCHCController>
        [HttpPost]
        public async Task<ActionResult<ExamenesCHC>> Post(ExamenesCHCViewModel request)
        {
            ExamenesCHC examenesCHC = _mapper.Map<ExamenesCHC>(request);
            _context.ExamenesCHC.Add(examenesCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = examenesCHC.Id }, examenesCHC);
        }

        // PUT api/<ExamenesCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ExamenesCHCViewModel request)
        {
            var examenesCHC = await _context.ExamenesCHC.FindAsync(id);
            _mapper.Map(request, examenesCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = examenesCHC.Id }, examenesCHC);
        }

        // DELETE api/<ExamenesCHCController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
