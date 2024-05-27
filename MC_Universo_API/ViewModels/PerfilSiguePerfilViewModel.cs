using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PerfilSiguePerfilViewModel
    {
        public required int PerfilSeguidoId { get; set; }

        public required int PerfilSeguidorId { get; set; }

        public bool? Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;

        public bool? EnCirculo { get; set; } = false;
    }
}
