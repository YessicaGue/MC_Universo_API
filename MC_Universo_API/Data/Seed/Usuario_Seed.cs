using System.Text;
using MC_Universo_API.Models;
using MC_Universo_API.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace MC_Universo_API.Data.Seed;

public class Usuario_Seed
{
    public readonly List<Usuario> Usuarios = new()
    {
        new Usuario
        {
            Id = 1,
            UserName = "poncho.admin",
            Email = "alfonso.coeto@guacamayotech.com",
            Password = EncryptCustom.Encrypt("SuperSecretPassword!"),
            Rol = "Super Administrador"
        }
    };
}