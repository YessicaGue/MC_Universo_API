using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.CirculosCiudadanos;

public class PerfilInvitacionCirculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int? PerfilAnfitrionId { get; set; }
    [ForeignKey("PerfilAnfitrionId")]
    public virtual Perfil? PerfilAnfitrion { get; set; }

    public int PerfilInvitadoId { get; set; }
    [ForeignKey("PerfilInvitadoId")]
    public virtual Perfil PerfilInvitado { get; set; } = default!;

    public int UsuarioInvitacionId { get; set; } = 2;
    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}