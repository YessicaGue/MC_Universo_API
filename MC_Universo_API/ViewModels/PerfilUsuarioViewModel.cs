using MC_Universo_API.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PerfilUsuarioViewModel
    {
        //public int? PerfilId { get; set; }
        
        public required string Name { get; set; }

        public required string Email { get; set; }

        public DateTime? EmailVerifiedAt { get; set; }

        public required string Password { get; set; }

        public string? Area { get; set; }

        public string? Puesto { get; set; }

        public string? ProfileImage { get; set; }
        
        public string? FotoPortada { get; set; }

        public bool Activo { get; set; } = true;

        public bool? EsCHC { get; set; } = false;

        public Guid? EmailResetToken { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
