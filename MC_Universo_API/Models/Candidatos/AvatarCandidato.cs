using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.Candidatos;

public class AvatarCandidato
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public int PerfilId { get; set; }
    [ForeignKey("PerfilId")]
    public virtual Perfil Perfil { get; set; }
    
    public string UrlImagen { get; set; }
    public string Descripcion { get; set; }
    public string? Actividades { get; set; } = null;
    public string? Extras { get; set; } = null;
    public string? Causas { get; set; } = null;
    public string? CausasExtra { get; set; } = null;
    
    public bool Activo { get; set; } = true;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaEliminacion { get; set; } = null;
}