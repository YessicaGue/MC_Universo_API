using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CaminoHeroeCiudadano
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentoCandidatosCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public DocumentoCandidatosCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<DocumentoCandidatosCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentoCandidatosCHC>>> Get()
        {
            return await _context.DocumentoCandidatosCHC.ToListAsync();
        }

        // GET api/<DocumentoCandidatosCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocumentoCandidatosCHC>> Get(int id)
        {
            var documentoCandidatosCHC = await _context.DocumentoCandidatosCHC.FindAsync(id);

            return documentoCandidatosCHC == null ? NotFound() : documentoCandidatosCHC;
        }
        // POST api/<DocumentoCandidatosCHCController>
        [HttpPost]
        public async Task<ActionResult<DocumentoCandidatosCHC>> Post(DocumentoCandidatosCHCViewModel request)
        {
            DocumentoCandidatosCHC documentoCandidatosCHC = _mapper.Map<DocumentoCandidatosCHC>(request);
            _context.DocumentoCandidatosCHC.Add(documentoCandidatosCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = documentoCandidatosCHC.Id }, documentoCandidatosCHC);
        }

        [HttpPost("cartaCompromiso")] //cartacompromiso o cualquier otro documento
        public async Task<ActionResult<DocumentoCandidatosCHC>> PostCartaCompromiso(DoumentoCandidatoCHCRegistroViewModel request)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    int perfilId = request.PerfilId;
                    int candidatoId = _context.CandidatosCHC
                        .Where(c => c.PerfilId == perfilId)
                        .Select(c => c.Id)
                        .FirstOrDefault();
                    if (candidatoId == 0)
                    {
                        return NotFound(new ApiResponse<string>
                        {
                            StatusCode = 404,
                            Success = false,
                            Message = "No se encontro un candidato",
                            Data = null
                        });
                    }

                    bool existeRegistro = _context.DocumentoCandidatosCHC
                        .Any(dc => dc.CandidatoCHCId == candidatoId
                                   && dc.DocumentoEligibilidadCHCId == request.DocumentoCandidatosCHCViewModel
                                       .DocumentoEligibilidadCHCId);
                    if (existeRegistro)
                    {
                        return BadRequest(new ApiResponse<string>
                        {
                            StatusCode = 400,
                            Success = false,
                            Message = "Ya tienes Registrado un Documento",
                            Data = null
                        });
                    }
                    //se guarda la etapa Registro CartaCompromiso 
                    CandidatoEtapaRegistroCHC candidatoEtapaRegistroChc = _mapper.Map<CandidatoEtapaRegistroCHC>
                        (request.CandidatoEtapaRegistroCHCViewModel);
                    candidatoEtapaRegistroChc.CandidatoId = candidatoId;
                    _context.CandidatoEtapaRegistroCHC.Add(candidatoEtapaRegistroChc);
                    await _context.SaveChangesAsync();
                    
                    //guarda en DocumentoCandidatosCHCViewModel                    
                    DocumentoCandidatosCHC documentoCandidatosChc = _mapper.Map<DocumentoCandidatosCHC>
                        (request.DocumentoCandidatosCHCViewModel);
                    documentoCandidatosChc.CandidatoCHCId = candidatoId;
                    _context.DocumentoCandidatosCHC.Add(documentoCandidatosChc);
                    await _context.SaveChangesAsync();
                    
                    
                    transaction.Commit();

                    return Ok(new ApiResponse<DocumentoCandidatosCHC>
                    {
                        StatusCode = 200,
                        Success = true,
                        Message = "Datos Almacenados Correctamente",
                        Data = documentoCandidatosChc,
                    });
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return StatusCode(500, $"Error interno del servidor {ex.Message}");
                }
            }
        }

        [HttpPost("documentoEvidencia")]
        public async Task<ActionResult<DocumentoCandidatosCHC>> PostDocumentos(DoumentoCandidatoCHCRegistroViewModel request)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    int perfilId = request.PerfilId;
                    int candidatoId = _context.CandidatosCHC
                        .Where(c => c.PerfilId == perfilId)
                        .Select(c => c.Id)
                        .FirstOrDefault();
                    if (candidatoId == 0)
                    {
                        return NotFound(new ApiResponse<string>
                        {
                            StatusCode = 404,
                            Success = false,
                            Message = "No se encontro un candidato",
                            Data = null
                        });
                    }

                    //guarda en DocumentoCandidatosCHCViewModel                    
                    DocumentoCandidatosCHC documentoCandidatosChc = _mapper.Map<DocumentoCandidatosCHC>
                        (request.DocumentoCandidatosCHCViewModel);
                    documentoCandidatosChc.CandidatoCHCId = candidatoId;
                    _context.DocumentoCandidatosCHC.Add(documentoCandidatosChc);
                    await _context.SaveChangesAsync();


                    transaction.Commit();

                    return Ok(new ApiResponse<DocumentoCandidatosCHC>
                    {
                        StatusCode = 200,
                        Success = true,
                        Message = "Datos Almacenados Correctamente",
                        Data = documentoCandidatosChc,
                    });
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return StatusCode(500, $"Error interno del servidor {ex.Message}");
                }
            }
        }

        [HttpGet("documentoEvidencia/getPorCandidato/{perfilId}")]
        public async Task<ActionResult<DocumentoCandidatosCHC>> GetDocumentos(int perfilId)
        {
            try
            {
                int candidatoId = _context.CandidatosCHC
                    .Where(c => c.PerfilId == perfilId)
                    .Select(c => c.Id)
                    .FirstOrDefault();

                var documentos = await _context.DocumentoCandidatosCHC
                    .Where(dcc => dcc.CandidatoCHCId == candidatoId && dcc.Activo == true
                            && dcc.DocumentoEligibilidadCHCId == 2)
                    .Select(dcc => new
                    {
                        dcc.Id,
                        dcc.CandidatoCHCId, dcc.DocumentoEligibilidadCHCId,
                        EstatusNombre = dcc.CatalogoEstatusDocumentosEligibilidadCHC.Nombre,
                        dcc.NombreArchivo,
                        dcc.NombreArchivoUsuario,
                        dcc.DescripcionArchivoUsuario,
                        dcc.Activo,
                        dcc.FechaAlta
                    })
                    .ToListAsync();

                return Ok(new ApiResponse<object>
                {
                    StatusCode = 200,
                    Success = true,
                    Message = "Datos Extraídos Correctamente",
                    Data = new { documentos , hasSubidoArchivo = documentos != null }

                });
            }

            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor {ex.Message}");
            }
        }

        // PUT api/<DocumentoCandidatosCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, DocumentoCandidatosCHCViewModel request)
        {
            var documentoCandidatosCHC = await _context.DocumentoCandidatosCHC.FindAsync(id);
            _mapper.Map(request, documentoCandidatosCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = documentoCandidatosCHC.Id }, documentoCandidatosCHC);
        }

        // DELETE api/<DocumentoCandidatosCHCController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
