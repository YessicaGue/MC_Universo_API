using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoEstatusVoluntario_Seed
    {
        public readonly List<CatalogoEstatusVoluntario> CatalogosEstatusVoluntario = new()
        {
            new CatalogoEstatusVoluntario {Id = 1,  Nombre = "Por validar"},
            new CatalogoEstatusVoluntario {Id = 2,  Nombre = "Inválido"},
            new CatalogoEstatusVoluntario {Id = 3,  Nombre = "Válido"},
        };
    }
}
