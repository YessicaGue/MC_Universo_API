using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class Escolaridad_Seed
{
    public readonly List<Escolaridad> Escolaridades = new()
    {
        new Escolaridad {Id = 1,  Nombre = "Primaria", Activo = true },
        new Escolaridad {Id = 2,  Nombre = "Secundaria", Activo = true },
        new Escolaridad {Id = 3,  Nombre = "Preparatoria o Bachiller", Activo = true },
        new Escolaridad {Id = 4,  Nombre = "Técnico superior", Activo = true },
        new Escolaridad {Id = 5,  Nombre = "Licenciatura", Activo = true },
        new Escolaridad {Id = 6,  Nombre = "Posgrado", Activo = true },
        new Escolaridad {Id = 7,  Nombre = "Otro", Activo = true },
    };
}