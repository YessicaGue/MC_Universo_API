using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class PerfilPersonaCHC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public virtual Persona Persona { get; set; } = default!;

        public int PerfilId { get; set; }
        [ForeignKey("PerfilId")]
        public virtual Perfil Perfil { get; set; } = default!;

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    }
}
