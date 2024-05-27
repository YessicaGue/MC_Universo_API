using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoRedesSociales_Seed
    {
        public readonly List<CatalogoRedesSociales> CatalogosRedesSociales = new()
        {
            new CatalogoRedesSociales {Id = 1,  Nombre = "Facebook" },
            new CatalogoRedesSociales {Id = 2,  Nombre = "Instagram" },
            new CatalogoRedesSociales {Id = 3,  Nombre = "Twitter" },
            new CatalogoRedesSociales {Id = 4,  Nombre = "TikTok" },
            new CatalogoRedesSociales {Id = 5,  Nombre = "WhatsApp" },
            new CatalogoRedesSociales {Id = 6,  Nombre = "LinkedIn" },
            new CatalogoRedesSociales {Id = 7,  Nombre = "Conversatorio Grupal Facebook" },
        };
    }
}
