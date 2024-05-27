using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models
{
    public class PerfilUsuarioCodigoInvitacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
    
        public required int PerfilUsuarioId { get; set; }
        [ForeignKey("PerfilUsuarioId")]
        public virtual PerfilUsuario PerfilUsuario { get; set; } = default!;

        [Comment("Esta columna es una llave foranea que viene de la DB de dashboard")]
        public required int CodigoInvitacionId { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; }
    }
}
