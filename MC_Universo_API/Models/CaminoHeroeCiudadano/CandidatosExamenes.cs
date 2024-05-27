using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class CandidatosExamenes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int ExamenCHCId { get; set; }
        [ForeignKey("ExamenCHCId")]
        public virtual ExamenesCHC ExamenesCHC { get; set; } = default!;

        public int CandidatoCHCId { get; set; }
        [ForeignKey("CandidatoCHCId")]
        public virtual CandidatosCHC CandidatosCHC { get; set; } = default!;

        public required bool EsAprobado { get; set; }

        public required DateTime FechaUltimoIntento { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
