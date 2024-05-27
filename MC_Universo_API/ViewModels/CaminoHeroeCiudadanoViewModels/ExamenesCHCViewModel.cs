namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class ExamenesCHCViewModel
    {
        public required string NombreExamen { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
