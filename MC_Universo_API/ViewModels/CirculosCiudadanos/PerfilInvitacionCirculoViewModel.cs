using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels.CirculosCiudadanos;

public class PerfilInvitacionCirculoViewModel
{
    public int? PerfilAnfitrionId { get; set; }
    public int PerfilInvitadoId { get; set; }
    public bool Activo { get; set; } = true;
    public int UsuarioInvitacionId { get; set; } = 2;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}