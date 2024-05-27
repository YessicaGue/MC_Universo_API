namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class CandidatosCHCViewModel
    {
        public required int PerfilId { get; set; }

        public int? CaminoId { get; set; }

        public int? CargoPostulacionId { get; set; }

        public required DateTime FechaInicio { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
