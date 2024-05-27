using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.Candidatos;

public class EncuestaCausasCandidatoOpcion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public required int PreguntaId { get; set; }
    [ForeignKey("PreguntaId")] public virtual EncuestaCausasCandidatoPregunta Pregunta { get; set; } = default!;

    [Required(ErrorMessage = "El texto de la opción es requerido.")]
    public required string Opcion { get; set; }
    
    public required bool EsAbierta { get; set; } = false;

    public bool Activo { get; set; } = true;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaEliminacion { get; set; } = null;
}