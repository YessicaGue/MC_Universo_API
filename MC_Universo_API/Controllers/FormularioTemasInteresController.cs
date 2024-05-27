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
    public class FormularioTemasInteresController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public FormularioTemasInteresController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<FormularioTemasInteresController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormularioTemasInteres>>> Get()
        {
            return await _context.FormularioTemasInteres.ToListAsync();
        }

        // GET api/<FormularioTemasInteresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FormularioTemasInteres>> Get(int id)
        {
            var formularioTemasInteres = await _context.FormularioTemasInteres.FindAsync(id);

            return formularioTemasInteres == null ? NotFound() : formularioTemasInteres;
        }

        // POST api/<FormularioTemasInteresController>
        [HttpPost]
        public async Task<ActionResult<FormularioTemasInteres>> Post(FormularioTemasInteresViewModel request)
        {
            FormularioTemasInteres formularioTemasInteres = _mapper.Map<FormularioTemasInteres>(request);
            _context.FormularioTemasInteres.Add(formularioTemasInteres);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = formularioTemasInteres.Id }, formularioTemasInteres);
        }

        // PUT api/<FormularioTemasInteresController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, FormularioTemasInteresViewModel request)
        {
            var formularioTemasInteres = await _context.FormularioTemasInteres.FindAsync(id);
            _mapper.Map(request, formularioTemasInteres);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = formularioTemasInteres.Id }, formularioTemasInteres);
        }
    }
}
