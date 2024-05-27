using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class EntidadFederativa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required string Nombre { get; set; }
    public required string IsoCode { get; set; }
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
}