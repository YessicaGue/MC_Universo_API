using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models.Candidatos;

public class EncuestaCausasCandidato
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [Comment("Perfil donde fue respuesta la encuesta")]
    public int PerfilId { get; set; }
    [ForeignKey("PerfilId")] public virtual Perfil Perfil { get; set; } = default!;
    
    public int PreguntaId { get; set; }
    [ForeignKey("PreguntaId")] public virtual EncuestaCausasCandidatoPregunta Pregunta { get; set; } = default!;
    
    [Comment("Usuario que respondió la encuesta")]
    public int? UsuarioId { get; set; } = null;
    [ForeignKey("UsuarioId")] public virtual Perfil? Usuario { get; set; } = default!;
    
    public int OpcionId { get; set; }
    [ForeignKey("OpcionId")] public virtual EncuestaCausasCandidatoOpcion Opcion { get; set; } = default!;

    [MaxLength(500)]
    public required string Respuesta { get; set; } = default!;
        
    public bool Activo { get; set; } = true;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaEliminacion { get; set; } = null;
}