using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels;
using MC_Universo_API.ViewModels.TemasInteresesLading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioTemasInteresCatalogoCausasLandingController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public FormularioTemasInteresCatalogoCausasLandingController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<FormularioTemasInteresCatalogoCausasLandingController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormularioTemasInteresCatalogoCausasLanding>>> Get()
        {
            return await _context.FormularioTemasInteresCatalogoCausasLanding.ToListAsync();
        }

        // GET api/<FormularioTemasInteresCatalogoCausasLandingController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FormularioTemasInteresCatalogoCausasLanding>> Get(int id)
        {
            var formularioTemasInteresCatalogoCausasLanding = await _context.FormularioTemasInteresCatalogoCausasLanding.FindAsync(id);

            return formularioTemasInteresCatalogoCausasLanding == null ? NotFound() : formularioTemasInteresCatalogoCausasLanding;
        }

        // GET api/<FormularioTemasInteresCatalogoCausasLandingController>/5
        [HttpGet("formulario={id}")]
        public async Task<ActionResult<IEnumerable<FormularioTemasInteresCatalogoCausasLanding>>> GetByFormulario(int id)
        {
            var formularioTemasInteresCatalogoCausasLanding = await _context.FormularioTemasInteresCatalogoCausasLanding
                    .Where(fticcl => fticcl.FormularioTemasInteresId == id)
                    .DefaultIfEmpty()
                    .ToListAsync();

            return formularioTemasInteresCatalogoCausasLanding == null ? NotFound() : formularioTemasInteresCatalogoCausasLanding;
        }

        // POST api/<FormularioTemasInteresCatalogoCausasLandingController>
        [HttpPost]
        public async Task<ActionResult<FormularioTemasInteresCatalogoCausasLanding>> Post(FormularioTemasInteresCatalogoCausasLandingViewModel request)
        {
            FormularioTemasInteresCatalogoCausasLanding formularioTemasInteresCatalogoCausasLanding = _mapper.Map<FormularioTemasInteresCatalogoCausasLanding>(request);
            _context.FormularioTemasInteresCatalogoCausasLanding.Add(formularioTemasInteresCatalogoCausasLanding);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = formularioTemasInteresCatalogoCausasLanding.Id }, formularioTemasInteresCatalogoCausasLanding);
        }
        
        
        // POST api/<FormularioTemasInteresCatalogoCausasLandingController> Formulario y Causas
        [HttpPost("AltaFormularioTemasInteresCausas")]
        public async Task<ActionResult<ApiResponse<FormularioTemasInteres>>> Post([FromBody]ContenedorFormularioTemasInteresesCausasLandingViewModel request)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    FormularioTemasInteres formularioTemasInteres =
                        _mapper.Map<FormularioTemasInteres>(request.FormularioTemasInteresViewModel);
                    _context.FormularioTemasInteres.Add(formularioTemasInteres);
                    await _context.SaveChangesAsync();

                    if (request.CatalogoCausasLandingViewModels.Count > 0)
                    {
                        foreach (var causasLanding in request.CatalogoCausasLandingViewModels)
                        {
                            var causasLandingFormulario = new FormularioTemasInteresCatalogoCausasLanding
                            {
                                FormularioTemasInteresId = formularioTemasInteres.Id,
                                CatalogoCausasLandingId = causasLanding.Id
                            };

                            _context.FormularioTemasInteresCatalogoCausasLanding.Add(causasLandingFormulario);
                            await _context.SaveChangesAsync();
                        }   
                    }
                    await transaction.CommitAsync();
                    var response = new ApiResponse<FormularioTemasInteres>
                    {
                        Success = true,
                        StatusCode = 200,
                        Message = "Datos Enviados",
                        Data = formularioTemasInteres,
                    };

                    return Ok(response);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
        
        // PUT api/<FormularioTemasInteresCatalogoCausasLandingController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, FormularioTemasInteresCatalogoCausasLandingViewModel request)
        {
            var formularioTemasInteresCatalogoCausasLanding = await _context.FormularioTemasInteresCatalogoCausasLanding.FindAsync(id);
            _mapper.Map(request, formularioTemasInteresCatalogoCausasLanding);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = formularioTemasInteresCatalogoCausasLanding.Id }, formularioTemasInteresCatalogoCausasLanding);
        }
    }
}
