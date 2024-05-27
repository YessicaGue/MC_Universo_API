using MC_Universo_API.Models;
using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Data.Seed.CaminoHeroeCiudadano
{
    public class CatalogoDocumentosEligibilidadCHC_Seed
    {
        public readonly List<CatalogoDocumentosEligibilidadCHC> CatalogoDocumentosEligibilidadCHC = new()
        {
           new CatalogoDocumentosEligibilidadCHC
           {
               Id = 1, Nombre = "Carta Compromiso",Descripcion = "Carta Compromiso" ,Activo = true ,
               FechaCreacion = DateTime.UtcNow, 
           },

           new CatalogoDocumentosEligibilidadCHC
           {
               Id = 2, Nombre = "Evidencias",Descripcion = "Evidencias" ,Activo = true ,
               FechaCreacion = DateTime.UtcNow,
           }
        };
    }
}
