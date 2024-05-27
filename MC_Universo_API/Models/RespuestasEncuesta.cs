using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models;

public class RespuestasEncuesta
 {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int EncuestaId { get; set; }
    [ForeignKey("EncuestaId")]
    public virtual Encuesta Encuesta { get; set; } = default!;

    public int PreguntaId { get; set; }
    [ForeignKey("PreguntaId")]
    public virtual CatalogoPreguntasEncuestas CatalogoPreguntasEncuestas { get; set; } = default!;

    public string? Respuesta { get; set; }

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
}
