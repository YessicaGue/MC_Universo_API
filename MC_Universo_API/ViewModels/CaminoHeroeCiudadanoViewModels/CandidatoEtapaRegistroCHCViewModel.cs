namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;

public class CandidatoEtapaRegistroCHCViewModel
{
    public int CandidatoId { get; set; }

    public int RegistroId { get; set; }

    public bool Activo { get; set; } = true;

    public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
}