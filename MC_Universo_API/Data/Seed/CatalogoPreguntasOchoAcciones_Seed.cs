using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoPreguntasOchoAcciones_Seed
    {
        public readonly List<CatalogoPreguntasOchoAcciones> CatalogosPreguntasOchoAcciones = new()
        {
            new CatalogoPreguntasOchoAcciones {Id = 1, Nombre = "¿Cómo quieres participar?"},
            new CatalogoPreguntasOchoAcciones {Id = 2, Nombre = "¿Cómo propones hacerlo?"},
        };
    }
}
