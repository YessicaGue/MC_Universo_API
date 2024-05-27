namespace MC_Universo_API.ViewModels.CirculosCiudadanos;

public class CatalogoCheckInsCedulaCirculoViewModel
{
    public required string Nombre { get; set; }
    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}
