using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class ContenidoPantallasEtapasCHCCatalogoEtapasCHC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int CatalogoEtapasCHCId { get; set; }
        [ForeignKey("CatalogoEtapasCHCId")]
        public virtual CatalogoEtapasCHC CatalogoEtapasCHC { get; set; } = default!;

        public int ContenidoPantallasEtapasCHCId { get; set; }
        [ForeignKey("ContenidoPantallasEtapasCHCId")]
        public virtual ContenidoPantallasEtapasCHC ContenidoPantallasEtapasCHC { get; set; } = default!;

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaActualizacion { get; set; }
    }
}
