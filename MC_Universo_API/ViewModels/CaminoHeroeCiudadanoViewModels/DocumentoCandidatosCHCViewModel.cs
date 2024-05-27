namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class DocumentoCandidatosCHCViewModel
    {
        public required int CandidatoCHCId { get; set; }
        
        public required int DocumentoEligibilidadCHCId { get; set; }

        public required int EstatusDocumentoEligibilidadCHCId { get; set; }

        public required string NombreArchivo { get; set; }

        public string? MotivoRechazo { get; set; }

        public string? NombreArchivoUsuario { get; set; }

        public string? DescripcionArchivoUsuario { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
