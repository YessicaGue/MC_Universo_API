using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class PerfilUsuarioPerfilGrupal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int PerfilUsuarioId { get; set; }
        [ForeignKey("PerfilUsuarioId")]
        public virtual PerfilUsuario PerfilUsuario { get; set; } = default!;

        public required int PerfilGrupalId { get; set; }
        [ForeignKey("PerfilGrupalId")]
        public virtual PerfilGrupal PerfilGrupal { get; set; } = default!;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
