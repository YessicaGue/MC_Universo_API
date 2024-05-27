using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models
{
    public class VoluntarioComentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int VoluntarioId { get; set; }
        [ForeignKey("VoluntarioId")]
        public virtual Voluntario Voluntario { get; set; } = default!;

        public required int UsuarioId { get; set; }

        public required string Comentario { get; set; }

        public required DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
