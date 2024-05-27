using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Data.Seed.CaminoHeroeCiudadano
{
    public class CatalogoTiposEtapasCHC_Seed
    {
        public readonly List<CatalogoTiposEtapasCHC> CatalogosTiposEtapasCHC = new()
        {
            new CatalogoTiposEtapasCHC { Id = 1, Nombre = "Camino al Heroe Ciudadano" },
            new CatalogoTiposEtapasCHC { Id = 2, Nombre = "Camino al Candidat@" },
        };
    }
}
