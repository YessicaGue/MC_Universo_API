using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models.CirculosCiudadanos;

public class CirculoCausa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int CirculoId { get; set; }
    [ForeignKey("CirculoId")]
    public virtual Circulo Circulo { get; set; } = default!;

    [Comment("Causa de voces del futuro")]
    public int CausaId { get; set; }

    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}
