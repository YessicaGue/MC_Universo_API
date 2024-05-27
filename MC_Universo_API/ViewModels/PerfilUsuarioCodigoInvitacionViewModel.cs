using MC_Universo_API.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PerfilUsuarioCodigoInvitacionViewModel
    {
        public required int PerfilUsuarioId { get; set; }
        
        public required int CodigoInvitacionId { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; }
    }
}
