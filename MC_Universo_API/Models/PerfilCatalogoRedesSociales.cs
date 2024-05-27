using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class PerfilCatalogoRedesSociales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int CatalogoRedesSocialesId { get; set; }

        [ForeignKey("CatalogoRedesSocialesId")]
        public virtual CatalogoRedesSociales CatalogoRedesSociales { get; set; } = default!;

        public required int PerfilId { get; set; }
        [ForeignKey("PerfilId")] public virtual Perfil Perfil { get; set; } = default!;

        public string? Url { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaBaja { get; set; }
    }
}