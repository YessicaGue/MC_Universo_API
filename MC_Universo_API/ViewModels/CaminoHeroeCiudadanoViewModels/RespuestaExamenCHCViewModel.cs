using MC_Universo_API.Models.CaminoHeroeCiudadano;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class RespuestaExamenCHCViewModel
    {
        public required int IdPreguntaExamenCHC { get; set; }

        public required string Respuesta { get; set; }

        public required bool EsCorrecta { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
