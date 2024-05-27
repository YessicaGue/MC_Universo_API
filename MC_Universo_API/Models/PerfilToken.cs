using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class PerfilToken
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int PerfilId { get; set; }
        [ForeignKey("PerfilId")]
        public virtual Perfil Perfil { get; set; } = default!;

        public required int TokenId { get; set; }
        [ForeignKey("TokenId")]
        public virtual Token Token { get; set; } = default!;

        public string? Response { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
