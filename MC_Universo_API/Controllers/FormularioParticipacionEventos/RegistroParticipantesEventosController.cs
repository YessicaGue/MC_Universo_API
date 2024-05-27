using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.FormularioParticipacionEventos;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels;
using MC_Universo_API.ViewModels.FormularioParticipacionEventos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers.FormularioParticipacionEventos
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroParticipantesEventosController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RegistroParticipantesEventosController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<RegistroParticipantesEventosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroParticipantesEventos>>> Get()
        {
            return await _context.RegistroParticipantesEventos.ToListAsync();
        }

        // GET: api/<RegistroParticipantesEventosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroParticipantesEventos>> Get(int id)
        {
            var registroParticipantesEventos = await _context.RegistroParticipantesEventos.FindAsync(id);

            return registroParticipantesEventos == null ? NotFound() : registroParticipantesEventos;
        }

        // POST: api/<RegistroParticipantesEventosController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ContenedorRegistroDireccionViewModel request)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var registroRequest = request.RegistroParticipantesEventosViewModel;
                    var direccionRequest = request.DomiclioGeneralViewModel;

                    var direccion = _mapper.Map<DomicilioGeneral>(direccionRequest);
                    _context.DomicilioGeneral.Add(direccion);
                    await _context.SaveChangesAsync();
                    
                    var entidadFederativaId = registroRequest.EntidadfederativaEventoId;
                    var entidadFeredativaCodigoEvento = await _context.EntidadFederativaCodigoEventos
                        .FirstOrDefaultAsync(e => e.EntidadFederativaId == entidadFederativaId);

                    if (entidadFeredativaCodigoEvento != null)
                    {
                        entidadFeredativaCodigoEvento.GeneradorContadoCodigo++;
                        await _context.SaveChangesAsync();
                    }

                    var nuevoValorGenerador = entidadFeredativaCodigoEvento?.GeneradorContadoCodigo ?? 0;
                    var registroParticipanteEvento = _mapper.Map<RegistroParticipantesEventos>(registroRequest);
                    registroParticipanteEvento.DomicilioGeneralId = direccion.Id;
                    
                    registroParticipanteEvento.Folio = Convert.ToString(nuevoValorGenerador);
                    try
                    {
                        _context.RegistroParticipantesEventos.Add(registroParticipanteEvento);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateException ex)
                    {
                        return Conflict();
                    }
                    
                    await transaction.CommitAsync();

                    var response = new ApiResponse<RegistroParticipantesEventos>
                    {
                        Success = true,
                        StatusCode = 200,
                        Message = "Datos Enviados",
                        Data = registroParticipanteEvento,
                    };

                    return Ok(response);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    var errorResponse = new
                    {
                        succes = false,
                        message = ex.Message,
                    };
                    return BadRequest(errorResponse);
                }
            }
                
        }

    }
}
