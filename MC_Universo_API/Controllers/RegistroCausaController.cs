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
    public class RegistroCausaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public RegistroCausaController(UniversoContext context, IMapper mapper)
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
                causas = _context.Causa.ToList(),
            };
        }

        // GET: api/<RegistroCausaController>/related
        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from registroCausa in _context.Set<RegistroCausa>()

                        join escolaridad in _context.Set<Escolaridad>()
                            on registroCausa.EscolaridadId equals escolaridad.Id

                        join genero in _context.Set<Genero>()
                            on registroCausa.GeneroId equals genero.Id

                        join entidadFederativa in _context.Set<EntidadFederativa>()
                            on registroCausa.EntidadFederativaId equals entidadFederativa.Id

                        let registroCausaCausa = _context.RegistroCausaCausa
                            .Where(c => registroCausa.Id == c.RegistroCausaId)
                            .DefaultIfEmpty()
                            .ToList()

                        select new
                        {
                            registroCausa.Id,
                            registroCausa.Nombre,
                            registroCausa.ApellidoPaterno,
                            registroCausa.ApellidoMaterno,
                            registroCausa.Direccion,
                            registroCausa.FechaNacimiento,
                            escolaridad,
                            genero,
                            entidadFederativa,
                            causas = registroCausaCausa
                                .Select(rcc =>
                                    _context.Causa
                                        .Where(c => rcc.CausaId == c.Id)
                                        .FirstOrDefault()
                                ),
                        };

            return query.ToList();
        }

        [HttpGet("related/{id}")]
        public object GetRelated(int id)
        {
            var query = from registroCausa in _context.Set<RegistroCausa>()

                        join escolaridad in _context.Set<Escolaridad>()
                            on registroCausa.EscolaridadId equals escolaridad.Id

                        join genero in _context.Set<Genero>()
                            on registroCausa.GeneroId equals genero.Id

                        join entidadFederativa in _context.Set<EntidadFederativa>()
                            on registroCausa.EntidadFederativaId equals entidadFederativa.Id

                        let registroCausaCausa = _context.RegistroCausaCausa
                            .Where(c => registroCausa.Id == c.RegistroCausaId)
                            .DefaultIfEmpty()
                            .ToList()

                        where registroCausa.Id == id

                        select new
                        {
                            registroCausa.Id,
                            registroCausa.Nombre,
                            registroCausa.ApellidoPaterno,
                            registroCausa.ApellidoMaterno,
                            registroCausa.Direccion,
                            registroCausa.FechaNacimiento,
                            escolaridad,
                            genero,
                            entidadFederativa,
                            causas = registroCausaCausa
                                .Select(rcc =>
                                    _context.Causa
                                        .Where(c => rcc.CausaId == c.Id)
                                        .FirstOrDefault()
                                ),
                        };

            return query.ToList();
        }

        // GET: api/<RegistroCausaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistroCausa>>> Get()
        {
            return await _context.RegistroCausa.ToListAsync();
        }

        // GET api/<RegistroCausaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistroCausa>> Get(int id)
        {
            var registroCausa = await _context.RegistroCausa.FindAsync(id);

            return registroCausa == null ? NotFound() : registroCausa;
        }

        // POST api/<RegistroCausaController>
        [HttpPost]
        public async Task<ActionResult<RegistroCausa>> Post(RegistroCausaViewModel request)
        {
            RegistroCausa registroCausa = _mapper.Map<RegistroCausa>(request);
            _context.RegistroCausa.Add(registroCausa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroCausa.Id }, registroCausa);
        }

        // PUT api/<RegistroCausaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RegistroCausaViewModel request)
        {
            var registroCausa = await _context.RegistroCausa.FindAsync(id);
            _mapper.Map(request, registroCausa);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = registroCausa.Id }, registroCausa);
        }

    }
}
