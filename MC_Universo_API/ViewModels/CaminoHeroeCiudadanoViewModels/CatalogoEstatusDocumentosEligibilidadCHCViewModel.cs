using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class CatalogoEstatusDocumentosEligibilidadCHCViewModel
    {
        public required string Nombre { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
