namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;

public class DoumentoCandidatoCHCRegistroViewModel
{
    public int PerfilId { get; set; }

    public DocumentoCandidatosCHCViewModel DocumentoCandidatosCHCViewModel { get; set; }
    
    public CandidatoEtapaRegistroCHCViewModel? CandidatoEtapaRegistroCHCViewModel { get; set; } 
}