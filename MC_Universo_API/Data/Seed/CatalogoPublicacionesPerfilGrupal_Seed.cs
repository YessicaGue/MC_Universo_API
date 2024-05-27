using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoPublicacionesPerfilGrupal_Seed
    {
        public readonly List<CatalogoPublicacionesPerfilGrupal> CatalogosPublicacionesPerfilGrupal = new()
        {
            new CatalogoPublicacionesPerfilGrupal {Id = 1,  Nombre = "Movimiento social" },
            new CatalogoPublicacionesPerfilGrupal {Id = 2,  Nombre = "Nuestro trabajo" },
            new CatalogoPublicacionesPerfilGrupal {Id = 3,  Nombre = "Lo más reciente" },
            new CatalogoPublicacionesPerfilGrupal {Id = 4,  Nombre = "Próximos eventos" },
            new CatalogoPublicacionesPerfilGrupal {Id = 5,  Nombre = "Próximos cursos" },
            new CatalogoPublicacionesPerfilGrupal {Id = 6,  Nombre = "Newsletter" },
        };
    }
}
