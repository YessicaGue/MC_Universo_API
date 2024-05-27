using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[PrimaryKey("PersonaId", "InteresId")]
public class PersonaInteres
{
    public int PersonaId { get; set; }
    [NotMapped]
    public Persona Persona { get; set; } = default!;
    
    public int InteresId { get; set; }
    [NotMapped]
    public Interes Interes { get; set; } = default!;
}