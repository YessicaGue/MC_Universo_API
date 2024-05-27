using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]

public class Persona
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required string Nombre { get; set; }

    public required string ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; } = default!;
    
    public string? Seudonimo { get; set; } = default!;

    public DateTime? FechaNacimiento { get; set; }

    public int? EntidadFederativaId { get; set; }
    [ForeignKey("EntidadFederativaId")]
    public virtual EntidadFederativa? EntidadFederativa { get; set; }

    public required int GeneroId { get; set; }
    [ForeignKey("GeneroId")] 
    public virtual Genero Genero { get; set; } = default!;

    public string? CorreoElectronico { get; set; } = default!;

    public int TiempoResidencia { get; set; } = default!;

    public string? TelefonoParticular { get; set; } = default!;

    public string? FirmaElectronica { get; set; } = default!;

    public string? Curp { get; set; } = default!;

    public string? Rfc { get; set; } = default!;

    public string? ClaveElector { get; set; } = default!;

    public bool Activo { get; set; } = true;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
}