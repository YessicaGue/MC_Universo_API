using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class ProgramaArea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int ProgramaId { get; set; }
        [ForeignKey("ProgramaId")]
        public virtual Programa Programa { get; set; } = default!;

        public required int AreaId { get; set; }
        [ForeignKey("AreaId")]
        public virtual Area Area { get; set; } = default!;
    }
}
