using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models
{
    [Index(nameof(PerfilId), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class PerfilUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int PerfilId { get; set; }
        [ForeignKey("PerfilId")] public virtual Perfil Perfil { get; set; } = default!;

        public required string Name { get; set; }

        //public string? Username { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required string Email { get; set; }

        public DateTime? EmailVerifiedAt { get; set; }

        public required string Password { get; set; }

        public string? Area { get; set; }

        public string? Puesto { get; set; }

        public string? ProfileImage { get; set; }

        public bool Activo { get; set; } = true;

        [Comment("Esta columna indica si hizo el registro del perfil desde la liga para redireccionar directamente a CHC")]
        public bool? EsCHC { get; set; } = false;

        public Guid? EmailResetToken { get; set; }
        
        public string? FotoPortada { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaBaja { get; set; }
    }
}