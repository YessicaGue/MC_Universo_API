using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class ExamenesRespuestasIntentosCHCViewModel
    {
        public int PerfilId { get; set; }

        public List<DetalleExamenesCandidatosViewModel> DetalleExamenesCandidatosViewModel { get; set; }

        public ExamenesCandidatosViewModel ExamenesCandidatosViewModel { get; set; }
    }
}
