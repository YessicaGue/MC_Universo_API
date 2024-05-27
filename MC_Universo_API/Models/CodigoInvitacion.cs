using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class CodigoInvitacion
{
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required Guid Codigo { get; set; } = Guid.NewGuid();
    
    // Id del sponsor
    [Column ("sponsor_id")]
    public int PersonaId { get; set; }
    [ForeignKey("PersonaId")]
    public virtual Persona Persona { get; set; } = default!;
    
    public bool Activo { get; set; } = true;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
}