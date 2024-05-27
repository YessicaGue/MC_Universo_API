using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoPublicaciones_Seed
    {
        public readonly List<CatalogoPublicaciones> CatalogosPublicaciones = new()
        {
            new CatalogoPublicaciones {Id = 1,  Nombre = "Mi liderazgo" },
            new CatalogoPublicaciones {Id = 2,  Nombre = "Mi círculo" },
            new CatalogoPublicaciones {Id = 3,  Nombre = "Mi comunidad" },
            new CatalogoPublicaciones {Id = 4,  Nombre = "Apoyo precandidatura" },
        };
    }
}
