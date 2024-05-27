using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

public class InteresGrupoIntereses
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int InteresId { get; set; }
    [ForeignKey("InteresId")]
    public virtual Interes Interes { get; set; } = default!;
    
    public int GrupoInteresesId { get; set; }
    [ForeignKey("GrupoInteresesId")]
    public virtual GrupoIntereses GrupoIntereses { get; set; } = default!;
}