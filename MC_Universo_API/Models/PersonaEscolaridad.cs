using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[PrimaryKey("PersonaId", "EscolaridadId")]
public class PersonaEscolaridad
{
    public int PersonaId { get; set; }
    [NotMapped]
    public Persona Persona { get; set; } = default!;
    
    public int EscolaridadId { get; set; }
    [NotMapped]
    public Escolaridad Escolaridad { get; set; } = default!;
}