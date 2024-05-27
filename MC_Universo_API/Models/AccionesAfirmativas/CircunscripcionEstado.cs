using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.AccionesAfirmativas;

public class CircunscripcionEstado
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public required int CircuncripcionId { get; set; }
    [ForeignKey("CircuncripcionId")] 
    public virtual EntidadFederativa CircunscripcionId { get; set; } = default!;
    
    public required int EntidadId { get; set; }
    [ForeignKey("EntidadId")] 
    public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;

    public bool Activo { get; set; } = true;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

}