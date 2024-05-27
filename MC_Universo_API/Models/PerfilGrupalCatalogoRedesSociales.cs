using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models
{
    public class PerfilGrupalCatalogoRedesSociales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int CatalogoRedesSocialesId { get; set; }
        [ForeignKey("CatalogoRedesSocialesId")]
        public virtual CatalogoRedesSociales CatalogoRedesSociales { get; set; } = default!;

        public required int PerfilGrupalId { get; set; }
        [ForeignKey("PerfilGrupalId")]
        public virtual PerfilGrupal PerfilGrupal { get; set; } = default!;

        public string? Url { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    }
}
