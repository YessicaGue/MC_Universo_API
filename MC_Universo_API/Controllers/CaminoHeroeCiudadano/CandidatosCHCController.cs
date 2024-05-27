using System.Net;
using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.CaminoHeroeCiudadano
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatosCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CandidatosCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<CandidatosCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidatosCHC>>> Get()
        {
            return await _context.CandidatosCHC.ToListAsync();
        }

        // GET api/<CandidatosCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CandidatosCHC>> Get(int id)
        {
            var candidatosCHC = await _context.CandidatosCHC.FindAsync(id);

            return candidatosCHC == null ? NotFound() : candidatosCHC;
        }

        //GET api/<CandidatosCHCController>/5
        [HttpGet("GetDetalleCandidatoCHC/{perfilId}")]
        public async Task<IActionResult> GetDetalleCandidatoCHC(int perfilId)
        {
            try
            {
                
                float totalPorcentaje = 0;
                int numEtapas = 0;
                bool todasLasEtapasRegistroCompletadas = false;
                bool todasLasEtapasAvanceCompletadas = false;
                bool tieneCaminoAsignado = false;
                List<CatalogoEtapaRegistroCHCViewModel> detalleEtapaRegistro = new List<CatalogoEtapaRegistroCHCViewModel>();
                var Perfil = await _context.Perfil
                    .Where(perfil => perfil.Id == perfilId)
                    .ToListAsync();
                
                var candidatoPerfil = await _context.CandidatosCHC
                    .Where(candidato => candidato.PerfilId == perfilId && candidato.Activo)
                    .Select(candidato => new
                    {
                        candidato.Id,
                        candidato.PerfilId,
                        candidato.CaminoId,
                        candidato.CargoPostulacionId,
                        candidato.FechaInicio,
                        candidato.Activo,
                        candidato.FechaAlta,
                        Perfil = _context.Perfil
                            .Where(perfil => perfil.Id == candidato.PerfilId)
                            .FirstOrDefault(),
                        Camino = _context.CatalogoCaminosCHC
                            .Where(camino => camino.Id == candidato.CaminoId)
                            .Select(camino=>new CatalogoCaminosCHCViewModel
                            {
                                Nombre= camino.Nombre,
                                Descripcion = camino.Descripcion,
                                NombreColor = camino.NombreColor,
                                ValorColor = camino.ValorColor,
                                Activo = camino.Activo,
                                FechaCreacion = camino.FechaCreacion
                            })
                            .FirstOrDefault(),
                        CargoPostulacion = _context.CatalogoCargosPostulacion
                            .Where(cargo => cargo.Id == candidato.CargoPostulacionId)
                            .Select(cargo => new
                            {
                                cargo.Id,
                                cargo.NivelCargoId,
                                cargo.Nombre,
                                NivelCargo = _context.CatalogoNivelesCargos
                                    .Where(nivel => nivel.Id == cargo.NivelCargoId)
                                    .FirstOrDefault()
                            }).FirstOrDefault(),
                        Avance = _context.AvanceEtapasCandidato
                            .Where(avance => avance.CandidatoCHCId == candidato.Id && avance.Activo)
                            .ToList(),
                        EtapasAvance = _context.CatalogoEtapasCHC
                            .Where(etapa=>etapa.CaminoId==candidato.CaminoId && etapa.Activo==true)
                            .Select(etapa=>new
                            {
                                Etapa = etapa,
                                Avance = _context.AvanceEtapasCandidato
                                    .Where(avance => avance.CandidatoCHCId==candidato.Id && 
                                                     avance.EtapaId==etapa.Id)
                                    .Select(avance=>new
                                    {
                                        avance.PorcentajeAvance,
                                        avance.ValidoComite,
                                        avance.FechaUltimoCambio,
                                        avance.FechaExpiracion
                                    }).FirstOrDefault()
                            })
                            .OrderBy(item => item.Etapa.IndiceOrden)
                            .ToList()
                    }
                ).ToListAsync();
                var perfilPersona = _context.PerfilPersonaCHC
                    .Where(pp => pp.PerfilId == perfilId)
                    .FirstOrDefault();
                
                var persona= perfilPersona!=null
                    ?_context.Persona
                    .Where(p => p.Id == perfilPersona.PersonaId)
                    .FirstOrDefault():null;

                var direccion = persona!=null
                    ?_context.Direccion
                    .Where(d => d.PersonaId == perfilPersona.PersonaId)
                    .FirstOrDefault():null;
                int? candidatoId = candidatoPerfil.FirstOrDefault()?.Id;
                if(candidatoId.HasValue){
                    var etapasRegistradas = await _context.CandidatoEtapaRegistroCHC
                        .Where(ce => ce.CandidatoId == candidatoId.Value && ce.Activo)
                        .Select(ce => ce.CatalogoEtapaRegistroCHC)
                        .ToListAsync();

                    var todasLasEtapas = await _context.CatalogoEtapaRegistroCHC.ToListAsync();

                    detalleEtapaRegistro = todasLasEtapas
                        .Select(etapa => new CatalogoEtapaRegistroCHCViewModel
                    {
                        Nombre = etapa.Nombre,
                        Descripcion = etapa.Descripcion,
                        NombreURLRoute = etapa.NombreURLRoute,
                        IndiceOrden = etapa.IndiceOrden,
                        Activo = etapa.Activo,
                        FechaAlta = etapa.FechaAlta,
                        Porcentaje = etapasRegistradas.Any(er=>er.Id==etapa.Id)?100.0f:0.0f
                    }).ToList();

                    float totalPorcentajeDetalle = detalleEtapaRegistro.Sum(etapa => etapa.Porcentaje??0.0f);

                    totalPorcentaje += totalPorcentajeDetalle;

                    numEtapas += detalleEtapaRegistro.Count;

                    foreach (var etapa in candidatoPerfil[0].EtapasAvance)
                    {
                        if (etapa.Avance != null)
                        {
                            totalPorcentaje += etapa.Avance.PorcentajeAvance;
                            numEtapas++;
                        }
                        else
                        {
                            totalPorcentaje += 0;
                            numEtapas++;
                        }
                    }

                    todasLasEtapasRegistroCompletadas = detalleEtapaRegistro.All(etapa => etapa.Porcentaje == 100);
                    todasLasEtapasAvanceCompletadas = candidatoPerfil[0].EtapasAvance.Any() && candidatoPerfil[0].EtapasAvance
                        .All(etapa => etapa.Avance?.PorcentajeAvance == 100);
                    tieneCaminoAsignado = candidatoPerfil[0].CaminoId.HasValue;
                }
                double promedioAvance = Math.Round(numEtapas > 0 ? (double)totalPorcentaje / numEtapas : 0);
                
                var resumen = new
                {
                    Perfil,
                    candidatoPerfil,
                    detalleEtapaRegistro,
                    promedioAvance,
                    //perfilPersona,
                    persona,
                    todasLasEtapasRegistroCompletadas,
                    todasLasEtapasAvanceCompletadas,
                    tieneCaminoAsignado,
                    //direccion,

                };
                return Ok(resumen);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocurrió un error en el servidor" + e.Message);
            }
        }
        
        //GET api/<CandidatosCHCController>

        [HttpGet("ValidarCandidatoCamino/{perfilId}")]
        public async Task<IActionResult> GetCandidato(int perfilId)
        {
            var candidatoCHC = await _context.CandidatosCHC.FirstOrDefaultAsync(c => c.PerfilId == perfilId);

            var response = new ApiResponse<object>
            {
                StatusCode = 200,
                Success = true,
                Message = "Datos Extraidos",
                Data = new { candidatoCHC, tieneCaminoAsignado = candidatoCHC?.CaminoId != null }
            };
            return Ok(response);
        }
        
        //POST api/<CandidatosCHCController>
        [HttpPost("PostPrimeraRondaDatos")]
        public async Task<ActionResult> CandidatoCHCPersonaPerfilDireccion([FromBody] RegistroContainerCHCViewModel registroContainerChcView)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var personaRequest = registroContainerChcView.PersonaRequest;
                    var direccionRequest = registroContainerChcView.DireccionRequest;
                    var personaPerfilRequest = registroContainerChcView.PersonaPerfilRequest;
                    var candidatoRequest = registroContainerChcView.CandidatosCHCRequest;
                    var candidatoEtapaRegistroCHCRequest = registroContainerChcView.CandidatoEtapaRegistroCHCRequest;

                    if (_context.PerfilPersonaCHC.Any(p => p.PerfilId == personaPerfilRequest.PerfilId) || 
                        _context.CandidatosCHC.Any(c => c.PerfilId == candidatoRequest.PerfilId))
                    {
                        var errorResponse = new
                        {
                            success = false,
                            message = "Ya te Encuentras Registrado!"
                        };
                        return BadRequest(errorResponse);
                    }
                    //Inserta en la tabla Persona
                    var persona = _mapper.Map<Persona>(personaRequest);
                    _context.Persona.Add(persona);
                    await _context.SaveChangesAsync();

                    //inserta en la tabla Direccion
                    var direccion = _mapper.Map<Direccion>(direccionRequest);
                    direccion.PersonaId = persona.Id;
                    _context.Direccion.Add(direccion);
                    await _context.SaveChangesAsync();

                    //insertar en la tabla personalperfilchc
                    var personaPerfil = _mapper.Map<PerfilPersonaCHC>(personaPerfilRequest);
                    personaPerfil.PersonaId = persona.Id;
                    _context.PerfilPersonaCHC.Add(personaPerfil);
                    await _context.SaveChangesAsync();

                    var candidatoCHC = _mapper.Map<CandidatosCHC>(candidatoRequest);
                    _context.CandidatosCHC.Add(candidatoCHC);
                    await _context.SaveChangesAsync();

                    var candidatoEtapaRegistroCHC =
                        _mapper.Map<CandidatoEtapaRegistroCHC>(candidatoEtapaRegistroCHCRequest);
                    candidatoEtapaRegistroCHC.CandidatoId = candidatoCHC.Id;
                    _context.CandidatoEtapaRegistroCHC.Add(candidatoEtapaRegistroCHC);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    var response = new
                    {
                        success = true,
                        message = "Datos insertados correctamente",
                        data = personaRequest
                    };
                    return Ok(response);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    var errorResponse = new
                    {
                        success = false,
                        message = "Error! Al insertar datos en tablas",
                        msg = ex.Message,
                    };
                    return BadRequest(errorResponse);
                }
            }
        }

        [HttpPost("PostSegundaRondaDatos")]
        public async Task<ActionResult> PostSegundaRondaDatos([FromBody] RegistroSegundaRondaViewModel registroSegundaRondaViewModel)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var perfilId = registroSegundaRondaViewModel.PerfilId;

                    var candidato = _context.CandidatosCHC
                        .FirstOrDefault(c => c.PerfilId == perfilId);
                        
                    var persona = _context.PerfilPersonaCHC
                        .Where(ppc => ppc.PerfilId == perfilId)
                        .Select(ppc => ppc.Persona)
                        .FirstOrDefault();
                    
                    var etapa = await _context.CatalogoEtapasCHC
                        .FirstOrDefaultAsync(c => c.CaminoId == registroSegundaRondaViewModel.CaminoId && c.IndiceOrden == 1 
                            && c.Nombre == "Mi camino");
                    
                    if (etapa == null)
                    {
                        return BadRequest(new ApiResponse<string>
                        {
                            StatusCode = 400,
                            Success = false,
                            Message = "No existe etapa a registrar",
                            Data = null
                        });
                    }
                    
                    if (candidato.CaminoId != null)
                    {
                        var errorResponse = new ApiResponse<string>()
                        {
                            StatusCode = (int)HttpStatusCode.BadRequest,
                            Message = "Ya tienes Asignado un Camino",
                            Data = null,
                            Success = false
                        };
                        return BadRequest(errorResponse);
                    }
                    
                    if(perfilId == 0 || candidato == null || persona == null)
                    {
                        var errorResponse = new ApiResponse<string>()
                        {
                            StatusCode = (int)HttpStatusCode.BadRequest,
                            Message = "No se encontro Perfil, Candidato o Persona",
                            Data = null,
                            Success = false
                        };
                        return BadRequest(errorResponse);
                    }

                    var catalogoEtapas = _context.CatalogoEtapaRegistroCHC
                        .Select(c => c.Id).ToList();

                    var avanceEtapas = _context.CandidatoEtapaRegistroCHC
                        .Where(a => a.CandidatoId == candidato.Id)
                        .Select(a => a.RegistroId)
                        .ToList();

                    bool todasLsEtapasConcluidas = catalogoEtapas.All(etapa => avanceEtapas.Contains(etapa));

                    if (!todasLsEtapasConcluidas)
                    {
                        var errorResponse = new ApiResponse<string>()
                        {
                            StatusCode = (int)HttpStatusCode.BadRequest,
                            Message = "Te faltan Etapas Anteriores por concluir",
                            Data = null,
                            Success = false
                        };
                        return BadRequest(errorResponse);
                    }
                    
                    var direccionRequest = registroSegundaRondaViewModel.DireccionViewModel;
                    //inserta en la tabla Direccion
                    var direccion = _mapper.Map<Direccion>(direccionRequest);
                    direccion.PersonaId = persona.Id;
                    _context.Direccion.Add(direccion);
                    await _context.SaveChangesAsync();

                    //actualiza candidatos
                    candidato.CaminoId = registroSegundaRondaViewModel.CaminoId;
                    candidato.CargoPostulacion = registroSegundaRondaViewModel.CargoPostulacion;
                    candidato.FechaIngresoMC = registroSegundaRondaViewModel.FechaIngresoMC;
                    candidato.PuestoEleccionPopularAnteriores =
                        registroSegundaRondaViewModel.PuestoEleccionPopularAnteriores;
                    candidato.CargosDesempeniadosDentroMC = registroSegundaRondaViewModel.CargosDesempeniadosDentroMC;
                    candidato.Comentarios = registroSegundaRondaViewModel.Comentarios;
                    candidato.FechaActualizacionSegundaRonda = DateTime.UtcNow;
                    await _context.SaveChangesAsync();
                    
                    //insertar datos en DomicilioOirRecibirNotificacionesCHC
                    var domicilio = new DomicilioOirRecibirNotificacionesCHC()
                    {
                        CandidatoId = candidato.Id,
                        DireccionId = direccion.Id
                    };
                    _context.DomicilioOirRecibirNotificacionesCHC.Add(domicilio);
                    await _context.SaveChangesAsync();
                    
                    //inserta etapa camino
                    var avanceEtapaCandidato = new AvanceEtapasCandidato()
                    {
                        CandidatoCHCId = candidato.Id,
                        EtapaId = etapa.Id,
                        PorcentajeAvance = 100,
                        ValidoComite = false,
                        FechaUltimoCambio = DateTime.UtcNow,
                        FechaExpiracion = DateTime.UtcNow,
                        Activo = true
                    };
                    
                    _context.AvanceEtapasCandidato.Add(avanceEtapaCandidato);
                    await _context.SaveChangesAsync();
                    
                    await transaction.CommitAsync();

                    var response = new ApiResponse<string>()
                    {
                        StatusCode = 200,
                        Success = true,
                        Message = "Información Actualizada Correctamente",
                        Data = null
                    };
                    return Ok(response);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    var errorResponse = new ApiResponse<string>()
                    {
                        StatusCode = 500,
                        Success = false,
                        Message = ex.Message,
                        Data = null
                    };
                    return StatusCode(500,errorResponse);
                }
            }
        }

        //PUT ActualizarCamino
        [HttpPut("actualizarCamino/{perfilId}/camino/{caminoId}")]
        public async Task<ActionResult> ActualizarCaminoIdPorPerfilId(int perfilId, int caminoId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var candidato = await _context.CandidatosCHC
                        .SingleOrDefaultAsync(c => c.PerfilId == perfilId);

                    if (candidato == null)
                    {
                        return NotFound(new ApiResponse<string>
                        {
                            StatusCode = 404,
                            Success = false,
                            Message = "No se encontro perfil-candidato",
                            Data = null
                        });
                    }

                    if (candidato.CaminoId != null)
                    {
                        return BadRequest(new ApiResponse<string>
                        {
                            StatusCode = 400,
                            Success = false,
                            Message = "El candidato ya tiene asignado un camino",
                            Data = null
                        });
                    }

                    var etapa = await _context.CatalogoEtapasCHC
                        .FirstOrDefaultAsync(c => c.CaminoId == caminoId && c.IndiceOrden == 1 && c.Nombre == "Mi camino");

                    if (etapa == null)
                    {
                        return BadRequest(new ApiResponse<string>
                        {
                            StatusCode = 400,
                            Success = false,
                            Message = "No existe etapa a registrar",
                            Data = null
                        });
                    }


                    var avanceEtapaCandidato = new AvanceEtapasCandidato()
                    {
                        CandidatoCHCId = candidato.Id,
                        EtapaId = etapa.Id,
                        PorcentajeAvance = 100,
                        ValidoComite = false,
                        FechaUltimoCambio = DateTime.UtcNow,
                        FechaExpiracion = DateTime.UtcNow,
                        Activo = true
                    };

                    candidato.CaminoId = caminoId;
                    await _context.SaveChangesAsync();

                    _context.AvanceEtapasCandidato.Add(avanceEtapaCandidato);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return Ok(new ApiResponse<string>
                    {
                        StatusCode = 204,
                        Success = true,
                        Message = "Camino Asignado Correctamente",
                        Data = null
                    });
                }
                catch(Exception ex)
                {
                    await transaction.RollbackAsync();
                    var errorResponse = new
                    {
                        success = false,
                        message = "Error! Al Actualizar datos en tablas",
                        msg = ex.Message,
                    };
                    return BadRequest(errorResponse);
                }
            }
        }

        // POST api/<CandidatosCHCController>
        [HttpPost]
        public async Task<ActionResult<CandidatosCHC>> Post(CandidatosCHCViewModel request)
        {
            CandidatosCHC candidatosCHC = _mapper.Map<CandidatosCHC>(request);
            _context.CandidatosCHC.Add(candidatosCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = candidatosCHC.Id }, candidatosCHC);
        }

        // PUT api/<CandidatosCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CandidatosCHCViewModel request)
        {
            var candidatosCHC = await _context.CandidatosCHC.FindAsync(id);
            _mapper.Map(request, candidatosCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = candidatosCHC.Id }, candidatosCHC);
        }

        [HttpPut("ActualizarCaminoCandidato/{perfilId:int}")]
        public async Task<ActionResult> ActualizarCandidatoPorPerfil( CandidatosCHCViewModel candidatosCHCViewModel ,int perfilId)
        {
            var candidatosCHC = _context.CandidatosCHC.AsTracking()
                .FirstOrDefault(candidato => candidato.PerfilId == perfilId);
            if (candidatosCHC is null)
            {
                return NotFound();
            }

            candidatosCHC = _mapper.Map(candidatosCHCViewModel, candidatosCHC);
            await _context.SaveChangesAsync();
            return Ok();
        }
        
        
        // DELETE api/<CandidatosCHCController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
