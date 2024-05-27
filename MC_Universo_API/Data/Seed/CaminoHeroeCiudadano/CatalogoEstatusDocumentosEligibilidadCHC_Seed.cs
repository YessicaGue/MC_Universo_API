using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Data.Seed.CaminoHeroeCiudadano
{
    public class CatalogoEstatusDocumentosEligibilidadCHC_Seed
    {
        public readonly List<CatalogoEstatusDocumentosEligibilidadCHC> CatalogosEstatusDocumentosEligibilidadCHC = new()
        {
            new CatalogoEstatusDocumentosEligibilidadCHC { Id = 1, Nombre = "Por validar" },
            new CatalogoEstatusDocumentosEligibilidadCHC { Id = 2, Nombre = "Rechazado" },
            new CatalogoEstatusDocumentosEligibilidadCHC { Id = 3, Nombre = "En revisión" },
            new CatalogoEstatusDocumentosEligibilidadCHC { Id = 4, Nombre = "Aceptado" }
        };
    }
}
