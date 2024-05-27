using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoluntarioController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public VoluntarioController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET CAT
        [HttpGet("catalogos")]
        public object GetCatalogos()
        {
            return new
            {
                generos = _context.Genero.ToList(),
                escolaridades = _context.Escolaridad.ToList(),
                motivos = _context.Motivo.ToList(),
                habilidades = _context.Habilidad.ToList(),
                gruposIntereses = _context.GrupoIntereses.ToList(),
                intereses = _context.Interes.ToList()
            };
        }

        // GET: api/<VoluntarioController>/related
        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from voluntario in _context.Set<Voluntario>()

                        join escolaridad in _context.Set<Escolaridad>()
                            on voluntario.EscolaridadId equals escolaridad.Id

                        join genero in _context.Set<Genero>()
                            on voluntario.GeneroId equals genero.Id

                        join motivo in _context.Set<Motivo>()
                            on voluntario.MotivoId equals motivo.Id

                        join entidadFederativa in _context.Set<EntidadFederativa>()
                            on voluntario.EntidadFederativaId equals entidadFederativa.Id

                        join estatusVoluntario in _context.Set<CatalogoEstatusVoluntario>()
                            on voluntario.EstatusVoluntarioId equals estatusVoluntario.Id

                        let voluntarioHabilidades = _context.VoluntarioHabilidad
                            .Where(vh => voluntario.Id == vh.VoluntarioId)
                            .DefaultIfEmpty()
                            .ToList()

                        let voluntarioIntereses = _context.VoluntarioInteres
                            .Where(vi => voluntario.Id == vi.VoluntarioId)
                            .DefaultIfEmpty()
                            .ToList()

                        let voluntarioComentarios = _context.VoluntarioComentario
                            .Where(vc => voluntario.Id == vc.VoluntarioId)
                            .DefaultIfEmpty()
                            .ToList()

                        let voluntarioProgramas = _context.VoluntarioPrograma
                            .Where(vp => voluntario.Id == vp.VoluntarioId)
                            .DefaultIfEmpty()
                            .ToList()

                        select new {
                            voluntario.Id,
                            voluntario.Nombre,
                            voluntario.ApellidoPaterno,
                            voluntario.ApellidoMaterno,
                            voluntario.Direccion,
                            voluntario.CorreoElectronico,
                            voluntario.Telefono,
                            voluntario.FechaNacimiento,
                            escolaridad,
                            genero,
                            motivo,
                            entidadFederativa,
                            estatusVoluntario,
                            comentarios = voluntarioComentarios,
                            habilidades = voluntarioHabilidades
                                .Select(vh =>
                                    _context.Habilidad
                                        .Where(h => vh.HabilidadId == h.Id)
                                        .FirstOrDefault()
                                ),
                            intereses = voluntarioIntereses
                                .Select(vi =>
                                    _context.Interes
                                        .Where(i => vi.InteresId == i.Id)
                                        .FirstOrDefault()
                                ),
                            programas = voluntarioProgramas
                                .Select(vp =>
                                    _context.Programa
                                        .Where(p => vp.ProgramaId == p.Id)
                                        .FirstOrDefault()
                                ),
                        };

            return query.ToList();
        }

        // GET: api/<VoluntarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Voluntario>>> Get()
        {
            return await _context.Voluntario.ToListAsync();
        }

        // GET api/<VoluntarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Voluntario>> Get(int id)
        {
            var voluntario = await _context.Voluntario.FindAsync(id);

            return voluntario == null ? NotFound() : voluntario;
        }

        // POST api/<VoluntarioController>
        [HttpPost]
        public async Task<ActionResult<Voluntario>> Post(VoluntarioViewModel request)
        {
            Voluntario voluntario = _mapper.Map<Voluntario>(request);
            _context.Voluntario.Add(voluntario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntario.Id }, voluntario);
        }

        // PUT api/<VoluntarioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, VoluntarioViewModel request)
        {
            var voluntario = await _context.Voluntario.FindAsync(id);
            _mapper.Map(request, voluntario);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = voluntario.Id }, voluntario);
        }

    }
}
