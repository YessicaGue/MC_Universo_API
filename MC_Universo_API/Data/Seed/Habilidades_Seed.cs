using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class Habilidades_Seed
{
    public readonly List<Habilidad> Habilidades = new()
    {
        new Habilidad {Id = 1,  Nombre = "Comunicación efectiva", Activo = true },
        new Habilidad {Id = 2,  Nombre = "Creatividad", Activo = true },
        new Habilidad {Id = 3,  Nombre = "Inteligencia emocional", Activo = true },
        new Habilidad {Id = 4,  Nombre = "Interpretación de datos", Activo = true },
        new Habilidad {Id = 5,  Nombre = "Negociación", Activo = true },
        new Habilidad {Id = 6,  Nombre = "Organización", Activo = true },
        new Habilidad {Id = 7,  Nombre = "Resiliencia", Activo = true },
        new Habilidad {Id = 8,  Nombre = "Resolución de problemas", Activo = true },
        new Habilidad {Id = 9,  Nombre = "Toma de decisiones", Activo = true },
        new Habilidad {Id = 10,  Nombre = "Trabajo en equipo", Activo = true },
        new Habilidad {Id = 11,  Nombre = "Otro", Activo = true },
    };
}