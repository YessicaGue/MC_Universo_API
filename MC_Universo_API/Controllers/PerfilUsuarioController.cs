using System.Text.Json;
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
    public class PerfilUsuarioController(UniversoContext context, IMapper mapper) : ControllerBase
    {
        // GET api/<PerfilUsuarioController>/5
        [HttpGet("email={email}")]
        public async Task<ActionResult<PerfilUsuario>> GetByEmail(string email)
        {
            var perfilUsuario = await context.PerfilUsuario
                .Where(pu => pu.Email == email)
                .FirstOrDefaultAsync();

            return perfilUsuario == null ? Ok(null) : perfilUsuario;
        }

        // GET: api/<PerfilUsuarioController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfilUsuario>>> GetByPerfilId([FromQuery] int perfilId)
        {
            if (perfilId > 0)
            {
                return await context.PerfilUsuario.Where(up => up.PerfilId == perfilId).ToListAsync();
            }

            return await context.PerfilUsuario.ToListAsync();
        }

        // GET api/<PerfilUsuarioController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<PerfilUsuario>> Get(int id)
        {
            var perfilUsuario = await context.PerfilUsuario.FindAsync(id);

            return perfilUsuario == null ? NotFound() : perfilUsuario;
        }

        // POST api/<PerfilUsuarioController>
        [HttpPost]
        public async Task<ActionResult<PerfilUsuario>> Post(PerfilUsuarioViewModel request)
        {
            PerfilViewModel perfilVM = new PerfilViewModel { Alias = request.Name, Url = request.Name };
            Perfil perfil = mapper.Map<Perfil>(perfilVM);
            context.Perfil.Add(perfil);
            await context.SaveChangesAsync();

            PerfilUsuario perfilUsuario = mapper.Map<PerfilUsuario>(request);
            perfilUsuario.PerfilId = perfil.Id;
            context.PerfilUsuario.Add(perfilUsuario);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilUsuario.Id }, perfilUsuario);
        }

        // PUT api/<PerfilUsuarioController>/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, PerfilUsuarioViewModel request)
        {
            var perfilUsuario = await context.PerfilUsuario.FindAsync(id);
            
            if (perfilUsuario == null)
            {
                return NotFound();
            }
            
            mapper.Map(request, perfilUsuario);

            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = perfilUsuario.Id }, perfilUsuario);
        }

        [HttpGet("disable/{id:int}")]
        public async Task<IActionResult> Disable(int id)
        {
            var perfilUsuario = await context.PerfilUsuario.FindAsync(id);

            if (perfilUsuario == null)
            {
                return NotFound();
            }

            perfilUsuario.Activo = false;
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ResetPassword([FromBody] JsonElement body)
        {
            string email = body.GetProperty("email")
                .ToString()
                .Trim()
                ?? "";

            if (string.IsNullOrEmpty(email))
            {
                return BadRequest();
            }

            var perfilUsuario = context.PerfilUsuario
                .Where(perfilUsuario => perfilUsuario.Email == email)
                .FirstOrDefault();

            if (perfilUsuario == null)
            {
                return NotFound();
            }

            var perfil = context.Perfil
                .Where(perfil => perfilUsuario.PerfilId == perfil.Id)
                .FirstOrDefault();
            
            if (perfil == null)
            {
                return NotFound();
            }

            Guid token = Guid.NewGuid();
            perfilUsuario.EmailResetToken = token;

            await context.SaveChangesAsync();

            return Ok(new
            {
                token = token.ToString(),
                perfilToken = perfil.Guid,
            });
        }

        [HttpPost("verify-reset-password-token")]
        public IActionResult VerifyResetPasswordToken([FromBody] JsonElement body)
        {
            string tokenGuid = body.GetProperty("tokenGuid")
                .ToString()
                .Trim()
                ?? "";

            string perfilGuid = body.GetProperty("perfilGuid")
                .ToString()
                .Trim()
                ?? "";

            bool isBadRequest = string.IsNullOrEmpty(tokenGuid)
                || string.IsNullOrEmpty(perfilGuid);

            if (isBadRequest)
            {
                return BadRequest();
            }

            // JG - 20231108 - Provides a non matchable guid if not valid guid is provided from request
            Guid parsedTokenGuid = Guid.TryParse(tokenGuid, out Guid globalToken)
                ? Guid.Parse(tokenGuid)
                : Guid.Empty;

            Guid parsedPerfilGuid = Guid.TryParse(perfilGuid, out Guid globalPerfil)
                ? Guid.Parse(perfilGuid)
                : Guid.Empty;

            var perfilUsuario = context.PerfilUsuario
                .Where(perfilUsuario =>
                    perfilUsuario.EmailResetToken == parsedTokenGuid &&
                    context.Perfil
                        .Any(perfil =>
                            perfilUsuario.PerfilId == perfil.Id &&
                            perfil.Guid == parsedPerfilGuid
                        )
                )
                .FirstOrDefault();

            if (perfilUsuario == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                email = perfilUsuario.Email
            });
        }

        [HttpPut("reset-password")]
        public async Task<IActionResult> NewPassword([FromBody] JsonElement body)
        {
            string password = body.GetProperty("password")
                .ToString()
                .Trim()
                ?? "";

            string tokenGuid = body.GetProperty("tokenGuid")
                .ToString()
                .Trim()
                ?? "";

            string perfilGuid = body.GetProperty("perfilGuid")
                .ToString()
                .Trim()
                ?? "";

            bool isBadRequest = string.IsNullOrEmpty(tokenGuid)
                || string.IsNullOrEmpty(perfilGuid)
                || string.IsNullOrEmpty(password);

            if (isBadRequest)
            {
                return BadRequest();
            }

            // JG - 20231108 - Provides a non matchable guid if not valid guid is provided from request
            Guid parsedTokenGuid = Guid.TryParse(tokenGuid, out Guid globalToken)
                ? Guid.Parse(tokenGuid)
                : Guid.Empty;

            Guid parsedPerfilGuid = Guid.TryParse(perfilGuid, out Guid globalPerfil)
                ? Guid.Parse(perfilGuid)
                : Guid.Empty;

            var perfilUsuario = context.PerfilUsuario
                .Where(perfilUsuario =>
                    perfilUsuario.EmailResetToken == parsedTokenGuid &&
                    context.Perfil
                        .Any(perfil =>
                            perfilUsuario.PerfilId == perfil.Id &&
                            perfil.Guid == parsedPerfilGuid
                        )
                )
                .FirstOrDefault();

            if (perfilUsuario == null)
            {
                return NotFound();
            }

            perfilUsuario.Password = password;
            perfilUsuario.EmailResetToken = null;

            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
