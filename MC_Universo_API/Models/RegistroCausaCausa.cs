using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class RegistroCausaCausa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int RegistroCausaId { get; set; }
        [ForeignKey("RegistroCausaId")]
        public virtual RegistroCausa RegistroCausa { get; set; } = default!;

        public required int CausaId { get; set; }
        [ForeignKey("CausaId")]
        public virtual Causa Causa { get; set; } = default!;
    }
}
