using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels
{
    public class VoluntarioComentarioViewModel
    {
        public required int VoluntarioId { get; set; }

        public required int UsuarioId { get; set; }

        public required string Comentario { get; set; }

        public required DateTime FechaCreacion { get; set; }
    }
}
