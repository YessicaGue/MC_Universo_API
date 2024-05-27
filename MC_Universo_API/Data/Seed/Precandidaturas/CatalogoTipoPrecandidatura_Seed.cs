using MC_Universo_API.Models;
using MC_Universo_API.Models.Precandidaturas;

namespace MC_Universo_API.Data.Seed.Precandidaturas
{
    public class CatalogoTipoPrecandidatura_Seed
    {
        public readonly List<CatalogoTipoPrecandidatura> CatalogosTipoPrecandidatura = new()
        {
            new CatalogoTipoPrecandidatura {Id = 1,  Nombre = "Diputación Federal"},
            new CatalogoTipoPrecandidatura {Id = 2,  Nombre = "Senaduría"},
            new CatalogoTipoPrecandidatura {Id = 3,  Nombre = "Titular de la Presidencia de los Estados Unidos Mexicanos"},
            new CatalogoTipoPrecandidatura {Id = 4,  Nombre = "Gubernatura"},
            new CatalogoTipoPrecandidatura {Id = 5,  Nombre = "Diputación Local"},
            new CatalogoTipoPrecandidatura {Id = 6,  Nombre = "Ayuntamiento"},
            new CatalogoTipoPrecandidatura {Id = 7,  Nombre = "Jefe de Gobierno"},
            new CatalogoTipoPrecandidatura {Id = 8,  Nombre = "Alcaldía"},
            new CatalogoTipoPrecandidatura {Id = 9,  Nombre = "Junta Municipal"},
        };
    }
}
