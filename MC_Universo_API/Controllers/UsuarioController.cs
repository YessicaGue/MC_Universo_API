using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace MC_Universo_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly UniversoContext _context;
    private readonly IConfiguration _configuration;

    public UsuarioController(UniversoContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    // Iniciar sesión
    [HttpPost]
    [Route("login")]
    public dynamic IniciarSesion([FromBody] object loginData)
    {
        var data = JsonConvert.DeserializeObject<dynamic>(loginData.ToString() ??
                                                          throw new InvalidOperationException());

        if (data == null)
        {
            return new
            {
                error = true,
                message = "No se recibieron datos",
                tkn = ""
            };
        }

        string email = data.email.ToString();
        string password = data.password.ToString();

        var usuario = _context.Usuario.FirstOrDefault(u => u.Email == email);

        if (usuario == null)
        {
            return new
            {
                error = true,
                message = "Usuario no encontrado",
                tkn = ""
            };
        }
        
        var passwordValid = EncryptCustom.Compare(usuario.Password, EncryptCustom.Encrypt(password));

        if (passwordValid == false)
        {
            return new
            {
                error = true,
                message = "Contraseña incorrecta",
                tkn = ""
            };
        }

        var jwt = _configuration.GetSection("Jwt").Get<Jwt>();

        if (jwt == null)
        {
            return new
            {
                error = true,
                message = "No se pudo obtener la configuración de JWT",
                tkn = ""
            };
        }

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString(CultureInfo.CurrentCulture)),
            new Claim("Id", usuario.Id.ToString()),
            new Claim(ClaimTypes.Name, usuario.UserName),
            new Claim(ClaimTypes.Email, usuario.Email),
            new Claim(ClaimTypes.Role, usuario.Rol ?? "Usuario")
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            jwt.Issuer,
            jwt.Audience,
            claims,
            expires: DateTime.UtcNow.AddMinutes(jwt.Expiration),
            signingCredentials: signIn
        );

        return new
        {
            error = false,
            message = "Inicio de sesión exitoso",
            tkn = new JwtSecurityTokenHandler().WriteToken(token)
        };
    }
}