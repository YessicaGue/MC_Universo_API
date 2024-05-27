using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers.CaminoHeroeCiudadano
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoEtapaRegistroCHCController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public CandidatoEtapaRegistroCHCController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("validarEtapaRegistro/{Id}/etapa/{etapaId}")]
        public IActionResult ValidarEtapaRegistro(int Id, int etapaId)
        {
            var perfil = _context.Perfil.FirstOrDefault(p => p.Id == Id);
            bool perfilExiste = perfil != null;
            if (perfil == null)
            {
                return BadRequest("El perfil No Existe.");
            }
            bool existeEnCandidatosCHC = _context.CandidatosCHC.Any(cc => cc.PerfilId == Id);

            bool haRealizadoEtapa = _context.CandidatoEtapaRegistroCHC
                .Any(ce => ce.CandidatosCHC.PerfilId == Id && ce.CatalogoEtapaRegistroCHC.Id == etapaId);

            if (!existeEnCandidatosCHC)
            {
                return Ok
                (new
                {
                    perfilExiste,
                    haRealizadoEtapa = false,
                    InformacionEtapa = "No se econtró informacion para este perfil en CandidatoCHC.",
                    existeEnCandidatosCHC,
                    realizoEtapaAnterior = false

                });
            }


            var candidatoCHC = _context.CandidatosCHC
                .FirstOrDefault(cc => cc.PerfilId == Id);

            if (haRealizadoEtapa && etapaId == 1)
            {
                var etapaActual = _context.CatalogoEtapaRegistroCHC.FirstOrDefault(e => e.Id == etapaId);

                var etapaAnterior = _context.CatalogoEtapaRegistroCHC
                    .OrderBy(e => e.IndiceOrden)
                    .FirstOrDefault(e => e.IndiceOrden < etapaActual.IndiceOrden);

                var etapaSiguiente = _context.CatalogoEtapaRegistroCHC
                    .OrderBy(e => e.IndiceOrden)
                    .FirstOrDefault(e => e.IndiceOrden > etapaActual.IndiceOrden);

                if (candidatoCHC != null)
                {
                    var personaPerfilCHC = _context.PerfilPersonaCHC
                        .FirstOrDefault(ppc => ppc.PerfilId == Id
                                               && ppc.Persona != null);
                    if (personaPerfilCHC != null)
                    {
                        var personaID = personaPerfilCHC.PersonaId;
                        var persona = _context.Persona.FirstOrDefault(p => p.Id == personaID);
                        var direccion = _context.Direccion.FirstOrDefault(d => d.PersonaId == personaID);

                        return Ok(new
                        {
                            perfilExiste,
                            haRealizadoEtapa = true,
                            InformacionEtapa = "El perfil ha realizado la etapa",
                            Perfil = perfil,
                            CandidatoCHC = candidatoCHC,
                            Persona = persona,
                            Direccion = direccion,
                            EtapaActual = _context.CatalogoEtapaRegistroCHC.FirstOrDefault(e => e.Id == etapaId),
                            EtapaAnterior = etapaAnterior,
                            EtapaSiguiente = etapaSiguiente
                        });
                    }
                }
            }

            if (etapaId == 3)
            {
                bool documentoAceptado = false;

                bool haSubidoArchivo = _context.DocumentoCandidatosCHC.Any(dc => dc.CandidatoCHCId == candidatoCHC.Id);

                bool etapa1Completada = _context.CandidatoEtapaRegistroCHC
                    .Any(ce => ce.CandidatosCHC.PerfilId == Id && ce.CatalogoEtapaRegistroCHC.Id == 1);

                bool etapa2Completada = _context.CandidatoEtapaRegistroCHC
                    .Any(ce => ce.CandidatosCHC.PerfilId == Id && ce.CatalogoEtapaRegistroCHC.Id == 2);

                bool etapasPendiente = !etapa1Completada && !etapa2Completada;

                string estatusNombre = "Desconocido";
                if (haSubidoArchivo)
                {
                    var documento = _context.DocumentoCandidatosCHC
                        .FirstOrDefault(dc => dc.CandidatoCHCId == candidatoCHC.Id && dc.DocumentoEligibilidadCHCId == 1);

                    documentoAceptado = _context.DocumentoCandidatosCHC
                        .Any(dc => dc.CandidatoCHCId == candidatoCHC.Id && dc.EstatusDocumentoEligibilidadCHCId == 4
                                                                        && dc.DocumentoEligibilidadCHCId == 1
                        );

                    var estatus = _context.CatalogoEstatusDocumentosEligibilidadCHC.FirstOrDefault(e => e.Id == documento.EstatusDocumentoEligibilidadCHCId);
                    estatusNombre = estatus.Nombre;

                }
                return Ok(new
                {
                    perfilExiste,
                    existeEnCandidatosCHC,
                    haRealizadoEtapa,
                    haSubidoArchivo,
                    documentoAceptado,
                    etapa1Completada,
                    etapa2Completada,
                    estatusNombre,
                    etapasPendiente,
                });
            }

            if (etapaId == 4)
            {
                var realizoEtapaAnterior = false;
                var aproboExamen = false;
                var catalogoEtapaRegistro = _context.CatalogoEtapaRegistroCHC
                    .FirstOrDefault(cer => cer.Id == etapaId);
                if (catalogoEtapaRegistro!=null)
                {
                    var indiceOrdern = catalogoEtapaRegistro.IndiceOrden;
                    realizoEtapaAnterior = _context.CandidatoEtapaRegistroCHC
                        .Any(cerc => cerc.CatalogoEtapaRegistroCHC.IndiceOrden == indiceOrdern - 1 
                        && cerc.CandidatoId == candidatoCHC.Id);
                }

                var examen = _context.CandidatosExamenes
                    .Where(ce => ce.CandidatoCHCId == candidatoCHC.Id
                                 && ce.ExamenCHCId == 3)
                    .OrderByDescending(ce => ce.FechaUltimoIntento)
                    .FirstOrDefault();
                if (examen != null)
                {
                    aproboExamen = examen.EsAprobado;
                }


                return Ok(new
                {
                    perfilExiste,
                    existeEnCandidatosCHC,
                    haRealizadoEtapa,
                    realizoEtapaAnterior,
                    examen,
                    aproboExamen,
                    realizoExamen = examen==null ? false:true
                });

            }
            return Ok(new
            {
                perfilExiste,
                existeEnCandidatosCHC,
                haRealizadoEtapa
            });
        }


        // GET: api/<CandidatoEtapasRegistroCHCController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidatoEtapaRegistroCHC>>> Get()
        {
            return await _context.CandidatoEtapaRegistroCHC.ToListAsync();
        }

        // GET api/<CandidatoEtapasRegistroCHCController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CandidatoEtapaRegistroCHC>> Get(int id)
        {
            var candidatoEtapaRegistroCHC = await _context.CandidatoEtapaRegistroCHC.FindAsync(id);

            return candidatoEtapaRegistroCHC == null ? NotFound() : candidatoEtapaRegistroCHC;
        }
        // POST api/<CandidatoEtapasRegistroCHCController>
        [HttpPost]
        public async Task<ActionResult<CandidatoEtapaRegistroCHC>> Post(CandidatoEtapaRegistroCHCViewModel request)
        {
            CandidatoEtapaRegistroCHC candidatoEtapaRegistroCHC = _mapper.Map<CandidatoEtapaRegistroCHC>(request);
            _context.CandidatoEtapaRegistroCHC.Add(candidatoEtapaRegistroCHC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = candidatoEtapaRegistroCHC.Id }, candidatoEtapaRegistroCHC);
        }

        [HttpPost("perfilId/{Id}")]
        public async Task<ActionResult<CandidatoEtapaRegistroCHC>> PostByPerfilId(CandidatoEtapaRegistroCHCViewModel request, int Id)
        {
            try
            {
                var candidato = _context.CandidatosCHC.FirstOrDefault(c => c.PerfilId == Id);
                if (candidato == null)
                {
                    return NotFound("No se encontro Candidato");
                }

                var existeCandidato = _context.CandidatoEtapaRegistroCHC.Any(r => r.CandidatoId == candidato.Id
                    && r.RegistroId == request.RegistroId);
                if (existeCandidato)
                {
                    return BadRequest("Ya Realizo esta etapa");
                }

                var nuevoRegistro = new CandidatoEtapaRegistroCHC()
                {
                    CandidatoId = candidato.Id,
                    RegistroId = request.RegistroId,
                    Activo = request.Activo,
                    FechaAlta = request.FechaAlta
                };
                _context.CandidatoEtapaRegistroCHC.Add(nuevoRegistro);
                await _context.SaveChangesAsync();
                return Ok(new
                {
                    success = true,
                    message = "Datos insertados correctamente",
                    data = nuevoRegistro
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new
                    {
                        success = false,
                        message = "Ocurrió un error durante la insercion",
                        error = ex.Message,
                    });
            }
        }


        // PUT api/<CandidatoEtapasRegistroCHCController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CandidatoEtapaRegistroCHCViewModel request)
        {
            var candidatoEtapaRegistroCHC = await _context.CandidatoEtapaRegistroCHC.FindAsync(id);
            _mapper.Map(request, candidatoEtapaRegistroCHC);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = candidatoEtapaRegistroCHC.Id }, candidatoEtapaRegistroCHC);
        }

        // DELETE api/<CandidatoEtapasRegistroCHCController>/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        //
        // }
    }
}
