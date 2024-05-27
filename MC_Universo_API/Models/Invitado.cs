using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class Invitado
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required string Nombre { get; set; }
    public string? ApellidoPaterno { get; set; } = null;
    public string? ApellidoMaterno { get; set; } = null;
    
    public required string Email { get; set; }
    public string? Telefono { get; set; } = default!;

    public DateTime? FechaNacimiento { get; set; } = default!;
    
    public string? Sexo { get; set; } = default!;
    public string? EntidadFederativa { get; set; } = default!;
    
    [Comment("El cargo u organización a la que pertenece el invitado")]
    public string? CargoOrganizacion { get; set; } = default!;
    
    [Comment("Puede ser: 'Presencial', 'Virtual' o 'Ambos'")]
    public required string ModoParticipacion { get; set; }
    
    public bool Activo { get; set; } = true;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
}