using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class UsuarioPerfilViewModel
    {
        public required int UsuarioId { get; set; }

        public required int PerfilId { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
