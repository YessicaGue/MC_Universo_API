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
    public class PerfilCatalogoRedesSocialesController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilCatalogoRedesSocialesController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PerfilCatalogoRedesSocialesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilCatalogoRedesSociales>>> Get()
        {
            return await _context.PerfilCatalogoRedesSociales.ToListAsync();
        }

        // GET api/<PerfilCatalogoRedesSocialesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilCatalogoRedesSociales>> Get(int id)
        {
            var perfilCatalogoRedesSociales = await _context.PerfilCatalogoRedesSociales.FindAsync(id);

            return perfilCatalogoRedesSociales == null ? NotFound() : perfilCatalogoRedesSociales;
        }

        // GET api/<PerfilCatalogoRedesSocialesController>/5
        [HttpGet("relatedBy/PerfilId/id={id}")]
        public async Task<ActionResult<IEnumerable<PerfilCatalogoRedesSociales>>> RelatedByPerfilId(int id)
        {
            var perfilCatalogoRedesSociales = await _context.PerfilCatalogoRedesSociales
                .Where(p => p.PerfilId == id)
                .ToListAsync();
            return perfilCatalogoRedesSociales == null ? NotFound() : perfilCatalogoRedesSociales;
        }

        // POST api/<PerfilCatalogoRedesSocialesController>
        [HttpPost]
        public async Task<ActionResult<PerfilCatalogoRedesSociales>> Post(PerfilCatalogoRedesSocialesViewModel request)
        {
            PerfilCatalogoRedesSociales perfilCatalogoRedesSociales = _mapper.Map<PerfilCatalogoRedesSociales>(request);
            _context.PerfilCatalogoRedesSociales.Add(perfilCatalogoRedesSociales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilCatalogoRedesSociales.Id }, perfilCatalogoRedesSociales);
        }

        [HttpPost("array/")]
        public async Task<ActionResult<IEnumerable<PerfilCatalogoRedesSociales>>> Post(IEnumerable<PerfilCatalogoRedesSocialesViewModel> datosNuevos)
        {
            try
            {
                List<PerfilCatalogoRedesSociales> nuevosRegistros = new List<PerfilCatalogoRedesSociales>();

                foreach (var datoNuevo in datosNuevos)
                {
                    PerfilCatalogoRedesSociales perfilCatalogoRedesSociales = _mapper.Map<PerfilCatalogoRedesSociales>(datoNuevo);
                    _context.PerfilCatalogoRedesSociales.Add(perfilCatalogoRedesSociales);
                    nuevosRegistros.Add(perfilCatalogoRedesSociales);
                }

                await _context.SaveChangesAsync();

                return CreatedAtAction("Get", nuevosRegistros);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // PUT api/<PerfilCatalogoRedesSocialesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilCatalogoRedesSocialesViewModel request)
        {
            var perfilCatalogoRedesSociales = await _context.PerfilCatalogoRedesSociales.FindAsync(id);
            _mapper.Map(request, perfilCatalogoRedesSociales);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilCatalogoRedesSociales.Id }, perfilCatalogoRedesSociales);
        }

        [HttpPut("array/")]
        public async Task<IActionResult> Put([FromBody] List<PerfilCatalogoRedesSocialesViewModel> requestList)
        {
            // Iterar a través de cada objeto PerfilCatalogoRedesSocialesViewModel en el arreglo
            foreach (var request in requestList)
            {
                // Encontrar el registro correspondiente en la base de datos
                var perfilCatalogoRedesSociales = await _context.PerfilCatalogoRedesSociales
                    .FirstOrDefaultAsync(p => p.PerfilId == request.PerfilId && p.CatalogoRedesSocialesId == request.CatalogoRedesSocialesId);

                // Si el registro no se encuentra, retornar un error 404 (No encontrado)
                if (perfilCatalogoRedesSociales == null)
                {
                    return NotFound();
                }

                // Mapear las propiedades del objeto request al perfilCatalogoRedesSociales existente
                _mapper.Map(request, perfilCatalogoRedesSociales);
            }

            // Guardar los cambios en la base de datos
            await _context.SaveChangesAsync();

            // Retornar una respuesta exitosa 200 (OK) con los datos actualizados
            return Ok(requestList);
        }

        // DELETE api/<PerfilCatalogoRedesSocialesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var perfilCatalogoRedesSociales = await _context.PerfilCatalogoRedesSociales.FindAsync(id);
            if (perfilCatalogoRedesSociales == null)
                return NotFound();

            _context.PerfilCatalogoRedesSociales.Remove(perfilCatalogoRedesSociales);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("update-by-perfil/{id}")]
        public async Task<IActionResult> Update(int id, List<PerfilCatalogoRedesSocialesViewModel>? requestList)
        {
            var perfilCatalogoRedesSociales = await _context.PerfilCatalogoRedesSociales
                .Where(perfil => perfil.PerfilId == id)
                .DefaultIfEmpty()
                .ToListAsync();

            foreach (var perfil in perfilCatalogoRedesSociales)
            {
                if (perfil != null)
                {
                    _context.PerfilCatalogoRedesSociales.Remove(perfil);
                    await _context.SaveChangesAsync();
                }
            }

            if (requestList == null)
            {
                return NoContent();
            }

            foreach (var redSocial in requestList)
            {
                PerfilCatalogoRedesSociales perfilCRS = _mapper.Map<PerfilCatalogoRedesSociales>(redSocial);
                
                _context.PerfilCatalogoRedesSociales.Add(perfilCRS);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }
    }
}
