using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[PrimaryKey("PersonaId", "CausaId")]
public class PersonaCausa
{
    public int PersonaId { get; set; }
    [NotMapped]
    public Persona Persona { get; set; } = default!;
    
    public int CausaId { get; set; }
    [NotMapped]
    public Causa Causa { get; set; } = default!;
}