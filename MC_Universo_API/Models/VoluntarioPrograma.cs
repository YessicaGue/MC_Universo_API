using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models
{
    public class VoluntarioPrograma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int VoluntarioId { get; set; }
        [ForeignKey("VoluntarioId")]
        public virtual Voluntario Voluntario { get; set; } = default!;

        public required int ProgramaId { get; set; }
        [ForeignKey("ProgramaId")]
        public virtual Programa Programa { get; set; } = default!;

        public bool? Activo { get; set; } = true;
    }
}
