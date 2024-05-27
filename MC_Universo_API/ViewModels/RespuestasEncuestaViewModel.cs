using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels
{
    public class RespuestasEncuestaViewModel
    {

        public int EncuestaId { get; set; }

        public int PreguntaId { get; set; }

        public required string Respuesta { get; set; }

    }
}
