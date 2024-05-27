using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.Candidatos;

public class ColaboradorCandidato
{
    [Key]
    public Guid Guid { get; set; } = Guid.NewGuid();
    
    [MinLength(10, ErrorMessage = "El nombre debe tener al menos 10 caracteres.")]
    public string Nombre { get; set; }
    
    [Phone(ErrorMessage = "El teléfono no es válido.")]
    public string Telefono { get; set; }
    
    [EmailAddress(ErrorMessage = "El email no es válido.")]
    public string Email { get; set; }
}

public class MinListLengthAttribute(int minLength) : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is IList list)
        {
            return list.Count >= minLength;
        }
        return false;
    }
}

public class CuestionarioCandidato
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public required int PerfilId { get; set; }
    [ForeignKey("PerfilId")] public virtual Perfil Perfil { get; set; }

    [Required(ErrorMessage = "Las causas son requeridas.")]
    [MinListLength(1, ErrorMessage = "Debe haber al menos una causa.")]
    public virtual List<string> Causas { get; set; } = [];

    [Required]
    public required string Propuestas { get; set; }

    [MinListLength(1, ErrorMessage = "Debe haber al menos un miembro en tu equipo.")]
    public virtual List<ColaboradorCandidato> Colaboradores { get; set; } = [];
    
    [Required(ErrorMessage = "La fecha de nacimiento es requerida.")]
    public required DateTime FechaNacimiento { get; set; }

    public string? RedesSociales { get; set; }

    public bool Activo { get; set; } = true;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaBaja { get; set; }
}