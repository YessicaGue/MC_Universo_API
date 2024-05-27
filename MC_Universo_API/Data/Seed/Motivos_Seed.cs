using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class Motivos_Seed
{
    public readonly List<Motivo> Motivos = new()
    {
        new Motivo {Id = 1,  Nombre = "Voluntario", Activo = true},
        new Motivo {Id = 2,  Nombre = "Servicio Social", Activo = true},
        new Motivo {Id = 3,  Nombre = "Prácticas Profesionales", Activo = true}
    };
}