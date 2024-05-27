using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class EventoTipos_Seed
{
    public readonly List<EventoTipo> EventoTipos = new()
    {
        new EventoTipo {Id = 1, Nombre = "Público General", Descripcion = "Este es un evento público.", TipoSesion = false, Activo = true },
        new EventoTipo {Id = 2, Nombre = "Afiliados", Descripcion = "Este es un evento para afiliados.", TipoSesion = false, Activo = true },
        new EventoTipo {Id = 3, Nombre = "Sesión", Descripcion = "Este es un evento de tipo sesión.", TipoSesion = true, Activo = true }
    };
}