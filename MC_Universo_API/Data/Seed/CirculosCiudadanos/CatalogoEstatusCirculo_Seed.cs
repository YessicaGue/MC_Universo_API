using MC_Universo_API.Models.CirculosCiudadanos;

namespace MC_Universo_API.Data.Seed.CirculosCiudadanos;

public class CatalogoEstatusCirculo_Seed
{
    public readonly List<CatalogoEstatusCirculo> CatalogosEstatusCirculo =
    [
        new CatalogoEstatusCirculo { Id = 1, Nombre = "En creación" },
        new CatalogoEstatusCirculo { Id = 2, Nombre = "Por validar" },
        new CatalogoEstatusCirculo { Id = 3, Nombre = "Validando" },
        new CatalogoEstatusCirculo { Id = 4, Nombre = "Validado" }
    ];
}