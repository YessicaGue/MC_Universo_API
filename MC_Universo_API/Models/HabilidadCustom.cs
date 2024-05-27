using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class HabilidadCustom
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required string Nombre { get; set; }
    
    [DefaultValue(true)]
    public bool Activo { get; set; }
    
    
    public int PersonaId { get; set; } // Id del usuario que creo la habilidad
    [ForeignKey("PersonaId")]
    public virtual Persona Persona { get; set; } = default!;
    
    [ReadOnly(true)]
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
}