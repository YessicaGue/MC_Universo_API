using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PerfilSiguePerfilGrupalViewModel
    {
        public required int PerfilGrupalSeguidoId { get; set; }

        public required int PerfilSeguidorId { get; set; }

        public bool? Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
