using MC_Universo_API.Models.CaminoHeroeCiudadano;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class ContenidoPantallasEtapasCHCCatalogoEtapasCHCViewModel
    {
        public int CatalogoEtapasCHCId { get; set; }
        
        public int ContenidoPantallasEtapasCHCId { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; }
    }
}
