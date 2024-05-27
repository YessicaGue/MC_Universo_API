using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoConfiguraciones_Seed
    {
        public readonly List<CatalogoConfiguraciones> CatalogosConfiguraciones = new()
        {
            new CatalogoConfiguraciones {Id = 1, Nombre = "client_id", Valor = "10"},
            new CatalogoConfiguraciones {Id = 2, Nombre = "client_secret", Valor = "Ji28k8iPYrUqDTGCiIQCjZAZL4NZGAaez8W6C2PL"},
        };
    }
}
