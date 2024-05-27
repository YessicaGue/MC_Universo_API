using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PerfilUsuarioPerfilGrupalViewModel
    {
        public required int PerfilUsuarioId { get; set; }

        public required int PerfilGrupalId { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
