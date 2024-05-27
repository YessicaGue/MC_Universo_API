using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.AccionesAfirmativas;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels.AccionesAfirmativas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers.AccionesAfirmativas
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatosAccionesAfirmativasController : Controller
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;
     
        public CandidatosAccionesAfirmativasController(UniversoContext context, IMapper mapper)
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

        [HttpPost("AltaCandidatos")]
        public async Task<ActionResult> AltaCandidatoPersona([FromBody] List<CandidatoPersonaViewModel> candidatoPersonaViewModel)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach (var candidatoViewModel  in candidatoPersonaViewModel)
                    {
                        var persona = new Persona
                        {
                            Nombre = candidatoViewModel.Nombre,
                            ApellidoPaterno = candidatoViewModel.ApellidoPaterno,
                            ApellidoMaterno = candidatoViewModel.ApellidoMaterno,
                            GeneroId = candidatoViewModel.GeneroId,
                            Curp = candidatoViewModel.Curp,
                            ClaveElector = candidatoViewModel.ClaveElector
                            
                        };

                        var candidato = new CandidatosCHC
                        {
                            NumeroLista = candidatoViewModel.NumeroLista,

                            CircunscripcionId = _context.EstadoCircunscripcion
                            .Where(c => c.EntidadId == candidatoViewModel.EstadoId)
                            .Select(c => c.CircunscripcionId)
                            .FirstOrDefault(),
                            RepresentanteId = candidatoViewModel.RepresentanteId,
                            EstadoId = candidatoViewModel.EstadoId,
                            DistritoId = candidatoViewModel.DistritoId,
                            IdentificacionIndigena = candidatoViewModel.IdentificacionIndigena,
                            Afromexicanas = candidatoViewModel.Afromexicanas,
                            ConDiscapacidad = candidatoViewModel.ConDiscapacidad,
                            DiversidadSexual = candidatoViewModel.DiversidadSexual,
                            MexicanosMigrantes = candidatoViewModel.MexicanosMigrantes,
                            DatoDePrueba = false,
                            EsSuplente = false,
                            FechaInicio = DateTime.UtcNow,
                            EsAccionesAfirmativas = true,
                        };

                        _context.CandidatosCHC.Add(candidato);
                        await _context.SaveChangesAsync();
                        
                        _context.Persona.Add(persona);
                        await _context.SaveChangesAsync();
                        
                        var candidatoPersona = new CandidatoPersona
                        {
                            PersonaId = persona.Id,
                            CandidatoId = candidato.Id
                        };

                        _context.CandidatoPersona.Add(candidatoPersona);
                        await _context.SaveChangesAsync();
                        
                    }
                    await transaction.CommitAsync();
                    var response = new ApiResponse<string>
                    {
                        Success = true,
                        StatusCode = 200,
                        Message = "Datos Enviados",
                    };

                    return Ok(response);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    var errorResponse = new ApiResponse<string>()
                    {
                        StatusCode = 500,
                        Message = "Error al guardar",
                        Success = false
                    };
                    return BadRequest(errorResponse);
                }
            }
        }
        
    }
}