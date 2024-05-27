using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class DocumentoCandidatosCHC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int CandidatoCHCId { get; set; }
        [ForeignKey("CandidatoCHCId")]
        public virtual CandidatosCHC CandidatosCHC { get; set; }

        public int DocumentoEligibilidadCHCId { get; set; }
        [ForeignKey("DocumentoEligibilidadCHCId")]
        public virtual CatalogoDocumentosEligibilidadCHC CatalogoDocumentosEligibilidadCHC { get; set; }

        public int EstatusDocumentoEligibilidadCHCId { get; set; }
        [ForeignKey("EstatusDocumentoEligibilidadCHCId")]
        public virtual CatalogoEstatusDocumentosEligibilidadCHC CatalogoEstatusDocumentosEligibilidadCHC { get; set; }

        public required string NombreArchivo { get; set; }

        public string? MotivoRechazo { get; set; }

        public string? NombreArchivoUsuario { get; set; }

        public string? DescripcionArchivoUsuario { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;

    }
}
