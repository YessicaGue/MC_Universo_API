using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class RespuestaExamenCHC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int PreguntaExamenCHCId { get; set; }
        [ForeignKey("PreguntaExamenCHCId")]
        public virtual PreguntasExamenCHC PreguntasExamenCHC { get; set; } = default!;

        public required string Respuesta { get; set; }

        public required bool EsCorrecta { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
