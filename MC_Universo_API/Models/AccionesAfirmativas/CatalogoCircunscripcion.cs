using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models.AccionesAfirmativas;

[Index(nameof(ShortId), IsUnique =true)]
public class CatalogoCircunscripcion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [StringLength(8)]
    public required string ShortId { get; set; }
    
    public required int Circunscripcion { get; set; }

    public required string Nombre { get; set; }

    public bool Activo { get; set; } = true;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

}