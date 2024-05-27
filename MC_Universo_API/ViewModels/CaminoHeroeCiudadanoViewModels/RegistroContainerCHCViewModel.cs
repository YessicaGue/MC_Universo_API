using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class RegistroContainerCHCViewModel
    {
        public PersonaViewModel PersonaRequest { get; set; }
        public DireccionViewModel DireccionRequest { get; set; }
        public PersonaPerfilCHCViewModel PersonaPerfilRequest { get; set; }
        public CandidatosCHCViewModel CandidatosCHCRequest { get; set; }
        public CandidatoEtapaRegistroCHCViewModel CandidatoEtapaRegistroCHCRequest { get; set; }
    }
}
