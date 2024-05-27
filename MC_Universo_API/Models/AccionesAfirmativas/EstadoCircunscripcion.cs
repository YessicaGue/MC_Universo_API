using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.AccionesAfirmativas;

public class EstadoCircunscripcion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public required int CircunscripcionId { get; set; }
    [ForeignKey("CircunscripcionId")]
    public virtual CatalogoCircunscripcion CatalogoCircunscripcion { get; set; } = default!; 
    
    public required int EntidadId { get; set; }
    [ForeignKey("EntidadId")] 
    public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    
    public bool Activo { get; set; } = true;
    
}