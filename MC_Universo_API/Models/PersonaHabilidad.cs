using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[PrimaryKey("PersonaId", "HabilidadId")]
public class PersonaHabilidad
{
    public int PersonaId { get; set; }
    [NotMapped]
    public Persona Persona { get; set; } = default!;
    
    public int HabilidadId { get; set; }
    [NotMapped]
    public Habilidad Habilidad { get; set; } = default!;
}