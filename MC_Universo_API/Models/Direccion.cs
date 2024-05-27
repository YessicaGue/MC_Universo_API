using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), nameof(PersonaId), IsUnique = true)]
public class Direccion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required int PersonaId { get; set; }
    [ForeignKey("PersonaId")]
    public virtual Persona Persona { get; set; } = default!;
    
    public required string DireccionCompleta { get; set; }

    public string? NumeroCalle { get; set; }
    public string? NombreCalle { get; set; }

    public string? Colonia { get; set; }
    public string? Ciudad { get; set; }
    
    public int? EntidadFederativaId { get; set; }
    [ForeignKey("EntidadFederativaId")]
    public virtual EntidadFederativa? EntidadFederativa { get; set; }
    
    public string? CodigoPostal { get; set; }
    public required string Pais { get; set; }
    
    public required string Latitud { get; set; }
    public required string Longitud { get; set; }
    
    public bool Activo { get; set; } = true;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
}