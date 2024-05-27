using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[PrimaryKey("CausaId", "GrupoCausaId")]
public class CausaGrupoCausa
{
    public int CausaId { get; set; }
    [NotMapped]
    public Causa Causa { get; set; } = default!;
    
    public int GrupoCausaId { get; set; }
    [NotMapped]
    public GrupoCausa GrupoCausa { get; set; } = default!;
}