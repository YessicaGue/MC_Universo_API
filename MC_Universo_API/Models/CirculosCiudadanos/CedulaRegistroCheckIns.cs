using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.CirculosCiudadanos;

public class CedulaRegistroCheckIns
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int PerfilCirculoId { get; set; }
    [ForeignKey("PerfilCirculoId")]
    public virtual PerfilCirculo PerfilCirculo { get; set; } = default!;

    public int CheckInId { get; set; }
    [ForeignKey("CheckInId")]
    public virtual CatalogoCheckInsCedulaCirculo CatalogoCheckInsCedulaCirculo { get; set; } = default!;

    public bool IsAccepted { get; set; } = false;

    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}
