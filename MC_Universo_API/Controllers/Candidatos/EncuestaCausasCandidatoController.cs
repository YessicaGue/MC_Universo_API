using MC_Universo_API.Data;
using MC_Universo_API.Models.Candidatos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers.Candidatos;

[Route("api/[controller]")]
[ApiController]
public class EncuestaCausasCandidatoController(UniversoContext context) : ControllerBase
{
    [HttpGet("Preguntas")]
    public async Task<List<PreguntasOpcionesViewModel>> GetRandomPreguntas(int cantidadPreguntas = 3)
    {
        // Obtener preguntas activas de forma aleatoria
        var preguntas = await context.EncuestaCausasCandidatoPregunta
            .Where(p => p.Activo)
            .OrderBy(p => Guid.NewGuid())
            .Take(cantidadPreguntas)
            .ToListAsync();

        // Obtener opciones para las preguntas obtenidas
        var opciones = await context.EncuestaCausasCandidatoOpcion
            .Where(o => o.Activo && preguntas.Select(p => p.Id).Contains(o.PreguntaId))
            .ToListAsync();

        // Crear una lista de ViewModels con las preguntas y sus opciones correspondientes
        var preguntasConOpciones = preguntas.Select(pregunta => new PreguntasOpcionesViewModel
        {
            Pregunta = pregunta,
            Opciones = opciones.Where(opcion => opcion.PreguntaId == pregunta.Id).ToList()
        }).ToList();

        return preguntasConOpciones;
    }

    [HttpPost("Respuestas")]
    public async Task<IActionResult> PostRespuestas([FromBody] List<RespuestaViewModel> respuestas)
    {
        if (!ModelState.IsValid)
        {
            var errores = string.Join(", ", ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage));

            return BadRequest(errores);
        }

        try
        {
            foreach (var respuesta in respuestas.Select(respuestaViewModel => new EncuestaCausasCandidato
                     {
                         PerfilId = respuestaViewModel.PerfilId,
                         UsuarioId = respuestaViewModel.UsuarioId,
                         PreguntaId = respuestaViewModel.PreguntaId,
                         OpcionId = respuestaViewModel.OpcionId,
                         Respuesta = respuestaViewModel.Respuesta
                     }))
            {
                context.EncuestaCausasCandidato.Add(respuesta);
            }

            await context.SaveChangesAsync();
            return Created();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    public class PreguntasOpcionesViewModel
    {
        public EncuestaCausasCandidatoPregunta Pregunta { get; set; } = default!;
        public List<EncuestaCausasCandidatoOpcion> Opciones { get; set; } = default!;
    }

    public class RespuestaViewModel
    {
        public int PerfilId { get; set; }
        public int? UsuarioId { get; set; }
        public int PreguntaId { get; set; }
        public int OpcionId { get; set; }
        public string Respuesta { get; set; } = default!;
    }
}