namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;

public class DomicilioOirRecibirNotificacionesCHCViewModel
{
    public int CandidatoId { get; set; }
    
    public int DireccionId { get; set; }
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public bool Activo { get; set; } = true;
}