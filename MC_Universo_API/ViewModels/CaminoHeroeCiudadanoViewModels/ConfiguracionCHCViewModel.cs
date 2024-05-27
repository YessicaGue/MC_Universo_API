namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class ConfiguracionCHCViewModel
    {
        public required string NombreConfiguracion { get; set; }

        public required string TipoConfiguracion { get; set; }

        public required string Archivo { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
