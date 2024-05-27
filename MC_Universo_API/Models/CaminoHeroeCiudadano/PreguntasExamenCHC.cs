using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class PreguntasExamenCHC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int ExamenCHCId { get; set; }
        [ForeignKey("ExamenCHCId")]
        public virtual ExamenesCHC ExamenesCHC { get; set; } = default!;

        public int TipoPreguntaId { get; set; }
        [ForeignKey("TipoPreguntaId")]
        public virtual CatalogoTiposPreguntas CatalogoTiposPreguntas { get; set; } = default!;

        public required string Pregunta { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;

    }
}
