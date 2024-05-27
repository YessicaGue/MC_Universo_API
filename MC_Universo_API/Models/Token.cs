using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class Token
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int CatalogoTokenId { get; set; }
        [ForeignKey("CatalogoTokenId")]
        public virtual CatalogoTokens CatalogoTokens { get; set; } = default!;

        public string? Nombre { get; set; }

        public required string StringifiedToken { get; set; }

        public bool Expirable { get; set; } = false;

        public int? SegundosExpira { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
