using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class FormularioTemasInteresCatalogoCausasLanding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int FormularioTemasInteresId { get; set; }
        [ForeignKey("FormularioTemasInteresId")]
        public virtual FormularioTemasInteres FormularioTemasInteres { get; set; } = default!;

        public required int CatalogoCausasLandingId { get; set; }
        [ForeignKey("CatalogoCausasLandingId")]
        public virtual CatalogoCausasLanding CatalogoCausasLanding { get; set; } = default!;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
