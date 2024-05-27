using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models.AccionesAfirmativas;

[Index(nameof(ShortId), IsUnique = true)]
public class CatalogoRepresentante
{
   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [StringLength(8)]
    public required string ShortId { get; set; }

    public required string NombreCargo { get; set; }
    
    public string? Principio { get; set; }
    
    public string NivelCargo { get; set; }
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public bool Activo { get; set; } = true;

}