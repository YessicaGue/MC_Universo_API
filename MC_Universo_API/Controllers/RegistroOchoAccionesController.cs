using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroOchoAccionesController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RegistroOchoAccionesController(UniversoContext context, IMapper mapper)
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
                catalogoOchoAcciones = _context.CatalogoOchoAcciones.ToList(),
                catalogoPreguntasOchoAcciones = _context.CatalogoPreguntasOchoAcciones.ToList(),
            };
        }

        // GET: api/<RegistroOchoAccionesController>/related
        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from registroOchoAcciones in _context.Set<RegistroOchoAcciones>()

                        join genero in _context.Set<Genero>()
                            on registroOchoAcciones.GeneroId equals genero.Id

                        let escolaridad = _context.Escolaridad
                            .Where(e => registroOchoAcciones.EscolaridadId == e.Id )
                            .FirstOrDefault()

                        let motivo = _context.Motivo
                            .Where(m => registroOchoAcciones.MotivoId == m.Id )
                            .FirstOrDefault()

                        join entidadFederativa in _context.Set<EntidadFederativa>()
                            on registroOchoAcciones.EntidadFederativaId equals entidadFederativa.Id

                        join estatusRegistro in _context.Set<CatalogoEstatusVoluntario>()
                            on registroOchoAcciones.EstatusRegistroId equals estatusRegistro.Id

                        let registroOchoAccionesHabilidades = _context.RegistroOchoAccionesHabilidad
                            .Where(roah => registroOchoAcciones.Id == roah.RegistroOchoAccionesId)
                            .DefaultIfEmpty()
                            .ToList()

                        let registroOchoAccionesIntereses = _context.RegistroOchoAccionesInteres
                            .Where(roai => registroOchoAcciones.Id == roai.RegistroOchoAccionesId)
                            .DefaultIfEmpty()
                            .ToList()

                        let registroOchoAccionesCatalogoOchoAcciones = _context.RegistroOchoAccionesCatalogoOchoAcciones
                            .Where(roacoa => registroOchoAcciones.Id == roacoa.RegistroOchoAccionesId)
                            .DefaultIfEmpty()
                            .ToList()

                        let respuestasOchoAcciones = _context.RespuestasOchoAcciones
                            .Where(roa => registroOchoAcciones.Id == roa.RegistroOchoAccionesId)
                            .DefaultIfEmpty()
                            .ToList()

                        select new
                        {
                            registroOchoAcciones.Id,
                            registroOchoAcciones.Nombre,
                            registroOchoAcciones.ApellidoPaterno,
                            registroOchoAcciones.ApellidoMaterno,
                            registroOchoAcciones.Direccion,
                            registroOchoAcciones.FechaNacimiento,
                            escolaridad,
                            genero,
                            motivo,
                            entidadFederativa,
                            estatusRegistro,
                            habilidades = registroOchoAccionesHabilidades
                                .Select(roah =>
                                    _context.Habilidad
                                        .Where(h => roah.HabilidadId == h.Id)
                                        .FirstOrDefault()
                                ),
                            intereses = registroOchoAccionesIntereses
                                .Select(roai =>
                                    _context.Interes
                                        .Where(i => roai.InteresId == i.Id)
                                        .FirstOrDefault()
                                ),
                            ochoAcciones = registroOchoAccionesCatalogoOchoAcciones
                                .Select(roacoa =>
                                    _context.CatalogoOchoAcciones
                                        .Where(coa => roacoa.CatalogoOchoAccionesId == coa.Id)
                                        .FirstOrDefault()
                                ),
                            respuestas = respuestasOchoAcciones
                                .Select(roa =>
                                    new {
                                        pregunta = _context.CatalogoPreguntasOchoAcciones
                                            .Where(cpoa => roa.PreguntaId == cpoa.Id)
                                            .FirstOrDefault(),
                                        respuesta = roa.Respuesta
                                    }
                                ),
                        };

            return query.ToList();
        }

        [HttpGet("related/{id}")]
        public object GetRelated(int id)
        {
            var query = from registroOchoAcciones in _context.Set<RegistroOchoAcciones>()

                        join genero in _context.Set<Genero>()
                            on registroOchoAcciones.GeneroId equals genero.Id

                        let escolaridad = _context.Escolaridad
                            .Where(e => registroOchoAcciones.EscolaridadId == e.Id)
                            .FirstOrDefault()

                        let motivo = _context.Motivo
                            .Where(m => registroOchoAcciones.MotivoId == m.Id)
                            .FirstOrDefault()

                        join entidadFederativa in _context.Set<EntidadFederativa>()
                            on registroOchoAcciones.EntidadFederativaId equals entidadFederativa.Id

                        join estatusRegistro in _context.Set<CatalogoEstatusVoluntario>()
                            on registroOchoAcciones.EstatusRegistroId equals estatusRegistro.Id

                        let registroOchoAccionesHabilidades = _context.RegistroOchoAccionesHabilidad
                            .Where(roah => registroOchoAcciones.Id == roah.RegistroOchoAccionesId)
                            .DefaultIfEmpty()
                            .ToList()

                        let registroOchoAccionesIntereses = _context.RegistroOchoAccionesInteres
                            .Where(roai => registroOchoAcciones.Id == roai.RegistroOchoAccionesId)
                            .DefaultIfEmpty()
                            .ToList()

                        let registroOchoAccionesCatalogoOchoAcciones = _context.RegistroOchoAccionesCatalogoOchoAcciones
                            .Where(roacoa => registroOchoAcciones.Id == roacoa.RegistroOchoAccionesId)
                            .DefaultIfEmpty()
                            .ToList()

                        let respuestasOchoAcciones = _context.RespuestasOchoAcciones
                            .Where(roa => registroOchoAcciones.Id == roa.RegistroOchoAccionesId)
                            .DefaultIfEmpty()
                            .ToList()

                        where registroOchoAcciones.Id == id

                        select new
                        {
                            registroOchoAcciones.Id,
                            registroOchoAcciones.Nombre,
                            registroOchoAcciones.ApellidoPaterno,
                            registroOchoAcciones.ApellidoMaterno,
                            registroOchoAcciones.Direccion,
                            registroOchoAcciones.FechaNacimiento,
                            escolaridad,
                            genero,
                            motivo,
                            entidadFederativa,
                            estatusRegistro,
                            habilidades = registroOchoAccionesHabilidades
                                .Select(roah =>
                                    _context.Habilidad
                                        .Where(h => roah.HabilidadId == h.Id)
                                        .FirstOrDefault()
                                ),
                            intereses = registroOchoAccionesIntereses
                                .Select(roai =>
                                    _context.Interes
                                        .Where(i => roai.InteresId == i.Id)
                                        .FirstOrDefault()
                                ),
                            ochoAcciones = registroOchoAccionesCatalogoOchoAcciones
                                .Select(roacoa =>
                                    _context.CatalogoOchoAcciones
                                        .Where(coa => roacoa.CatalogoOchoAccionesId == coa.Id)
                                        .FirstOrDefault()
                                ),
                            respuestas = respuestasOchoAcciones
                                .Select(roa =>
                                    new {
                                        pregunta = _context.CatalogoPreguntasOchoAcciones
                                            .Where(cpoa => roa.PreguntaId == cpoa.Id)
                                            .FirstOrDefault(),
                                        respuesta = roa.Respuesta
                                    }
                                ),
                        };

            return query.First();
        }

        // GET: api/<RegistroOchoAccionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroOchoAcciones>>> Get()
        {
            return await _context.RegistroOchoAcciones.ToListAsync();
        }

        // GET api/<RegistroOchoAccionesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroOchoAcciones>> Get(int id)
        {
            var registroOchoAcciones = await _context.RegistroOchoAcciones.FindAsync(id);

            return registroOchoAcciones == null ? NotFound() : registroOchoAcciones;
        }

        // POST api/<RegistroOchoAccionesController>
        [HttpPost]
        public async Task<ActionResult<RegistroOchoAcciones>> Post(RegistroOchoAccionesViewModel request)
        {
            RegistroOchoAcciones registroOchoAcciones = _mapper.Map<RegistroOchoAcciones>(request);
            _context.RegistroOchoAcciones.Add(registroOchoAcciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroOchoAcciones.Id }, registroOchoAcciones);
        }

        // PUT api/<RegistroOchoAccionesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RegistroOchoAccionesViewModel request)
        {
            var registroOchoAcciones = await _context.RegistroOchoAcciones.FindAsync(id);
            _mapper.Map(request, registroOchoAcciones);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroOchoAcciones.Id }, registroOchoAcciones);
        }

    }
}
