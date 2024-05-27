using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class DatoContacto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    [MinLength(3)]
    public required string Valor { get; set; } = default!;

    public required bool Verificado { get; set; }

    public required int PersonaId { get; set; }
    [ForeignKey("PersonaId")]
    public virtual Persona Persona { get; set; } = default!;
    
    public required int TipoContactoId { get; set; }
    [ForeignKey("TipoContactoId")]
    public virtual TipoContacto TipoContacto { get; set; } = default!;
    
    public bool Activo { get; set; } = true;

}