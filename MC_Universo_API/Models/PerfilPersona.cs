using MC_Universo_API.Models.Precandidaturas;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    [Index(nameof(PerfilId), IsUnique = true)]
    [Index(nameof(PersonaId), IsUnique = true)]
    public class PerfilPersona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int PerfilId { get; set; }
        [ForeignKey("PerfilId")]
        public virtual Perfil Perfil { get; set; } = default!;

        public required int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public virtual Persona Persona { get; set; } = default!;

        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; }
    }
}
