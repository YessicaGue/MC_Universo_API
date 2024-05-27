using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[PrimaryKey("PersonaId", "MotivoId")]
public class PersonaMotivo
{
    public int PersonaId { get; set; }
    [NotMapped]
    public Persona Persona { get; set; } = default!;
    
    public int MotivoId { get; set; }
    [NotMapped]
    public Motivo Motivo { get; set; } = default!;
}