using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoTokens_Seed
    {
        public readonly List<CatalogoTokens> CatalogosTokens = new()
        {
            new CatalogoTokens {Id = 1, Nombre = "Instagram personal 1"},
            new CatalogoTokens {Id = 2, Nombre = "Instagram personal 2"},
            new CatalogoTokens {Id = 3, Nombre = "Instagram grupal"},
            new CatalogoTokens {Id = 4, Nombre = "Facebook personal"},
        };
    }
}
