namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class CatalogoTiposEtapasCHCViewModel
    {
        public required string Nombre { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
