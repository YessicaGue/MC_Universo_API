using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.ViewModels;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CaminoHeroeCiudadano
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleExamenesCandidatosController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public DetalleExamenesCandidatosController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleCandidatosExamenes>>> Get()
        {
            return await _context.DetalleCandidatosExamenes.ToListAsync();
        }

        // GET: api/<DetalleExamenesCandidatosController>
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleCandidatosExamenes>> Get(int id)
        {
            var detalleExamenesCandidatos = await _context.DetalleCandidatosExamenes.FindAsync(id);

            return detalleExamenesCandidatos == null ? NotFound() : detalleExamenesCandidatos;
        }

        //POST api/<DetalleExamenesCandidatosController>
        [HttpPost]
        public async Task<ActionResult<DetalleCandidatosExamenes>> Post(DetalleExamenesCandidatosViewModel request)
        {
            DetalleCandidatosExamenes detalleExamenesCandidatos = _mapper.Map<DetalleCandidatosExamenes>(request);
            _context.DetalleCandidatosExamenes.Add(detalleExamenesCandidatos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = detalleExamenesCandidatos.Id }, detalleExamenesCandidatos);
        }

        [HttpPost("DetalleExamen")]
        public async Task<ActionResult> PostRepuestasPreguntas(ExamenesRespuestasIntentosCHCViewModel request)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }

                    int perfilId = request.PerfilId;
                    CandidatosCHC candidato = await _context.CandidatosCHC.FirstOrDefaultAsync(c => c.PerfilId == perfilId);
                    if (candidato == null)
                    {
                        return NotFound("Perfil No Existe");
                    }

                    bool todasLasRepuestasCorrectas = true;
                    foreach (var detalleViewModel in request.DetalleExamenesCandidatosViewModel)
                    {
                        RespuestaExamenCHC respuesta = await _context.RespuestaExamenCHC
                            .FirstOrDefaultAsync(r => r.Id == detalleViewModel.RespuestaExamenCHCId);
                        if (respuesta != null && !respuesta.EsCorrecta)
                        {
                            todasLasRepuestasCorrectas = false;
                            break;
                        }
                    }

                    if (todasLasRepuestasCorrectas == true)
                    {
                        var nuevoRegistro = new CandidatoEtapaRegistroCHC()
                        {
                            CandidatoId = candidato.Id,
                            RegistroId = 4
                        };
                        _context.CandidatoEtapaRegistroCHC.Add(nuevoRegistro);
                        await _context.SaveChangesAsync();
                    }
                    CandidatosExamenes examenesCandidatos = _mapper.Map<CandidatosExamenes>(request.ExamenesCandidatosViewModel);
                    examenesCandidatos.CandidatoCHCId = candidato.Id;
                    examenesCandidatos.EsAprobado = todasLasRepuestasCorrectas;
                    _context.CandidatosExamenes.Add(examenesCandidatos);
                    await _context.SaveChangesAsync();

                    foreach (var detalleViewModel in request.DetalleExamenesCandidatosViewModel)
                    {
                        DetalleCandidatosExamenes detalleExamenesCandidatos =
                            _mapper.Map<DetalleCandidatosExamenes>(detalleViewModel);
                        detalleExamenesCandidatos.ExamenCandidatoId = examenesCandidatos.Id;
                        _context.DetalleCandidatosExamenes.Add(detalleExamenesCandidatos);
                    }
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return Ok(new
                    {
                        success = true,
                        message = "Datos insertados correctamente",
                        todasLasRepuestasCorrectas
                    });
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return StatusCode(500, $"Error interno del servidor{ex.Message}");
                }
            }

        }

        // PUT api/<DetalleExamenesCandidatosController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, DetalleExamenesCandidatosViewModel request)
        {
            var detalleExamenesCandidatos = await _context.DetalleCandidatosExamenes.FindAsync(id);
            _mapper.Map(request, detalleExamenesCandidatos);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = detalleExamenesCandidatos.Id }, detalleExamenesCandidatos);
        }

        // DELETE api/<DetalleExamenesCandidatosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
