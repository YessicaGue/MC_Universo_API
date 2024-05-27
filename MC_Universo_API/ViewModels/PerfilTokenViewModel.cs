using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PerfilTokenViewModel
    {
        public required int PerfilId { get; set; }

        public required int TokenId { get; set; }

        public string? Response { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
