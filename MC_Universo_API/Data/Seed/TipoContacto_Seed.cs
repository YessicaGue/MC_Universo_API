using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class TipoContacto_Seed
{
    public readonly List<TipoContacto> TipoContactos = new()
    {
        new TipoContacto { Id = 1, Nombre = "Correo electrónico", Activo = true, EsEmail = true },
        new TipoContacto { Id = 2, Nombre = "Teléfono", Activo = true, EsTelefono = true },
        new TipoContacto { Id = 3, Nombre = "WhatsApp", Activo = true, EsWhatsapp = true, EsTelefono = true},
        new TipoContacto { Id = 4, Nombre = "Otro", Activo = true, EsOtro = true }
    };
}