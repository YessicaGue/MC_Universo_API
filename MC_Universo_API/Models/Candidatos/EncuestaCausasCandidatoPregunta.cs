using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.Candidatos;

public class EncuestaCausasCandidatoPregunta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    [Required(ErrorMessage = "La pregunta es requerida.")]
    public required string Pregunta { get; set; }
    
    public bool Activo { get; set; } = true;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaEliminacion { get; set; } = null;
}