using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class GrupoEntidadFederativa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required string Nombre { get; set; }
    
    public string? Manzana { get; set; }
    public string? Seccion { get; set; }
    public string? Distrito { get; set; }
    public string? Zona { get; set; }
    
    public required bool Activo { get; set; } = true;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
}