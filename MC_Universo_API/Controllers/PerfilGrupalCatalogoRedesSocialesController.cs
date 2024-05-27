using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilGrupalCatalogoRedesSocialesController : Controller
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public PerfilGrupalCatalogoRedesSocialesController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PerfilGrupalCatalogoRedesSocialesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilGrupalCatalogoRedesSociales>>> Get()
        {
            return await _context.PerfilGrupalCatalogoRedesSociales.ToListAsync();
        }

        // GET api/<PerfilGrupalCatalogoRedesSocialesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilGrupalCatalogoRedesSociales>> Get(int id)
        {
            var perfilGrupalCatalogoRedesSociales = await _context.PerfilGrupalCatalogoRedesSociales.FindAsync(id);

            return perfilGrupalCatalogoRedesSociales == null ? NotFound() : perfilGrupalCatalogoRedesSociales;
        }

        // GET api/<PerfilGrupalCatalogoRedesSocialesController>/5
        [HttpGet("relatedBy/PerfilGrupalId/id={id}")]
        public async Task<ActionResult<IEnumerable<PerfilGrupalCatalogoRedesSociales>>> RelatedByPerfilGrupalId(int id)
        {
            var perfilGrupalCatalogoRedesSociales = await _context.PerfilGrupalCatalogoRedesSociales
                .Where(p => p.PerfilGrupalId == id)
                .ToListAsync();
            return perfilGrupalCatalogoRedesSociales == null ? NotFound() : perfilGrupalCatalogoRedesSociales;
        }

        // POST api/<PerfilGrupalCatalogoRedesSocialesController>
        [HttpPost]
        public async Task<ActionResult<PerfilGrupalCatalogoRedesSociales>> Post(PerfilGrupalCatalogoRedesSocialesViewModel request)
        {
            PerfilGrupalCatalogoRedesSociales perfilGrupalCatalogoRedesSociales = _mapper.Map<PerfilGrupalCatalogoRedesSociales>(request);
            _context.PerfilGrupalCatalogoRedesSociales.Add(perfilGrupalCatalogoRedesSociales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilGrupalCatalogoRedesSociales.Id }, perfilGrupalCatalogoRedesSociales);
        }

        [HttpPost("array/")]
        public async Task<ActionResult<IEnumerable<PerfilGrupalCatalogoRedesSociales>>> Post(IEnumerable<PerfilGrupalCatalogoRedesSocialesViewModel> datosNuevos)
        {
            try
            {
                List<PerfilGrupalCatalogoRedesSociales> nuevosRegistros = new List<PerfilGrupalCatalogoRedesSociales>();

                foreach (var datoNuevo in datosNuevos)
                {
                    PerfilGrupalCatalogoRedesSociales perfilGrupalCatalogoRedesSociales = _mapper.Map<PerfilGrupalCatalogoRedesSociales>(datoNuevo);
                    _context.PerfilGrupalCatalogoRedesSociales.Add(perfilGrupalCatalogoRedesSociales);
                    nuevosRegistros.Add(perfilGrupalCatalogoRedesSociales);
                }

                await _context.SaveChangesAsync();

                return CreatedAtAction("Get", nuevosRegistros);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // PUT api/<PerfilGrupalCatalogoRedesSocialesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PerfilGrupalCatalogoRedesSocialesViewModel request)
        {
            var perfilGrupalCatalogoRedesSociales = await _context.PerfilGrupalCatalogoRedesSociales.FindAsync(id);
            _mapper.Map(request, perfilGrupalCatalogoRedesSociales);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilGrupalCatalogoRedesSociales.Id }, perfilGrupalCatalogoRedesSociales);
        }

        [HttpPut("array/")]
        public async Task<IActionResult> Put([FromBody] List<PerfilGrupalCatalogoRedesSocialesViewModel> requestList)
        {
            // Iterar a través de cada objeto PerfilGrupalCatalogoRedesSocialesViewModel en el arreglo
            foreach (var request in requestList)
            {
                // Encontrar el registro correspondiente en la base de datos
                var perfilGrupalCatalogoRedesSociales = await _context.PerfilGrupalCatalogoRedesSociales
                    .FirstOrDefaultAsync(p => p.PerfilGrupalId == request.PerfilGrupalId && p.CatalogoRedesSocialesId == request.CatalogoRedesSocialesId);

                // Si el registro no se encuentra, retornar un error 404 (No encontrado)
                if (perfilGrupalCatalogoRedesSociales == null)
                {
                    return NotFound();
                }

                // Mapear las propiedades del objeto request al perfilGrupalCatalogoRedesSociales existente
                _mapper.Map(request, perfilGrupalCatalogoRedesSociales);
            }

            // Guardar los cambios en la base de datos
            await _context.SaveChangesAsync();

            // Retornar una respuesta exitosa 200 (OK) con los datos actualizados
            return Ok(requestList);
        }

        // DELETE api/<PerfilGrupalCatalogoRedesSocialesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var perfilGrupalCatalogoRedesSociales = await _context.PerfilGrupalCatalogoRedesSociales.FindAsync(id);
            if (perfilGrupalCatalogoRedesSociales == null)
                return NotFound();

            _context.PerfilGrupalCatalogoRedesSociales.Remove(perfilGrupalCatalogoRedesSociales);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("update-by-perfil-grupal/{id}")]
        public async Task<IActionResult> Update(int id, List<PerfilGrupalCatalogoRedesSocialesViewModel>? requestList)
        {
            var perfilGrupalCatalogoRedesSociales = await _context.PerfilGrupalCatalogoRedesSociales
                .Where(perfil => perfil.PerfilGrupalId == id)
                .DefaultIfEmpty()
                .ToListAsync();

            foreach (var perfil in perfilGrupalCatalogoRedesSociales)
            {
                if (perfil != null)
                {
                    _context.PerfilGrupalCatalogoRedesSociales.Remove(perfil);
                    await _context.SaveChangesAsync();
                }
            }

            if (requestList == null)
            {
                return NoContent();
            }

            foreach (var redSocial in requestList)
            {
                PerfilGrupalCatalogoRedesSociales perfilCRS = _mapper.Map<PerfilGrupalCatalogoRedesSociales>(redSocial);

                _context.PerfilGrupalCatalogoRedesSociales.Add(perfilCRS);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }
    }
}
