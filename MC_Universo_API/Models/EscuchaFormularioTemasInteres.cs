using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class EscuchaFormularioTemasInteres
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int EscuchaId { get; set; }
        [ForeignKey("EscuchaId")]
        public virtual Escucha Escucha { get; set; } = default!;

        public required int FormularioTemasInteresId { get; set; }
        [ForeignKey("FormularioTemasInteresId")]
        public virtual FormularioTemasInteres FormularioTemasInteres { get; set; } = default!;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
