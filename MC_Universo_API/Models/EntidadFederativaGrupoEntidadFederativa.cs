using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class EntidadFederativaGrupoEntidadFederativa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public int EntidadFederativaId { get; set; }
    [ForeignKey("EntidadFederativaId")]
    public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;
    
    public int GrupoEntidadFederativaId { get; set; }
    [ForeignKey("GrupoEntidadFederativaId")]
    public virtual GrupoEntidadFederativa GrupoEntidadFederativa { get; set; } = default!;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
}