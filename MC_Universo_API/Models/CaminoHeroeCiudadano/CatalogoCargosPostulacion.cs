using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class CatalogoCargosPostulacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int NivelCargoId { get; set; }
        [ForeignKey("NivelCargoId")]
        public virtual CatalogoNivelesCargos CatalogoNivelesCargos { get; set; } = default!;

        public int? EntidadFederativaId { get; set; }
        [ForeignKey("EntidadFederativaId")]
        public virtual EntidadFederativa? EntidadFederativa { get; set; }

        public required string Nombre { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
