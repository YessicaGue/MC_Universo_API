namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class DetalleExamenesCandidatosViewModel
    {
        public required int ExamenCandidatoId { get; set; }

        public required int RespuestaExamenCHCId { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;

    }
}
