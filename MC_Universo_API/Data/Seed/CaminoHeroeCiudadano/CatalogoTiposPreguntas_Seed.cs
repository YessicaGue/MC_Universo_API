using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Data.Seed.CaminoHeroeCiudadano
{
    public class CatalogoTiposPreguntas_Seed
    {
        public readonly List<CatalogoTiposPreguntas> CatalogosTiposPreguntas = new()
        {
            new CatalogoTiposPreguntas { Id = 1, Nombre = "Opción múltiple" },
            new CatalogoTiposPreguntas { Id = 2, Nombre = "Boleano" },
            new CatalogoTiposPreguntas { Id = 3, Nombre = "Selección única" },
        };
    }
}
