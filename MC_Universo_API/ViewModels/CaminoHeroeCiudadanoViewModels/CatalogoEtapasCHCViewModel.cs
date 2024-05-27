using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class CatalogoEtapasCHCViewModel
    {
        public int CaminoId { get; set; }
        
        public int TipoEtapaId { get; set; }
        
        public required string Nombre { get; set; }

        public string? Descripcion { get; set; }

        [Comment("Fecha en la que la etapa va a terminar")]
        public DateTime FechaLimite { get; set; } = DateTime.UtcNow;

        public int? IndiceOrden { get; set; }

        public string? NombreUrlRoute { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
