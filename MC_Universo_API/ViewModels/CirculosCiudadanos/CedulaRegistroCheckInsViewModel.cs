using MC_Universo_API.Models.CirculosCiudadanos;

namespace MC_Universo_API.ViewModels.CirculosCiudadanos;

public class CedulaRegistroCheckInsViewModel
{
    public int PerfilCirculoId { get; set; }
    public int CheckInId { get; set; }
    public bool IsAccepted { get; set; } = false;
    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}
