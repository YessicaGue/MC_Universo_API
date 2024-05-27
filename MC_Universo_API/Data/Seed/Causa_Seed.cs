using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class Causa_Seed
{
    public readonly List<Causa> Causas = new()
    {
        new Causa {Id = 1, Nombre = "Diversidad sexual", Activo = true },
        new Causa {Id = 2, Nombre = "Energías limpias", Activo = true },
        new Causa {Id = 3, Nombre = "Infancias", Activo = true },
        new Causa {Id = 4, Nombre = "Ingreso vital", Activo = true },
        new Causa {Id = 5, Nombre = "Justicia climática (emergencia climática)", Activo = true },
        new Causa {Id = 6, Nombre = "Juventudes", Activo = true },
        new Causa {Id = 7, Nombre = "Legalización", Activo = true },
        new Causa {Id = 8, Nombre = "Mujeres", Activo = true },
        new Causa {Id = 9, Nombre = "Paz", Activo = true },
    };
}
