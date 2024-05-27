using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class CatalogoCaminosCHCViewModel
    {
        public required string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public string? NombreColor { get; set; }

        [Comment("Valores en HEX")]
        public string? ValorColor { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
