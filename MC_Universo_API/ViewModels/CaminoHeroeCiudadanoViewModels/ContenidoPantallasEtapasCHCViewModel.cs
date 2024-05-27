namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class ContenidoPantallasEtapasCHCViewModel
    {
        public required string Contenido { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; }
    }
}
