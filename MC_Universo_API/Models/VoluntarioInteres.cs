using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class VoluntarioInteres
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int VoluntarioId { get; set; }
        [ForeignKey("VoluntarioId")]
        public virtual Voluntario Voluntario { get; set; } = default!;

        public required int InteresId { get; set; }
        [ForeignKey("InteresId")]
        public virtual Interes Interes { get; set; } = default!;
    }
}
