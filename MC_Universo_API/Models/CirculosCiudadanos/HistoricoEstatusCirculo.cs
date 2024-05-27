using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.CirculosCiudadanos;
public class HistoricoEstatusCirculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int EstatusAnteriorId { get; set; }
    [ForeignKey("EstatusAnteriorId")]
    public virtual CatalogoEstatusCirculo CatalogoEstatusCirculoAnterior { get; set; } = default!;

    public int EstatusNuevoId { get; set; }
    [ForeignKey("EstatusNuevoId")]
    public virtual CatalogoEstatusCirculo CatalogoEstatusCirculoNuevo { get; set; } = default!;

    public string? ComentarioEstatus { get; set; }

    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}