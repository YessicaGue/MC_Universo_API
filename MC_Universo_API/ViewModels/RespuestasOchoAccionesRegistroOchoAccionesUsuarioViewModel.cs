using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class RespuestasOchoAccionesRegistroOchoAccionesUsuarioViewModel
    {
        public int RegistroOchoAccionesUsuarioId { get; set; }

        public int PreguntaId { get; set; }

        public required string Respuesta { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
