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
    public class EscuchaController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public EscuchaController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<EscuchaController>
        [HttpGet("related")]
        public object GetRelated()
        {
            var query = from escuchas in _context.Set<Escucha>()

                        let escuchaFormularioTemasInteres = _context.EscuchaFormularioTemasInteres
                            .Where(efti => escuchas.Id == efti.EscuchaId)
                            .FirstOrDefault()

                        let formularioTemasInteres = _context.FormularioTemasInteres
                            .Where(fti => escuchaFormularioTemasInteres.FormularioTemasInteresId == fti.Id)
                            .FirstOrDefault()

                        let formularioTemasInteresCatalogoCausasLanding = _context.FormularioTemasInteresCatalogoCausasLanding
                            .Where(fticcl => formularioTemasInteres.Id == fticcl.FormularioTemasInteresId)
                            .DefaultIfEmpty()
                            .ToList()

                        let causasLanding = formularioTemasInteresCatalogoCausasLanding
                            .Select(fticcl =>
                                _context.CatalogoCausasLanding
                                    .Where(ccl => fticcl.CatalogoCausasLandingId == ccl.Id)
                                    .FirstOrDefault()
                            )
                            .DefaultIfEmpty()
                            .ToList()

                        select new
                        {
                            id = escuchas.Id,
                            respuesta = escuchas.Respuesta,
                            fechaCreacion = escuchas.FechaCreacion,
                            formularioTemasInteres,
                            causasLanding
                        };

            return query;
        }

        // GET: api/<EscuchaController>
        [HttpGet("related/{id}")]
        public object GetRelatedById(int id)
        {
            var query = from escuchas in _context.Set<Escucha>()

                        let escuchaFormularioTemasInteres = _context.EscuchaFormularioTemasInteres
                            .Where(efti => escuchas.Id == efti.EscuchaId)
                            .FirstOrDefault()

                        let formularioTemasInteres = _context.FormularioTemasInteres
                            .Where(fti => escuchaFormularioTemasInteres.FormularioTemasInteresId == fti.Id)
                            .FirstOrDefault()

                        let formularioTemasInteresCatalogoCausasLanding = _context.FormularioTemasInteresCatalogoCausasLanding
                            .Where(fticcl => formularioTemasInteres.Id == fticcl.FormularioTemasInteresId)
                            .DefaultIfEmpty()
                            .ToList()

                        let causasLanding = formularioTemasInteresCatalogoCausasLanding
                            .Select(fticcl =>
                                _context.CatalogoCausasLanding
                                    .Where(ccl => fticcl.CatalogoCausasLandingId == ccl.Id)
                                    .FirstOrDefault()
                            )
                            .DefaultIfEmpty()
                            .ToList()

                        where escuchas.Id == id

                        select new
                        {
                            id = escuchas.Id,
                            respuesta = escuchas.Respuesta,
                            fechaCreacion = escuchas.FechaCreacion,
                            formularioTemasInteres,
                            causasLanding
                        };

            return query;
        }

        // GET: api/<EscuchaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Escucha>>> Get()
        {
            return await _context.Escucha.ToListAsync();
        }

        // GET api/<EscuchaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Escucha>> Get(int id)
        {
            var escucha = await _context.Escucha.FindAsync(id);

            return escucha == null ? NotFound() : escucha;
        }

        // POST api/<EscuchaController>
        [HttpPost]
        public async Task<ActionResult<Escucha>> Post(EscuchaViewModel request)
        {
            Escucha escucha = _mapper.Map<Escucha>(request);
            _context.Escucha.Add(escucha);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = escucha.Id }, escucha);
        }

    }
}
