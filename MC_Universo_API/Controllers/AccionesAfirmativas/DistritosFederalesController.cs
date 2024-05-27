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
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MC_Universo_API.Controllers.AccionesAfirmativas
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritosFederalesController : Controller
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;
     
        public DistritosFederalesController(UniversoContext context, IMapper mapper)
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

        [HttpGet("obtenerCargaInicial")]
        public async Task<ActionResult> getEstadosDistritosCircunscripcionRepresentacion()
        {
            var entidadesFederativas = await _context.EntidadFederativa
                .OrderBy(ef => ef.Id)
                .Select(ef => new
                {
                    id = ef.Id,
                    nombre = ef.Nombre
                })
                .ToListAsync();

            var catalogoRepresentante = await _context.CatalogoRepresentante
                .OrderBy(cr => cr.Id)
                .Select(cr => new
                {
                    id = cr.Id,
                    nombre = cr.NombreCargo + "  |  " + cr.Principio 
                })
                .ToListAsync();

            var datosIniciales = new 
            {
                catalogoRepresentante,
                entidadesFederativas,
            };

            return Ok(datosIniciales);
        }


        [HttpGet("obtenerDistritosPorEstadoId/{idEstado}")]
        public async Task<ActionResult> obtenerDistritoPorId(int idEstado)
        {
            var ditritos = await _context.DistritosFederales
                .Where(df => df.EntidadId == idEstado)
                .OrderBy(df => df.Id)
                .Select(df => new
                {
                    id = df.Id,
                    nombre = df.Nombre + " | " + df.CabeceraDistrital,
                })
                .ToListAsync();

            var resultado = new
            {
                distritos = ditritos
            };

            return Ok(resultado);
        }

        [HttpPost]
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
                            FechaNacimiento = candidatoViewModel.FechaNacimiento,
                            GeneroId = candidatoViewModel.GeneroId
                        };

                        var candidato = new CandidatosCHC
                        {
                            //CircunscripcionId = candidatoViewModel.CircunscripcionId,
                            EstadoId = candidatoViewModel.EstadoId,
                            IdentificacionIndigena = candidatoViewModel.IdentificacionIndigena,
                            Afromexicanas = candidatoViewModel.Afromexicanas,
                            ConDiscapacidad = candidatoViewModel.ConDiscapacidad,
                            DiversidadSexual = candidatoViewModel.DiversidadSexual,
                            EnPobreza = candidatoViewModel.EnPobreza,
                            MexicanosMigrantes = candidatoViewModel.MexicanosMigrantes,
                            RepresentanteId = candidatoViewModel.RepresentanteId,
                            DatoDePrueba = candidatoViewModel.DatoDePrueba,
                            EsSuplente = candidatoViewModel.EsSuplente,
                            FechaInicio = DateTime.UtcNow
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
                    return Ok();
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