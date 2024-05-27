namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class AvanceEtapasCandidatoViewModel
    {
        public required int IdCandidatoCHC { get; set; }

        public required int IdEtapa { get; set; }

        public required int PorcentajeAvance { get; set; }

        public bool? ValidoComite { get; set; }

        public DateTime FechaUltimoCambio { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;

        public DateTime FechaExpiracion { get; set; }
    }
}
