using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[PrimaryKey("PersonaId", "GeneroId")]
public class PersonaGenero
{
    public int PersonaId { get; set; }
    [NotMapped]
    public Persona Persona { get; set; } = default!;
    
    public int GeneroId { get; set; }
    [NotMapped]
    public Genero Genero { get; set; } = default!;
}