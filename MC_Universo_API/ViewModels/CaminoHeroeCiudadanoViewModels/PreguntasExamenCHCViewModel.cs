namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class PreguntasExamenCHCViewModel
    {
        public required int IdExamenCHC { get; set; }
        
        public required int IdTipoPregunta { get; set; }
        
        public required string Pregunta { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
