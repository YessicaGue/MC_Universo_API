using System.Security.Claims;
using MC_Universo_API.Data;

namespace MC_Universo_API.Models;

public class Jwt
{
    public string Key { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string Subject { get; set; }
    public int Expiration { get; set; }

    public async Task<dynamic> ValidateToken(ClaimsIdentity identity, UniversoContext context)
    {
        try
        {
            if (!identity.Claims.Any())
            {
                return new
                {
                    error = true,
                    message = "No se encontraron datos en el token",
                    result = ""
                };
            }
            
            var idUser = identity.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            
            if (idUser == null)
            {
                return new
                {
                    error = true,
                    message = "No se encontró el id del usuario en el token",
                    result = ""
                };
            }
            
            // Find user by id in database
            var user = await context.Usuario.FindAsync(int.Parse(idUser));
            
            if (user == null)
            {
                return new
                {
                    error = true,
                    message = "No se encontró el usuario en la base de datos",
                    result = ""
                };
            }
            
            return new
            {
                error = false,
                message = "Token válido",
                result = user
            };
        } catch (Exception e)
        {
            return new
            {
                error = true,
                message = e.Message,
                result = ""
            };
        }
    }
}