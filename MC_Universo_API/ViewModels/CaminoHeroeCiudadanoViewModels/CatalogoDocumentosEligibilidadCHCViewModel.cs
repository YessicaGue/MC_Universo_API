namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class CatalogoDocumentosEligibilidadCHCViewModel
    {
        public required string Nombre { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
