using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models
{
    public class PerfilSiguePerfil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }
        public required int PerfilSeguidoId { get; set; }
        [ForeignKey("PerfilSeguidoId")]
        public virtual Perfil PerfilSeguido { get; set; } = default!;

        public required int PerfilSeguidorId { get; set; }
        [ForeignKey("PerfilSeguidorId")]
        public virtual Perfil PerfilSeguidor { get; set; } = default!;
        
        public bool? EnCirculo { get; set; } 

        public bool? Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
