using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class Generos_Seed
{
    public readonly List<Genero> Generos = new()
    {
        new Genero {Id = 1,  Nombre = "Masculino", Activo = true },
        new Genero {Id = 2,  Nombre = "Femenino", Activo = true },
        new Genero {Id = 3,  Nombre = "Chico", Activo = true },
        new Genero {Id = 4,  Nombre = "Chica", Activo = true },
        new Genero {Id = 5,  Nombre = "Bigénero", Activo = true },
        new Genero {Id = 6,  Nombre = "Intersexual", Activo = true },
        new Genero {Id = 7,  Nombre = "No binario", Activo = true },
        new Genero {Id = 8,  Nombre = "Sin género", Activo = true },
        new Genero {Id = 9,  Nombre = "No estoy seguro", Activo = true },
        new Genero {Id = 10,  Nombre = "Prefiero no decir", Activo = true },
        new Genero {Id = 11,  Nombre = "Otro", Activo = true },
    };
}