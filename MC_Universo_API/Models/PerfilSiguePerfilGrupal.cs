using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models
{
    public class PerfilSiguePerfilGrupal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int PerfilGrupalSeguidoId { get; set; }
        [ForeignKey("PerfilGrupalSeguidoId")]
        public virtual PerfilGrupal PerfilGrupalSeguido { get; set; } = default!;

        public required int PerfilSeguidorId { get; set; }
        [ForeignKey("PerfilSeguidorId")]
        public virtual Perfil PerfilSeguidor { get; set; } = default!;

        public bool? Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}

