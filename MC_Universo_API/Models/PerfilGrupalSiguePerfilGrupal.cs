using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class PerfilGrupalSiguePerfilGrupal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int PerfilGrupalSeguidoId { get; set; }
        [ForeignKey("PerfilGrupalSeguidoId")]
        public virtual PerfilGrupal PerfilGrupalSeguido { get; set; } = default!;

        public required int PerfilGrupalSeguidorId { get; set; }
        [ForeignKey("PerfilGrupalSeguidorId")]
        public virtual PerfilGrupal PerfilGrupalSeguidor { get; set; } = default!;

        public bool? Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
