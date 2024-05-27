using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), nameof(PersonaId), IsUnique = true)]
public class BajasSistema
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    [Comment("Id de la persona que se dio de baja")]
    public required int PersonaId { get; set; }
    [ForeignKey("PersonaId")]
    public virtual Persona Persona { get; set; } = default!;
    
    public required int MotivoBajaId { get; set; }
    [ForeignKey("MotivoBajaId")]
    public virtual MotivoBaja MotivoBaja { get; set; } = default!;
    
    public DateTime FechaBaja { get; set; } = DateTime.UtcNow;
}