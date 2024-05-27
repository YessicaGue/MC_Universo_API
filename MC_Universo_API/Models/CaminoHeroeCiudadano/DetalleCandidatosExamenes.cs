using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class DetalleCandidatosExamenes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int ExamenCandidatoId { get; set; }
        [ForeignKey("ExamenCandidatoId")]
        public virtual CandidatosExamenes CandidatosExamenes { get; set; } = default!;

        public int RespuestaExamenCHCId { get; set; }
        [ForeignKey("RespuestaExamenCHCId")]
        public virtual RespuestaExamenCHC RespuestaExamenCHC { get; set; } = default!;

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;

    }
}