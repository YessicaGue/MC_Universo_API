namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class ExamenesCandidatosViewModel
    {
        public required int ExamenCHCId { get; set; }

        public required int CandidatoCHCId { get; set; }

        public required DateTime FechaUltimoIntento { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
