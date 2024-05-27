using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoCategoriasPreguntasEncuestas_Seed
    {
        public readonly List<CatalogoCategoriasPreguntasEncuestas> CatalogosCategoriasPreguntasEncuestas = new()
        {
            new CatalogoCategoriasPreguntasEncuestas {Id = 1,  Nombre = "Coordinación"},
        };
    }
}
